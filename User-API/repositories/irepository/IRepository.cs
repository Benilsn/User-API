using System.Collections.Generic;

namespace User_API.repositories
{
    public interface IRepository<T>
    {


        public T GetById(int id);

        public List<T> GetAll();
        public void Insert(T t);

        public void DeleteById(int id);

        public void Update(int id, T t);
       
    }
}
