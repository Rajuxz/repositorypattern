public class Repository<T>:IRepository<T> where T: class{
    private readonly StudentDbContext _dbContext;
    internal DbSet<T> database;

    public Repository(StudentDbContext dbContext)
    {
        _dbContext = dbContext;
        database = _dbContext.Set<T>();
    }

    public void Add(T entity)
    {
        database.Add(entity);
    }

    public T Get(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = database;
        query = query.Where(filter);
        return query.FirstOrDefault();
    }

    public void Remove(T entity)
    {
        database.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        database.RemoveRange(entities);
    }

    public T FindById(int id)
    {
        DbSet<T>? query = database;
        return query.Find(id);
    }
}
