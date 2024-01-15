    public class StudentRepository:Repository<Student>,IStudentRepository{
        public StudentDbContext _studentDb;
        public StudentRepository(StudentDbContext studentDb):base(studentDb){
            _studentDb = studentDb;
        }
        public void Save()
        {
            _studentDb.SaveChanges();
        }
        public void Update(Student model){
          _studentDb.Student?.Update(model);
        }
    }