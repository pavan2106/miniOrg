﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace API1.Models
{
    public class CustomUserSore<T> : IUserStore<T> where T : ApplicationUser
    {

        //System.Threading.Tasks.Task IUserStore<T>.CreateAsync(T user)
        //{
        //    //Create /Register New User
        //    throw new NotImplementedException();
        //}

        //System.Threading.Tasks.Task IUserStore<T>.DeleteAsync(T user)
        //{
        //    //Delete User
        //    throw new NotImplementedException();
        //}

        //System.Threading.Tasks.Task<T> IUserStore<T>.FindByIdAsync(string userId)
        //{
        //    throw new NotImplementedException();
        //}

        //System.Threading.Tasks.Task<T> IUserStore<T>.FindByNameAsync(string userName)
        //{
        //    throw new NotImplementedException();
        //}

        //System.Threading.Tasks.Task IUserStore<T>.UpdateAsync(T user)
        //{
        //    //Update User Profile
        //    throw new NotImplementedException();
        //}

        void IDisposable.Dispose()
        {
            // throw new NotImplementedException();

        }

        #region IUserStore<T,string> Members

        System.Threading.Tasks.Task IUserStore<T, string>.CreateAsync(T user)
        {
          throw new NotImplementedException();
        }

        System.Threading.Tasks.Task IUserStore<T, string>.DeleteAsync(T user)
        {
          throw new NotImplementedException();
        }

        System.Threading.Tasks.Task<T> IUserStore<T, string>.FindByIdAsync(string userId)
        {
          throw new NotImplementedException();
        }

        System.Threading.Tasks.Task<T> IUserStore<T, string>.FindByNameAsync(string userName)
        {
          throw new NotImplementedException();
        }

        System.Threading.Tasks.Task IUserStore<T, string>.UpdateAsync(T user)
        {
          throw new NotImplementedException();
        }

        #endregion
    }
}