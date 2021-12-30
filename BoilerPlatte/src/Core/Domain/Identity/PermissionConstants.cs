using System.ComponentModel;

namespace BoilerPlatte.Domain.Constants;

public class PermissionConstants
{
    [DisplayName("Identity")]
    [Description("Identity Permissions")]
    public static class Identity
    {
        public const string Register = "Permissions.Identity.Register";
    }

    [DisplayName("Roles")]
    [Description("Roles Permissions")]
    public static class Roles
    {
        public const string View = "Permissions.Roles.View";
        public const string ListAll = "Permissions.Roles.ViewAll";
        public const string Register = "Permissions.Roles.Register";
        public const string Update = "Permissions.Roles.Update";
        public const string Remove = "Permissions.Roles.Remove";
    }

    [DisplayName("Products")]
    [Description("Products Permissions")]
    public static class Products
    {
        public const string View = "Permissions.Products.View";
        public const string Search = "Permissions.Products.Search";
        public const string Register = "Permissions.Products.Register";
        public const string Update = "Permissions.Products.Update";
        public const string Remove = "Permissions.Products.Remove";
    }

    [DisplayName("CodeDetails")]
    [Description("CodeDetails Permissions")]
    public static class CodeDetails
    {
        public const string View = "Permissions.CodeDetails.View";
        public const string Search = "Permissions.CodeDetails.Search";
        public const string Register = "Permissions.CodeDetails.Register";
        public const string Update = "Permissions.CodeDetails.Update";
        public const string Remove = "Permissions.CodeDetails.Remove";
    }

    [DisplayName("Code")]
    [Description("Code Permissions")]
    public static class Code
    {
        public const string View = "Permissions.Code.View";
        public const string Search = "Permissions.Code.Search";
        public const string Register = "Permissions.Code.Register";
        public const string Update = "Permissions.Code.Update";
        public const string Remove = "Permissions.Code.Remove";
    }

    [DisplayName("Persons")]
    [Description("Persons Permissions")]
    public static class Persons
    {
        public const string View = "Permissions.Products.View";
        public const string Search = "Permissions.Products.Search";
        public const string Register = "Permissions.Products.Register";
        public const string Update = "Permissions.Products.Update";
        public const string Remove = "Permissions.Products.Remove";
    }

    [DisplayName("Brands")]
    [Description("Brands Permissions")]
    public static class Brands
    {
        public const string View = "Permissions.Brands.View";
        public const string Search = "Permissions.Brands.Search";
        public const string Register = "Permissions.Brands.Register";
        public const string Update = "Permissions.Brands.Update";
        public const string Remove = "Permissions.Brands.Remove";
        public const string Generate = "Permissions.Brands.Generate";
        public const string Clean = "Permissions.Brands.Clean";
    }

    [DisplayName("Role Claims")]
    [Description("Role Claims Permissions")]
    public static class RoleClaims
    {
        public const string View = "Permissions.RoleClaims.View";
        public const string Create = "Permissions.RoleClaims.Create";
        public const string Edit = "Permissions.RoleClaims.Edit";
        public const string Delete = "Permissions.RoleClaims.Delete";
        public const string Search = "Permissions.RoleClaims.Search";
    }
}
