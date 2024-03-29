﻿using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Easyman.Authorization
{
    public class EasymanAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var pages = context.GetPermissionOrNull(PermissionNames.Pages);
            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            var users = pages.CreateChildPermission(PermissionNames.Pages_Users, L("Users"));

            //Host permissions
            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
           // var testP = pages.CreateChildPermission("Pages.PremissionTest", new LocalizableString("Pages.PremissionTest", EasymanConsts.LocalizationSourceName));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, EasymanConsts.LocalizationSourceName);
        }
    }
}
