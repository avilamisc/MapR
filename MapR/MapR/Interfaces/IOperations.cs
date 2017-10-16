using MapR.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MapR.Interfaces
{
  /// <summary>
  /// Operaciones
  /// </summary>
  public interface IOperations
  {
    Task<List<BranchModel>> GetBranchOffices();
  }
}
