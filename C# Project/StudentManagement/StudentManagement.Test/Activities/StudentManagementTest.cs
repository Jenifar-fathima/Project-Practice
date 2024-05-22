﻿using StudentManagement.Data.Activities.StaffActivity;
using StudentManagement.Data.Activities.StudentActivity;

namespace StudentManagement.Test.Activities
{
    [TestClass] 
    public class StudentManagementTest
    {
        [TestMethod]
        public void Test_Staff()
        {
            IStaffActivity activity = new StaffActivity();

            StaffDto staff = new StaffDto
            {
                Id = 1,
                StaffEmail = "staff1@gmail.com",
                StaffName = "Staff1",
                StaffAge = 1,
                StaffPhoneNumber = "12345",
                StaffPassword = "Password"
            };

            activity.Add(staff);


            IStudentActivity activity2 = new StudentActivity();

            StudentDto studentDto = new StudentDto { Id = 2, StudentName = "Jenifar",StudentEmail = "jenifar@gmail.com", StudentAge = 2, StudentPhoneNumber="9876543210" };

            activity2.Add(studentDto);
        }
    }
}