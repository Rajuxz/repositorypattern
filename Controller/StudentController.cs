public class StudentController : controller{
    public IStudentRepository _studentRepo;
    public StudentController(IStudentRepository studentRepo){
        _studentRepo = studentRepo;
    }
    //Now, we use the object or StudentRepository instead of our DbContexts'.
      public IActionResult StudentView()
     {
        try
        {
            List<Student> student = _studentRepo.GetAll().ToList();
            return View(student);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception .. -> {ex.ToString()}");
            return View(ex);
        }
    }
}