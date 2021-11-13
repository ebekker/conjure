using System.Threading.Tasks;
using AntBlazorUI.FullSample.Models;
using AntBlazorUI.FullSample.Services;
using Microsoft.AspNetCore.Components;

namespace AntBlazorUI.FullSample.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}