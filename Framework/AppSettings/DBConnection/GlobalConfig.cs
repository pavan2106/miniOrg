using System.Configuration;

namespace DBConnection
{
  public class GlobalConfig
  {
    public string connectionString { get { return System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; } }
  }
}
