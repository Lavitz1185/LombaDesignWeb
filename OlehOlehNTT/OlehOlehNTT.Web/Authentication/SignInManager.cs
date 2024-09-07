using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using OlehOlehNTT.Domain.Entities;
using OlehOlehNTT.Domain.Repositories;
using OlehOlehNTT.Domain.Shared;
using System.Security.Claims;

namespace OlehOlehNTT.Web.Authentication;

public class SignInManager
{
    private const string SessionKey = "OlehOlehNTT.AuthKey";
    private const string CustomAuthenticationScheme = "CustomAuthenticationScheme";

    private readonly IRepositoriAppUser _repositoriAppUser;
    private ClaimsPrincipal? _currentUser;

    public SignInManager(IRepositoriAppUser repositoriAppUser)
    {
        _repositoriAppUser = repositoriAppUser;
    }

    public Action<ClaimsPrincipal>? UserChanged;

    public ClaimsPrincipal CurrentUser 
    { 
        get => _currentUser ?? new(); 
        set 
        {
            _currentUser = value;
            
            UserChanged?.Invoke(_currentUser);
        }
    }

    public async Task<Result> SignIn(string email, string password)
    {
        var user = await _repositoriAppUser.Get(email);

        if (user is null)
            return new Error("SignIn.EmailNotFound", $"Akun dengan email : {email} tidak ditemukan!");

        var passwordHasher = new PasswordHasher<AppUser>();

        if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password) == PasswordVerificationResult.Failed)
            return new Error("SigIn.PasswordVerificationFailed", "Password salah!");

        CurrentUser = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
        {
            new(ClaimTypes.Name, email),
            new(ClaimTypes.Email, email),
            new(ClaimTypes.Role, "user")
        }, CustomAuthenticationScheme));

        return Result.Success();
    }

    public Result SignOut()
    {
        CurrentUser = new();

        return Result.Success();
    }
}
