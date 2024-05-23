using StudentManagement.Common;

namespace StudentManagement.Data.Activities.GenericActivity
{
    internal interface IGenericRepository<T> where T : BaseRequestDto
    {
        void Add(T detail);
        void Update(T detail);
        void Delete(Guid nId);
        T[] ViewAll();
    }
}
