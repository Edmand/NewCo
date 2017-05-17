using System.Threading.Tasks;
using NewCo.Core.Models;

namespace NewCo.Core
{
    public interface IAccountRepository
    {
        // Task<Account> GetAccount(int AccountId, bool includeRelated = true); 
        Task<Account> GetAccount(int AccountId, bool includeRelated = false); 
        void Add(Account account);
        void Remove(Account account);
    }
}