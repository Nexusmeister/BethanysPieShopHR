using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Server.Pages;

public sealed partial class EmployeeOverview : EmployeeOverviewBase
{
    private Employee? _selectedEmployee;

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}