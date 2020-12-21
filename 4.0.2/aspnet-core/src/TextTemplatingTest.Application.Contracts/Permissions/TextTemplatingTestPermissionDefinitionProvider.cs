using TextTemplatingTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TextTemplatingTest.Permissions
{
    public class TextTemplatingTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TextTemplatingTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TextTemplatingTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TextTemplatingTestResource>(name);
        }
    }
}
