using StudentManagement.Common;

namespace StudentManagement;

public class StudentDto : BaseRequestDto
{
    public string StudentName{ get; set;} = string.Empty;

    public string StudentEmail { get; set; } = string.Empty;

    public string StudentPhoneNumber { get; set; } = string.Empty; 

    public int StudentAge { get; set;} = 0;

}