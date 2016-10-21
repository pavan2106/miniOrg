using System.Configuration;

namespace DBConnection
{
  internal class GlobalConfig
  {
    public static string connectionString
    {
      get
      {
        if (string.IsNullOrEmpty(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
          throw new System.ArgumentException("DBConnection cannot be null", "original");
        return System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
      }
    }
  }
}
