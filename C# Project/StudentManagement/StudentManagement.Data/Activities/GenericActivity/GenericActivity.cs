using StudentManagement.Common;

namespace StudentManagement.Data.Activities.GenericActivity
{
    public class GenericActivity<T> : IGenericRepository<T> where T : BaseRequestDto
    {
        private const int DEFAULT_CAPACITY = 5;

        #region Fields
        private int _count = 0;
        private T[] _lstDetails;
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

        public void Delete(Guid nId)
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

        public T? FindById(Guid nId)
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
            return _lstDetails;
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
