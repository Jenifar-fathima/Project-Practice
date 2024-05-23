using StudentManagement.Common;

namespace StudentManagement;
public class StaffDto : BaseRequestDto
{
    public string StaffName { get; set; } = string.Empty;

    public string StaffEmail { get; set; } = string.Empty;

    public string StaffPhoneNumber { get; set; } = string.Empty;

    public int StaffAge { get; set; } = 0;

    public string StaffPassword { get; set; } = string.Empty;
}
