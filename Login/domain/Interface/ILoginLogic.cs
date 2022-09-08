using domain.domain.DTO;
using domain.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interface
{
    public interface ILoginLogic
    {
        bool AddUser(UserModel request);
        UserDTO UserLogin(UserLoginModel request);
        bool UserAlterar(string email);
        bool UserExcluir(string email);

        
    }
}
