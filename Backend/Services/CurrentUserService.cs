using CRM.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Backend.Services
{
    public class CurrentUserService
    {
        private readonly AuthenticationStateProvider _authProvider;
        private readonly IDbContextFactory<CrmDbContext> _dbFactory;

        public CrmUser? CurrentUser { get; private set; }

        public CurrentUserService(AuthenticationStateProvider authProvider, IDbContextFactory<CrmDbContext> factory)
        {
            _authProvider = authProvider;
            _dbFactory = factory;

        }

        public async Task LoadCurrentUserAsync()
        {
            var authState = await _authProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if(user.Identity?.IsAuthenticated == true)
            {
                var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                using var context = _dbFactory.CreateDbContext();

                CurrentUser = await context.Users
                    .Include(u => u.Team)
                    .Include(u => u.Adresse)
                    .FirstOrDefaultAsync(u => u.Id == userId);
            }
        }
    }
}