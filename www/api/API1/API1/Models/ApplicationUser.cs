﻿using System;
using Microsoft.AspNet.Identity;


namespace API1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, 
    //please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    
    public class ApplicationUser : IUser
    {
        public DateTime CreateDate { get; set; }
        public DateTime BirthDate { get; set; }

        public ApplicationUser()
        {
            CreateDate = DateTime.Now;           
        }
        public string Id
        {
            get { return "GUID"; // User UUIID
            }
        }

        public string UserName
        {
            get
            {
                return "san";  /// Person UserName  or name of person ?
            }
            set
            {
               ;
            }
        }
    }
 
}