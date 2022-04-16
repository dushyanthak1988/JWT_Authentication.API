using JWT_Authentication.Entities;
using JWT_Authentication.Models.RequstModel;
using JWT_Authentication.Models.ResponseModel;
using System.Collections.Generic;

namespace JWT_Authentication.Concert
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        void RevokeToken(string token, string ipAddress);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }

}
