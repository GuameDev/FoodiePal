using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;

namespace FoodiePal.Client.Services
{
    public class AuthService : IAuthService
    {

        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthService(HttpClient http, AuthenticationStateProvider authStateProvider)
        {
            _http = http;
            _authStateProvider = authStateProvider;
        }
        public async Task<ServiceResponse<UserLoginResponse>> LoginAsync(UserLoginRequest request)
        {
            var result = await _http.PostAsJsonAsync("api/Auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<UserLoginResponse>>();
        }

        public async Task<ServiceResponse<UserRegisterResponse>> RegisterAsync(UserRegisterRequest request)
        {
            var result = await _http.PostAsJsonAsync("api/Auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<UserRegisterResponse>>();
        }
        public async Task<bool> IsUserAuthenticated()
        {
            return (await _authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }
    }
}
