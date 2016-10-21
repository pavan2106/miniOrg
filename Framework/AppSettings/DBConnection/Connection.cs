using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Threading.Tasks;
using AppErrorCodes;

namespace DBConnection
{
  public sealed class Connection
  {
    private static readonly Connection instance = new Connection();
    private string connectionString = GlobalConfig.connectionString;
    private static SqlConnection connection= new SqlConnection();
    private static SqlDataReader reader = new SqlDataReader();
    private static SqlCommand command = new SqlCommand();
    private Connection() {}

    public static Connection Instance
    {
      get
      {
        return instance;
      }
    }

    public static int ExecuteNonQuery(string query)
    {
      if (string.IsNullOrEmpty(query))
        throw new Exception(ErrorCodes.ExecuteNonQuery.ToString());
      using (connection = new SqlConnection(Instance.connectionString))
      {
        SqlCommand command = new SqlCommand(query, connection);
        command.Connection.Open();
        command.ExecuteNonQuery();
      }
      return ErrorCodes.ExecuteNonQuery;
    }
    private static SqlParameterCollection spc;
    public static void newCommand(string str)
    {
      command = new SqlCommand(str, connection);
    }
    public static void addParameter(string parameterName, object value ,SqlDbType type)
    {
      SqlParameter paramter= new SqlParameter(parameterName, value);

      command.Parameters.Add(paramter);
    }
    public static int ExecuteSP(string spName)
    {
      if (string.IsNullOrEmpty(spName))
        throw new Exception(ErrorCodes.ExecuteNonQuery.ToString());
        command.CommandType = CommandType.StoredProcedure;
        command.Connection.Open();
        command.ExecuteNonQuery();
 
      return ErrorCodes.ExecuteNonQuery;
    }
    public static SqlDataReader Read()
    {
      reader.Read();
      return reader;
    }
    public static void ConnctionClose()
    {
      connection.Close();
    }
    public static void ReaderClose()
    {
      reader.Close();
    }
    public static void newConnectio()
    {
      connection = new SqlConnection(Instance.connectionString);
    }
    public static int ExecuteReader(string query, IList<string> listKeys)
    {
      if (string.IsNullOrEmpty(query))
         throw new Exception(ErrorCodes.ExecuteReader.ToString());
      try
      {
        if (connection.State == ConnectionState.Closed)
          connection.Open();     
        command = new SqlCommand(query, connection);
        reader = command.ExecuteReader();
        return 1;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }  
    //public static Task<int> ExecuteNonQueryAsync(string query)
    //{

    //  Task<int> numberofrows;
    //  using (SqlConnection connection = new SqlConnection(Instance.connectionString))
    //  {
    //    //SqlCommand command = new SqlCommand(query, connection);
    //    //command.Connection.Open();
    //    //numberofrows = await command.ExecuteNonQueryAsync();
    //    //command.Connection.Close();
    //    await connection.OpenAsync();
    //    using (var tran = connection.BeginTransaction())
    //    {
    //      using (var command = new SqlCommand(sqlQuery, connection, tran))
    //      {
    //        try
    //        {
    //          await command.ExecuteNonQueryAsync();
    //        }
    //        catch (Exception)
    //        {
    //          tran.Rollback();
    //          throw;
    //        }
    //        tran.Commit();
    //      }
    //    }
    //  }
    // return numberofrows;
    //}

  }
}
