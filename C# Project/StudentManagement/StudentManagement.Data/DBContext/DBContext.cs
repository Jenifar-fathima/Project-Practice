namespace StudentManagement.Data
{
    internal static class DBContext
    {
        private const int BOUND = 5;

        internal static StudentDto[] Students { get; set; } = new StudentDto[BOUND];
        internal static StaffDto[] Staffs { get; set; } = new StaffDto[BOUND];
    }
}
