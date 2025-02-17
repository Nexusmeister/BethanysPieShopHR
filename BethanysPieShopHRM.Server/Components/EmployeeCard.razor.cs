using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Components;

public sealed partial class EmployeeCard
{
    [Parameter] public string Name { get; set; } = "N/A";
    [Parameter] public Employee Employee { get; set; }
    [Parameter] public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
}