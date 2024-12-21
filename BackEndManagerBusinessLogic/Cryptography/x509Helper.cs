using Nest;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BackEndManagerBusinessLogic.Cryptography;
public class X509Helper {
    internal X509Certificate2 x509certificate;
    internal X509Certificate2 publicCert;
    public Exception? exToThrow;
    RSACng provider;
    /// <summary>
    /// constructor to load the public key  
    /// </summary>
    /// <param name="UNCPublicKey"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public X509Helper(string UNCPublicKey) {
        try {
            x509certificate = new X509Certificate2(File.ReadAllBytes(UNCPublicKey));
            provider = x509certificate.GetRSAPublicKey() as RSACng ?? throw new InvalidOperationException("Public key is null.");
            publicCert = x509certificate; // Initialize publicCert to avoid CS8618
            exToThrow = null;
        } catch (Exception ex) {
            x509certificate = null!;
            provider = null!;
            publicCert = null!;
            exToThrow = ex;
        }
    }
    /// <summary>
    /// constructor to load the private key
    /// </summary>
    /// <param name="UNCPrivateKey"></param>
    /// <param name="passPhrase"></param>
    public X509Helper(string UNCPrivateKey, string passPhrase) {
        x509certificate = new X509Certificate2(UNCPrivateKey, passPhrase, X509KeyStorageFlags.MachineKeySet);
        provider = x509certificate.GetRSAPrivateKey() as RSACng ?? throw new InvalidOperationException("Private key is null.");
        publicCert = x509certificate; //Initialize publicCert to avoid CS8618
        exToThrow = null;
    }
    /// <summary>
    /// Encrypt the text    
    /// </summary>
    /// <param name="clearText"></param>
    /// <returns></returns>
    public string encrypt(string clearText) {
        string encMsg = "";
        try {
            byte[] plainText = ASCIIEncoding.ASCII.GetBytes(clearText);
            int RSA_BLOCKSIZE = 58;
            int lastBlockLength = plainText.Length % RSA_BLOCKSIZE;
            double blockCount = Math.Floor((double)(plainText.Length / RSA_BLOCKSIZE));
            bool hasLastBlock = false;
            if (!lastBlockLength.Equals(0)) {
                blockCount += 1;
                hasLastBlock = true;
            }
            byte[] result = new byte[0];
            for (int blockIndex = 0; blockIndex <= blockCount - 1; blockIndex++) {
                int thisBlockLength = 0;
                if (blockCount.Equals(blockIndex + 1) && hasLastBlock) {
                    thisBlockLength = lastBlockLength;
                } else {
                    thisBlockLength = RSA_BLOCKSIZE;
                }
                int startChar = blockIndex * RSA_BLOCKSIZE;
                byte[] currentBlock = new byte[thisBlockLength];
                Array.Copy(plainText, startChar, currentBlock, 0, thisBlockLength);
                byte[] encryptedBlock = provider.Encrypt(currentBlock, RSAEncryptionPadding.Pkcs1);
                int originalResultLength = result.Length;
                Array.Resize(ref result, originalResultLength + encryptedBlock.Length);
                encryptedBlock.CopyTo(result, originalResultLength);
            }
            provider.Clear();
            encMsg = Convert.ToBase64String(result);
        } catch (Exception ex) {
            exToThrow = ex;
        }
        return encMsg;
    }
    /// <summary>
    /// decrypt the text    
    /// </summary>
    /// <param name="encText"></param>
    /// <returns></returns>
    public string decrypt(string encText) {
        string DecyptText = "";
        try {
            byte[] bytesToDecrypt = Convert.FromBase64String(encText);
            int blockSize = provider.KeySize / 8;
            byte[] buffer = new byte[blockSize];
            byte[] decryptedBuffer = new byte[blockSize];
            byte[] decryptedBytes = new byte[encText.Length];
            for (int i = 0; i < bytesToDecrypt.Length; i += blockSize) {
                if (2 * i > bytesToDecrypt.Length && ((bytesToDecrypt.Length - i) % blockSize != 0)) {
                    buffer = new byte[bytesToDecrypt.Length - i];
                    blockSize = bytesToDecrypt.Length - i;
                }

                //// If the amount of bytes we need to decrypt isn't enough to fill out a block, only decrypt part of it
                if (bytesToDecrypt.Length < blockSize) {
                    buffer = new byte[bytesToDecrypt.Length];
                    blockSize = bytesToDecrypt.Length;
                }

                Buffer.BlockCopy(bytesToDecrypt, i, buffer, 0, blockSize);
                decryptedBuffer = provider.Decrypt(buffer, RSAEncryptionPadding.Pkcs1);
                decryptedBuffer.CopyTo(decryptedBytes, i);
            }
            DecyptText = new ASCIIEncoding().GetString(decryptedBytes);
        } catch (Exception ex) {
            exToThrow = ex;
        }
        return DecyptText;
    }
    /// <summary>
    /// Create a sign for the text  
    /// </summary>
    /// <param name="WhatSign"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public string CreateSign(string WhatSign) {
        string firma = "";
        try {
            RSA? rsaProvider = x509certificate.GetRSAPrivateKey();
            if (rsaProvider == null) {
                throw new InvalidOperationException("Private key is null.");
            }
            ASCIIEncoding ByteConverter = new ASCIIEncoding();
            Byte[] sign_this = ByteConverter.GetBytes(WhatSign);
            Byte[] Signature = rsaProvider.SignData(sign_this, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            firma = Convert.ToBase64String(Signature);
        } catch (Exception ex) {
            exToThrow = ex;
        }
        return firma;
    }
    /// <summary>
    /// internal method to verify the sign  
    /// </summary>
    /// <param name="text"></param>
    /// <param name="firma"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="Exception"></exception>
    public bool VerifySign(string text, string firma, IRequest request) {
        bool response = false;
        try {
            RSA? rsaProvider = publicCert.GetRSAPublicKey();
            if (rsaProvider == null) {
                throw new InvalidOperationException("Public key is null.");
            }
            using (SHA1 sha1 = SHA1.Create()) {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] signature = Convert.FromBase64String(firma);
                byte[] digest = sha1.ComputeHash(encoding.GetBytes(text));
                byte[] data = encoding.GetBytes(text);
                response = rsaProvider.VerifyData(data, signature, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            }
        } catch (Exception ex) {
            exToThrow = ex;
        }
        if (exToThrow != null) {
            throw new Exception(exToThrow.Message);
        }
        return response;
    }
}