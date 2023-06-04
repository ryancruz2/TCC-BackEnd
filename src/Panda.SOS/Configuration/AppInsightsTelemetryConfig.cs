namespace Panda.SOS.Configuration;
public class AppInsightsTelemetryConfig : ITelemetryInitializer
{
    public void Initialize(ITelemetry telemetry)
    {
        if (string.IsNullOrEmpty(telemetry.Context.Cloud.RoleName))
        {
            telemetry.Context.Cloud.RoleName = "panda-service";
        }
    }
}
