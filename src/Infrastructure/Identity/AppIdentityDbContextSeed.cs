using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "eflorespalma@microsoft.com", Email = "eflorespalma@microsoft.com" };
            await userManager.CreateAsync(defaultUser, "P@ssw0rd.321");
        }
    }
}
