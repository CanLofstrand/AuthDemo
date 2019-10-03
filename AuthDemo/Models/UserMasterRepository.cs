using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthDemo.Models
{
    public class UserMasterRepository : IDisposable
    {
         BookingEntities1 context = new BookingEntities1();

        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMaster.FirstOrDefault(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}