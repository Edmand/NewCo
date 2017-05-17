using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewCo.Core;
using NewCo.Core.Models;

namespace NewCo.Persistence
{
  public class AccountRepository : IAccountRepository
  {
    private readonly NewCoDbContext context;
    public AccountRepository(NewCoDbContext context)
    {
        this.context = context;
    }

    public async Task<Account> GetAccount(int accountId, bool includeRelated = true)
    {
        if (!includeRelated)
          return await context.Accounts.FindAsync(accountId);

        // return await context.Accounts
        //   .Include(v => v.Features)
        //     .ThenInclude(vf => vf.Feature)
        //   .Include(v => v.Model)
        //     .ThenInclude(m => m.Make)
        //   .SingleOrDefaultAsync(v => v.Id == id);
        return new Account();
     }

    public void Add(Account account) 
    {
      context.Accounts.Add(account);
    }

    public void Remove(Account account)
    {
      context.Remove(account);
    }
  }
}