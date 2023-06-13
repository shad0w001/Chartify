using Chartify.Models;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace LoginTesting.Services.Interfaces
{
    public interface IUserServices
    {
        List<User> GetAll();
        User GetUserById(string id);
    }
}
