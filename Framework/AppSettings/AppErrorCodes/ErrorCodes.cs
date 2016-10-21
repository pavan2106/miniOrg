using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppErrorCodes
{
    public class ErrorCodes
    {
      /// <summary>
      /// General Error codes
      /// </summary>
      public static int StringEmpty = -2;

      /// <summary>
      /// DataBase ErrorCodes
      /// </summary>
      public static int ExecuteNonQuery = -102;
      public static int ExecuteReader = -103;

      /// <summary>
      /// 
      /// </summary>
      public static int Logerror = -200;
    }
}
