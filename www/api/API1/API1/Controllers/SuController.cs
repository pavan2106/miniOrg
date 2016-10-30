using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using API1.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace API1.Controllers
{
    public class SuController : ApiController
    {
      private  CustomUserManager cust= new CustomUserManager();
      public CustomUserManager PCustomUserManager { get {return this.cust;} }
      [HttpGet]
      public string Mictest()
      {
        return "1234";
      }
      [HttpGet]
      public string Login(string username="", string passsword="", bool isPersistent=true)
      {
        string value = string.Empty;
        var user = PCustomUserManager.Find(username, passsword);
        if (user != null)
        {
          SignIn(user, isPersistent);
          value = "Done";
        }
        else
        {
          value = "Invalid username or password.";
        }
        return value;
        //return "Hello "+ username;
      }
      // public SuController()
      //   // : this(new CustomUserManager())
      // {
      //   PCustomUserManager = new CustomUserManager();
      //   }  
      //public SuController(CustomUserManager customUserManager)
      //  {
      //      PCustomUserManager = customUserManager;
      //  }

      private async Task<string> priLogin(string username, string passsword, bool isPersistent)
      {
        string value = string.Empty;
        var user = await PCustomUserManager.FindAsync(username, passsword);
        if (user != null)
        {
          await SignInAsync(user, isPersistent);
          value= "Done";
        }
        else
        {
         value="Invalid username or password.";
        }
        return value;
        //return "done";
      }
       private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

      private async Task SignInAsync(ApplicationUser user, bool isPersistent)
      {
        AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

        ///Open Question- Hear it create claimIdentity. But we nothing add as such Claims but just User object.
        //public virtual Task<ClaimsIdentity> CreateIdentityAsync(TUser user, string authenticationType);

        //  var identity = await CustomUserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
        //var identity = await UserManager1.CreateAsync(user);//, DefaultAuthenticationTypes.ApplicationCookie);
        var claims = new List<Claim>();
        claims.Add(new Claim(ClaimTypes.Name, "Brock"));
        claims.Add(new Claim(ClaimTypes.Email, "brockallen@gmail.com"));
        var id = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

        AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, id);
      }
      private void SignIn(ApplicationUser user, bool isPersistent)
      {
        AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

        ///Open Question- Hear it create claimIdentity. But we nothing add as such Claims but just User object.
        //public virtual Task<ClaimsIdentity> CreateIdentityAsync(TUser user, string authenticationType);

        //  var identity = await CustomUserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
        //var identity = await UserManager1.CreateAsync(user);//, DefaultAuthenticationTypes.ApplicationCookie);
        var claims = new List<Claim>();
        claims.Add(new Claim(ClaimTypes.Name, "Brock"));
        claims.Add(new Claim(ClaimTypes.Email, "brockallen@gmail.com"));
        var id = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

        AuthenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = isPersistent }, id);
      }
    }
}
