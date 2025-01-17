﻿using SyncfusionComponentsDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SyncfusionComponentsDemo.Permissions
{
    public class SyncfusionComponentsDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SyncfusionComponentsDemoPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(SyncfusionComponentsDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SyncfusionComponentsDemoResource>(name);
        }
    }
}
