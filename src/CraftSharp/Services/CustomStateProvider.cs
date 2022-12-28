﻿using CraftSharp.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CraftSharp.Services
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService _authService;
        private CurrentUser _currentUser;

        public CustomStateProvider(IAuthService authService)
        {
            this._authService = authService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = GetCurrentUser();
                if (userInfo.IsAuthenticated)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, _currentUser.UserName) }.Concat(_currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex);
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        public async Task Login(ConnexionModel loginParameters)
        {
            _authService.Login(loginParameters);

            // No error - Login the user
            var user = _authService.GetUser(loginParameters.UserName);
            _currentUser = user;

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task Logout()
        {
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task Register(InscriptionModel registerParameters)
        {
            _authService.Register(registerParameters);

            // No error - Login the user
            var user = _authService.GetUser(registerParameters.UserName);
            _currentUser = user;

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public CurrentUser GetCurrentUser()
        {
            if (_currentUser != null && _currentUser.IsAuthenticated)
            {
                return _currentUser;
            }

            return new CurrentUser();
        }
    }
}
