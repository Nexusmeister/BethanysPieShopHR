using System.Data;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Components;

public sealed partial class EmployeeCard
{
    [Parameter] public string Name { get; set; } = "N/A";
    [Parameter] public Employee Employee { get; set; }
    [Parameter] public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        if (string.IsNullOrEmpty(Employee.LastName))
        {
            throw new DataException("Last name can't be empty");
        }
    }

    public void NavigateToDetails(Employee employee)
    {
        NavigationManager.NavigateTo($"/employeedetail/{employee.EmployeeId}");
    }
}