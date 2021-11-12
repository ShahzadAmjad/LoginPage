using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models.Login
{
    public class SQLLoginRepository : ILoginRepository
    {
        private readonly AppDbContext Context;
        public SQLLoginRepository(AppDbContext context)
        {
            Context = context;
        }
        public bool authenticate_User(string Email, string password)
        {
            Login login = new Login();
            login = Context.Users.Where(h => h.Email == Email &  h.Password == password).FirstOrDefault();
            
            if (login!=null)
            {
                return true;
            }
            else
            {
                return false;
            }       
        }
    }
}
