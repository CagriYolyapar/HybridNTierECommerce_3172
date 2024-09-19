using HybridNTierECommerce.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HybridNTierECommerce.BLL.Managers.Abstracts
{
    //BU interface
    public interface IManager<T> where T: IEntity
    {

        //List Commands
        List<T> GetAll();

        List<T> GetActives();

 
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modify Commands

        string Add(T item);
        Task<string> AddAsync(T item);
        Task<string> AddRangeAsync(List<T> list);
        string AddRange(List<T> list);
        void Delete(T item);
        string DeleteRange(List<T> list);
        Task UpdateAsync(T item);
        Task UpdateRangeAsync(List<T> list);
        string Destroy(T item);
        
        //Linq Commands
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find Command

        Task<T> FindAsync(int id);
        List<T> GetLastDatas(int count);
        List<T> GetFirstDatas(int count);
    }
}
