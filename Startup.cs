using Auth_SGACTA.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auth_SGACTA.Startup))]
namespace Auth_SGACTA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {

            var context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            //role.Name = "User";
            //roleManager.Create(role);

            var role1 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
            role1.Name = "Admin";
            roleManager.Create(role1);
        }

    }
}
