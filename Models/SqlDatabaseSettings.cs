namespace Signalify.Models;

interface ISqlDatabaseSettings
{
    public string? ConnectionString { get; set; }
}

public class SqlDatabaseSettings : ISqlDatabaseSettings
{
    public string? ConnectionString { get; set; }

    public SqlDatabaseSettings(IConfiguration configuration)
    {
        ConnectionString = configuration.GetValue<string>("Database:ConnectionString");
    }
}