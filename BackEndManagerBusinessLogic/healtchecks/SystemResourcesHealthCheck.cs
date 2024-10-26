using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

namespace BackEndManagerBusinessLogic.healtchecks {
    public class SystemResourcesHealthCheck : HealthCheckHandler {
        protected override async Task<HealthCheckResult> PerformHealthCheckAsync() {
            var process = Process.GetCurrentProcess();

            // Ottieni utilizzo della CPU in percentuale
            double cpuUsage = GetCpuUsage(process);

            // Ottieni utilizzo della memoria in MB
            double memoryUsage = process.WorkingSet64 / (1024 * 1024);

            // Definisci un limite (es. CPU < 80% e Memoria < 500MB)
            var maxCpuUsage = 80;
            var maxMemoryUsage = 500;

            // Verifica se i valori superano i limiti
            var status = (cpuUsage < maxCpuUsage && memoryUsage < maxMemoryUsage);
                //? HealthStatus.Healthy
                //: HealthStatus.Unhealthy;

            if (status) 
                return HealthCheckResult.Healthy($"- **CPU Usage**: {cpuUsage}%\n - **Memory Usage**: {memoryUsage} MB");
            else
                return HealthCheckResult.Unhealthy($"- **CPU Usage**: {cpuUsage}%\n - **Memory Usage**: {memoryUsage} MB");

        }
        private double GetCpuUsage(Process process) {
            // Formula per calcolare l'uso della CPU
            return process.TotalProcessorTime.TotalMilliseconds / (Environment.ProcessorCount * 1000);
        }
    }
}
