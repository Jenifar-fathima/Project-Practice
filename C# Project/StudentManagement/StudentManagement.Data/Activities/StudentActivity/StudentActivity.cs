using StudentManagement.Data.Activities.GenericActivity;

namespace StudentManagement.Data.Activities.StudentActivity
{
    public class StudentActivity : GenericActivity<StudentDto>, IStudentActivity
    {
        public StudentActivity() : base(DBContext.Students)
        {
        }
    }
}
