using JobOrderAndTaskMonitoringSystem.Repositories.AppDbContext;

namespace JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository {
    public class GenericRepository<T>:IGenericRepository<T> where T : class {

        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbcontext) {
            _dbContext = dbcontext;
        }

        public void Add(T entity) {
            _dbContext.Add(entity);
        }

        public void Delete(int id) {
            T entity = _dbContext.Set<T>().Find(id);
            entity.Visible = false;
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll() {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id) {
            return _dbContext.Set<T>().Find(id);
        }

        public void Update(T entity) {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
