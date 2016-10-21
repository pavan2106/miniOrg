using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examples.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult Index()
        {
          DBConnection.Connection.newConnectio();
          int s= DBConnection.Connection.ExecuteReader("select top 1 * from person", null);
          SqlDataReader reader = DBConnection.Connection.Read();
          if(reader!=null )
          {
           ViewBag.personpk = reader["personpk"];
          }
          DBConnection.Connection.ReaderClose();
          DBConnection.Connection.ConnctionClose();


            return View();
        }
    }
}