using BlazorStaff.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorStaff.Components.Pages;
public class StaffListBase: ComponentBase
{
    [Inject]
    public IStaffRepository staffRepository { get; set; }
    public IEnumerable<Staff> staffs { get; set; }

    protected override async Task OnInitializedAsync()
    {
        staffs = await staffRepository.GetAllStaffs();
    }
}