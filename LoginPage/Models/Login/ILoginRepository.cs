using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Models.Login
{
    public interface ILoginRepository
    {
        bool authenticate_User(string Email, string password);
    }
}
