using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace TaskPlannerApi.Repositories
{
    public interface ISprocRepository
    {
        DbCommand GetStoredProcedure(string name, params (string, object)[] nameValueParams);

        DbCommand GetStoredProcedure(string name);
    }

    public interface ISprocRepository<TSprocEntity> : ISprocRepository
    {
        IList<TSprocEntity> ExecuteStoredProcedure(DbCommand command);

        Task<IList<TSprocEntity>> ExecuteStoredProcedureAsync(DbCommand command);
    }
}