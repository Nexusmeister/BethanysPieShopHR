using System;

namespace BethanysPieShopHRM.Server.Components.Widgets;

public sealed partial class InboxWidget
{
    public int MessageCount { get; set; }

    protected override void OnInitialized()
    {
        MessageCount = new Random().Next(0, 10);
    }
}