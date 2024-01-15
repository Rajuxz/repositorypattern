public interface IStudentRepository:IRepository<Student>{
            void Update(Student model);
            void Save();
    }