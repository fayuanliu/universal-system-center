using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSystemCenter.Auth
{
    public class ProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            try
            {
                var claims = context.Subject.Claims.ToList();
                context.IssuedClaims = claims.ToList();
                await Task.Delay(0);
            }
            catch (Exception ex)
            {

            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            context.IsActive = true;
            await Task.Delay(0);
        }
    }
}
