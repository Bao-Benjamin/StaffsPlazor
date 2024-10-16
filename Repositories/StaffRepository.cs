using BlazorStaff.Models;
// namespace BlazorStaff.Repositories;
public class StaffRepository : IStaffRepository {
    public StaffsContext staffsContext;
    public StaffRepository(StaffsContext staffsContext){
        this.staffsContext=staffsContext;
    }
    public async Task<Staff> GetStaffById(int id){
        return (from staff in staffsContext.Staff
                where staff.EmployeeId==id
                select staff).First();
            
    }
    public async Task<Staff> DeleteStaffById(int id){
       var st =(from staff in staffsContext.Staff
                where staff.EmployeeId==id
                select staff).First();
        if(st != null ){
            
            staffsContext.Staff.Remove(st);
            await staffsContext.SaveChangesAsync();
        }

        return st;
            
    }
    public async Task<IEnumerable<Staff>> GetAllStaffs(){
        return staffsContext.Staff;
    }
}
