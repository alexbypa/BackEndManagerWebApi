using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

namespace BackEndManagerBusinessLogic.healtchecks {
    public class SystemResourcesHealthCheck : HealthCheckHandler {
        protected override Task<HealthCheckResult> PerformHealthCheckAsync() {
            var process = Process.GetCurrentProcess();

            // Ottieni utilizzo della CPU in percentuale
            double cpuUsage = GetCpuUsage(process);

            // Ottieni utilizzo della memoria in MB
            double memoryUsage = process.WorkingSet64 / (1024 * 1024);

            // Definisci un limite (es. CPU < 80% e Memoria < 500MB)
            var maxCpuUsage = 80;
            var maxMemoryUsage = 500;

            // Verifica se i valori superano i limiti
            var status = (cpuUsage < maxCpuUsage && memoryUsage < maxMemoryUsage)
                ? HealthStatus.Healthy
                : HealthStatus.Unhealthy;

            var data = new Dictionary<string, object>
            {
            { "CPU Usage (%)", cpuUsage },
            { "Memory Usage (MB)", memoryUsage }
        };

            return Task.FromResult(new HealthCheckResult(
                status,
                description: "Health check for system resources",
                data: data
            ));
        }
        private double GetCpuUsage(Process process) {
            // Formula per calcolare l'uso della CPU
            return process.TotalProcessorTime.TotalMilliseconds / (Environment.ProcessorCount * 1000);
        }
    }
}
