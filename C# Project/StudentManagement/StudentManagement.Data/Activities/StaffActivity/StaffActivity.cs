using StudentManagement.Data.Activities.GenericActivity;

namespace StudentManagement.Data.Activities.StaffActivity;

public class StaffActivity : GenericActivity<StaffDto>, IStaffActivity
{
    public StaffActivity() : base(DBContext.Staffs)
    {
    }

    //bool IStaffActivity.StaffLogin(StaffDto staffEmail, StaffDto staffPassword)
    //{
    //    for (int i = 0; i < _count; i++)
    //    {
    //        if (_lstDetails[i].StaffEmail == staffEmail.StaffEmail && _lstDetails[i].StaffPassword == staffPassword.StaffPassword)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //void IStaffActivity.StaffSignUp(StaffDto staff)
    //{
    //    Add(staff);
    //}
}
