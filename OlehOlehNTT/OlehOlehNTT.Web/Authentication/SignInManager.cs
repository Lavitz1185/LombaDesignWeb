using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;
using System.Security.Claims;

namespace OlehOlehNTT.Web.Authentication;

public class SignInManager
{
    private readonly IRepositoriAppUser _repositoriAppUser;
    private readonly ProtectedSessionStorage _protectedSessionStorage;
    private ClaimsPrincipal? _currentUser;

    public SignInManager(IRepositoriAppUser repositoriAppUser, ProtectedSessionStorage protectedSessionStorage)
    {
        _repositoriAppUser = repositoriAppUser;
        _protectedSessionStorage = protectedSessionStorage;
    }

    public Action<ClaimsPrincipal>? UserChanged;

    public async Task<Result> SignIn(string email, string password)
    {
        var user = await _repositoriAppUser.Get(email);

        if (user is null)
            return new Error("SignIn.EmailNotFound", $"Akun dengan email : {email} tidak ditemukan!");

        var passwordHasher = new PasswordHasher<AppUser>();

        if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password) == PasswordVerificationResult.Failed)
            return new Error("SigIn.PasswordVerificationFailed", "Password salah!");

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, email),
            new(ClaimTypes.Email, email),
            new(ClaimTypes.Role, "user")
        };
        var identity = new ClaimsIdentity(claims, CustomAuthentication.CustomAuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);
        var userSession = new UserSession { Name = email, Email = email, Role = "user" };

        await _protectedSessionStorage.SetAsync(CustomAuthentication.SessionKey, userSession);

        UserChanged?.Invoke(principal);
        return Result.Success();
    }

    public async Task<Result> SignOutAsync()
    {
        await _protectedSessionStorage.DeleteAsync(CustomAuthentication.SessionKey);
        UserChanged?.Invoke(new());
        return Result.Success();
    }
}
