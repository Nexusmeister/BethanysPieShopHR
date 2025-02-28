using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Server.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Components.Widgets;

public sealed partial class EmployeeCountWidget
{
    [Inject] public IEmployeeDataService EmployeeDataService { get; set; }
    public int EmployeeCounter { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var employees = await EmployeeDataService.GetAllEmployees();
        EmployeeCounter = employees.Count();
    }
}