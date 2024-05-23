﻿namespace StudentManagement.Data.Activities.StudentActivity
{
    public interface IStudentActivity
    {
        void Add(StudentDto student);
        void Update(StudentDto student);
        void Delete(Guid nId);
        StudentDto[] ViewAll();

    }
}
