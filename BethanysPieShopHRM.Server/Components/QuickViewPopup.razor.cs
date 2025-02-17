using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Components;

public sealed partial class QuickViewPopup
{
    private Employee? _employee;
    [Parameter] public Employee? Employee { get; set; }

    protected override void OnParametersSet()
    {
        _employee = Employee;
    }

    private void Close()
    {
        _employee = null;
    }
}