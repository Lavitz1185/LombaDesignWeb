using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using OlehOlehNTT.Domain.ValueObjects;
using System.Security.Claims;

namespace OlehOlehNTT.Web.Authentication;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly ProtectedSessionStorage _sessionStorage;

    public CustomAuthenticationStateProvider(SignInManager signInManager, ProtectedSessionStorage sessionStorage)
    {
        signInManager.UserChanged += (newPrincipal) =>
        {
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(newPrincipal)));
        };
        _sessionStorage = sessionStorage;
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var userSession = await _sessionStorage.GetAsync<UserSession>(CustomAuthentication.SessionKey);
        if (userSession.Success)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, userSession.Value!.Name),
                new(ClaimTypes.Email, userSession.Value!.Email),
                new(ClaimTypes.Role, userSession.Value!.Role)
            };
            var identity = new ClaimsIdentity(claims, CustomAuthentication.CustomAuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            return new(principal);
        } 
        else
            return new(new());
    }
}
