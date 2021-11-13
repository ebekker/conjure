using ConjureApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjure.NScribe.PermissionsSample.Pages
{
    [Authorize("secure1")]
    [Permit(ApplicationPermissions.MyPermission2, ApplicationPermissions.MyPermission3)]
    [Permit(ApplicationPermissions.MyPermission1)]
    public partial class SecurityAdmin
    {
        [Inject]
        private IAuthorizationService AuthorizationService { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

    }
}
