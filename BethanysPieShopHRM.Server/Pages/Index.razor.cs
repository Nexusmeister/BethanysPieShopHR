using System;
using System.Collections.Generic;
using BethanysPieShopHRM.Server.Components.Widgets;

namespace BethanysPieShopHRM.Server.Pages;

public sealed partial class Index
{
    public List<Type> Widgets { get; set; } =
    [
        typeof(EmployeeCountWidget),
        typeof(InboxWidget)
    ];
}