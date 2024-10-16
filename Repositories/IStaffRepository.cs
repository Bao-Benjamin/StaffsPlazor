using BlazorStaff.Models;
// namespace BlazorStaff.Repositories;

    

public interface IStaffRepository {
    Task<IEnumerable<Staff>> GetAllStaffs();
    Task<Staff> GetStaffById(int id);
}
