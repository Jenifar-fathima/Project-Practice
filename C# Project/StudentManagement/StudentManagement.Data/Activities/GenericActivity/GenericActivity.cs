using StudentManagement.Common;
using System.Security.Cryptography;

namespace StudentManagement.Data.Activities.GenericActivity
{
    public class GenericActivity<T> : IGenericRepository<T> where T : BaseRequestDto
    {
        private const int DEFAULT_CAPACITY = 5;

        #region Fields
        protected int _count = 0;
        protected T[] _lstDetails;
        #endregion

        public GenericActivity(T[] lstDetails = default!)
        {
            _lstDetails = lstDetails ?? new T[DEFAULT_CAPACITY];
        }

        public void Add(T detail)
        {
            CheckArrayCapacity();
            _lstDetails[_count++] = detail;
        }

        public void Update(T detail)
        {
            Delete(detail.Id);
            Add(detail);

        }

        public void Delete(int nId)
        {
            T? memberToDelete = FindById(nId);
            if (memberToDelete != null)
            {
                int index = -1;
                for (int i = 0; i < _count; i++)
                {
                    if (_lstDetails[i] == memberToDelete)
                    {
                        index = i;
                        break;
                    }
                }
                if (index >= 0)
                {
                    for (int i = index; i < _count - 1; i++)
                    {
                        _lstDetails[i] = _lstDetails[i + 1];
                    }
                    _lstDetails[--_count] = default!;
                }
            }
        }

        public T? FindById(int nId)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_lstDetails[i].Id == nId)
                {
                    return _lstDetails[i];
                }
            }

            return default;
        }

        public T[] ViewAll()
        {
            T[] result = new T[_count];
            for (int i = 0; i < _count; i++)
            {
                result[i] = _lstDetails[i];
            }
            return result;
        }
        #region Private Methods
        private void CheckArrayCapacity()
        {
            if (_count == _lstDetails.Length)
            {
                T[] newArray = new T[_lstDetails.Length * 2];
                for (int i = 0; i < _count; i++)
                {
                    newArray[i] = _lstDetails[i];
                }
                _lstDetails = newArray;
            }
        }
        #endregion
    }
}
