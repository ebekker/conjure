using System.Collections.Generic;
using AntBlazorUI.FullSample.Models;
using Microsoft.AspNetCore.Components;

namespace AntBlazorUI.FullSample.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}