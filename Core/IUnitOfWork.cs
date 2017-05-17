using System;
using System.Threading.Tasks;

namespace NewCo.Core
{
  public interface IUnitOfWork
  {
    Task CompleteAsync();
  }
}