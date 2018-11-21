using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "eflorespalma", Email = "edgar.flores@gestionysistemas.com" };
            await userManager.CreateAsync(defaultUser, "P@ssw0rd.321");
            var defaultUser2 = new ApplicationUser { UserName = "jgonzalestello", Email = "jgonzales.tello@gestionysistemas.com" };
            await userManager.CreateAsync(defaultUser2, "P@ssw0rd.321");
        }
    }
}
