using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly foxCodeContext _context;
    public GenericRepo(foxCodeContext context)
    {
        _context=context;
    }
    public IEnumerable<T> GetAll()
    {
       return _context.Set<T>();
    }
    public T? GetById(Guid id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Add(T item)
    {
        _context.Set<T>().Add(item);
    }
    public void Update(T item)
    {
        //Empty
    }
    public void Delete(T item)
    {
        _context.Set<T>().Remove(item);
    }
}
