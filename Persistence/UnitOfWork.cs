using System.Threading.Tasks;
using NewCo.Core; 

namespace NewCo.Persistence
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly NewCoDbContext context;

    public UnitOfWork(NewCoDbContext context)
    {
      this.context = context;
    }

    public async Task CompleteAsync()
    {
      await context.SaveChangesAsync();
    }
  }
}