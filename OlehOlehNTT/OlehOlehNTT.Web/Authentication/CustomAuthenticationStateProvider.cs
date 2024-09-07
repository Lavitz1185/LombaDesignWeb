using Microsoft.AspNetCore.Components.Authorization;

namespace OlehOlehNTT.Web.Authentication;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private AuthenticationState _authenticationState;

    public CustomAuthenticationStateProvider(SignInManager signInManager)
    {
        _authenticationState = new(signInManager.CurrentUser);

        signInManager.UserChanged += (newPrincipal) => {
            _authenticationState = new(newPrincipal);
            NotifyAuthenticationStateChanged(Task.FromResult(_authenticationState));
        };
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(_authenticationState);
}
