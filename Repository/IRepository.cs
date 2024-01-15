 public interface IRepository<T> where T: class{

        void Add(T entity);
        T Get(Expression<Func<T, bool>> filter);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        public T FindById(int id);

        //.. We can add or remove method signatures as per our needs.

    }