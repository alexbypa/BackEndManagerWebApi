﻿using System.Threading.RateLimiting;

namespace BackEndManagerBusinessLogic.httphelper {
    public class HttpClientHandler : DelegatingHandler {
        public Action<HttpRequestMessage, HttpResponseMessage, DateTime, DateTime>? logAction;
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            DateTime timeRequest = DateTime.Now;
            var response = await base.SendAsync(request, cancellationToken);
            logAction?.Invoke(request, response, timeRequest, DateTime.Now);
            return response;
        }
    }

    //public class httpBindingOptions {
    //    public httpBindingOptions() { }
    //    HttpClientHandler instance { get; set; }
    //    public HttpMessageHandler getCertificateForHttpHandler(string certificatePath, string password) {
    //        instance = new HttpClientHandler();
    //        if (!string.IsNullOrEmpty(certificatePath)) {
    //            try {
    //                var clientCertificate = new X509Certificate2(certificatePath, password, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);
    //                instance.ClientCertificates.Add(clientCertificate);
    //            } catch (Exception ex) {
    //                //TODO:
    //                //loggerExtension.TraceAsync("getCertificateForHttpHandler", DateTime.Now.Ticks.ToString(), Serilog.Events.LogEventLevel.Error, ex, "Error on getCertificateForHttpHandler");
    //            }
    //        }
    //        return instance;
    //    }
    //}
    //public class LoggerHandler : DelegatingHandler, IAsyncDisposable {
    //    private readonly RateLimiter _rateLimiter;
    //    protected Action<string, HttpRequestMessage, HttpResponseMessage, DateTime, DateTime, string, int, string, string> _TraceMessage;
    //    public string idTransaction { get; set; }
    //    protected readonly HttpContext _httpContext;
    //    private static HttpClientHandler baseHttpClientHandler(bool AcceptAnyCertificate) {
    //        if (AcceptAnyCertificate)
    //            return new HttpClientHandler() { ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator };
    //        else
    //            return new HttpClientHandler();
    //    }
    //    public LoggerHandler(
    //        RateLimiter limiter,
    //        Action<string, HttpRequestMessage, HttpResponseMessage, DateTime, DateTime, string, int, string, string> TraceMessage,
    //        Action<string, string, string> TraceException,
    //        bool AcceptAnyCertificate,
    //        string idTransaction
    //    ) : base(baseHttpClientHandler(AcceptAnyCertificate)) {
    //        _rateLimiter = limiter;
    //        _TraceMessage = TraceMessage;
    //        this.idTransaction = idTransaction;
    //    }
    //    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
    //        bool IsAcquired = true;
    //        string action = $"[Trace HTTP] {request.RequestUri}";
    //        if (_rateLimiter != null) {
    //            using RateLimitLease lease = await _rateLimiter.AcquireAsync(permitCount: 1, cancellationToken);
    //            IsAcquired = lease.IsAcquired;
    //        }
    //        HttpResponseMessage response = null;
    //        if (IsAcquired) {
    //            StringBuilder requestLog = new StringBuilder();
    //            DateTime dtStartRequest = DateTime.Now;
    //            var now = DateTimeOffset.UtcNow;
    //            StringBuilder responseLog = new StringBuilder();
    //            DateTime dtEndRequest = DateTime.Now;
    //            int NrRetry = 0;
    //            string ExceptionRequest = "";
    //            try {
    //                NrRetry = int.Parse(request.Headers.Where(a => a.Key == "NrRetry").FirstOrDefault().Value.FirstOrDefault().ToString());
    //                ExceptionRequest = request.Headers.Where(a => a.Key == "Exception").FirstOrDefault().Value.FirstOrDefault().ToString();
    //                requestLog.Append(request.ToString());
    //                if (request.Content != null) {
    //                    requestLog.Append(await request.Content.ReadAsStringAsync());
    //                }
    //            } catch { }
    //            try {
    //                response = await base.SendAsync(request, cancellationToken);
    //                dtEndRequest = DateTime.Now;
    //                responseLog.Append(response.ToString());
    //                if (response.Content != null) {
    //                    responseLog.Append(await response.Content.ReadAsStringAsync());
    //                }
    //                _TraceMessage.Invoke(action, request, response, dtStartRequest, dtEndRequest, idTransaction, NrRetry, "", response.StatusCode.ToString());
    //            } catch (Exception ex) {
    //                _TraceMessage.Invoke(action, request, response, dtStartRequest, dtEndRequest, idTransaction, NrRetry, ex.ToString(), response.StatusCode.ToString());

    //            }
    //        } else {
    //            using (var responseTooManyRequest = new HttpResponseMessage(HttpStatusCode.TooManyRequests))
    //                response = responseTooManyRequest;
    //        }
    //        return response;
    //    }
    //    async ValueTask IAsyncDisposable.DisposeAsync() {
    //        if (_rateLimiter != null)
    //            await _rateLimiter.DisposeAsync().ConfigureAwait(false);

    //        Dispose(disposing: false);
    //        GC.SuppressFinalize(this);
    //    }
    //    protected override void Dispose(bool disposing) {
    //        base.Dispose(disposing);

    //        if (disposing && _rateLimiter != null) {
    //            _rateLimiter.Dispose();
    //        }
    //    }
    //}
}
