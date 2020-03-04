using System.Collections.Generic;
using WebApi3.Domain.Models;

namespace WebApi3.Interfaces
{
    public interface Users
    {
        Dictionary<int, User> Users { get; }
        void SetCurrency(int userId, int value);
        AddUserMessage Add(AddUserRequest request);
        int Delete(int id);
    }
}