using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopHRM.ComponentsLibrary.Map;
using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Pages;

public class EmployeeDetailBase : ComponentBase
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    [Inject]
    public IJobCategoryDataService? JobCategoryDataService{ get; set; }

    [Parameter]
    public int EmployeeId { get; set; }

    public List<Marker> MapMarkers { get; set; } = new List<Marker>();

    protected string JobCategory = string.Empty;
       
    public Employee? Employee { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        var employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);

        Employee = employee;

        MapMarkers =
        [
            new Marker
            {
                Description = $"{Employee.FirstName} {Employee.LastName}", ShowPopup = false, X = Employee.Longitude,
                Y = Employee.Latitude
            }
        ];

        JobCategory = (await JobCategoryDataService.GetJobCategoryById(Employee.JobCategoryId)).JobCategoryName;

        await base.OnInitializedAsync();
    }
}