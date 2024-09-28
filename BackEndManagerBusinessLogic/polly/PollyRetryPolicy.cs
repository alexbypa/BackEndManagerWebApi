using Polly;

namespace BackEndManagerBusinessLogic.polly;
public class PollyRetryPolicy {
    public async Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> action, Func<TResult, bool> retryCondition) {
        AsyncPolicy<TResult> retryPolicy = Policy
            .HandleResult<TResult>(retryCondition) 
            .WaitAndRetryAsync<TResult>(3, retryAttempt => TimeSpan.FromSeconds(2),
                (result, timeSpan, retryCount, context) => {
                    if (result.Exception != null) 
                        Console.WriteLine(result.Exception.ToString());
                    else
                        Console.WriteLine(result.Result.ToString());
                    Console.WriteLine($"Tentativo fallito {retryCount}. Ritenterò tra {timeSpan.TotalSeconds} secondi.");
                });
        return await retryPolicy.ExecuteAsync(action);
    }
}
