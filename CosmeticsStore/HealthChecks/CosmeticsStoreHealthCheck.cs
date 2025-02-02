using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CosmeticsStore.HealthChecks
{
    public class CosmeticsStoreHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            var isHealthy = true;

            ....

            if (isHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("Cosmetics Store is running fine."));
            }

            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "Cosmetics Store is experiencing issues."));
        }
    }
}

