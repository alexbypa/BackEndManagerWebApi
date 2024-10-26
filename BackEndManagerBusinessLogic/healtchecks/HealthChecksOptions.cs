namespace BackEndManagerBusinessLogic.healtchecks;
public class HealthChecksOptions {
    public bool SampleHealthCheck { get; set; }
    public bool CacheHealthCheck { get; set; }
    public bool RedisCheck { get; set; }
    public bool SystemResourcesHealthCheck { get; set; }
    public HealthChecksConnectionStrings ConnectionStrings { get; set; }
    public healtCheckUiSettings UiSettings { get; set; }
}
public class HealthChecksConnectionStrings {
    public string SqlServer { get; set; }
    public string Redis { get; set; }
}
public class healtCheckUiSettings {
    public int SecondPollinginterval { get; set; }
    public string Uri { get; set; }
}

