namespace StudentManagement.Data.Activities.StaffActivity;

public interface IStaffActivity
{
    void Add(StaffDto staff);
    void Update(StaffDto staff);
    void Delete(Guid nId);
    StaffDto[] ViewAll();
}
