using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Server.Components;

public sealed partial class ProfilePicture
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}