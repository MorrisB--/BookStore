using BookStore.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStore.Startup))]
namespace BookStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers() {

            System.Diagnostics.Debug.WriteLine("Entered");
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    

                // first we create Admin rool   
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
            user.UserName = "shanu";

            user.Email = "testFinal@test.com";

                string userPWD = "ABc-123";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                    var result1 = UserManager.AddToRole(user.Id, "Administrator");

            
        }
    }
}
