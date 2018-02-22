using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreOnionArchitectureStarter.Core.Entities;

namespace DotNetCoreOnionArchitectureStarter.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
    }
}