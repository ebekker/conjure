using Conjure.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using System.Security.Claims;
using System.Text.Json;

namespace Conjure.BlazorAuth
{
    public class SignInClient : ISignInClient
    {
        public const string DefaultControllerPathPrefix = "api/identity";

        private const string DefaultRequestMethod = "POST";
        private static readonly IReadOnlyDictionary<string, string> NoRequestHeaders =
            new Dictionary<string, string>();
        private static readonly IReadOnlyDictionary<string, string> DefaultRequestHeaders =
            new Dictionary<string, string>
            {
                ["Content-type"] = "application/json",
            };

        private ILogger _logger;
        private SignInConfig _config;
        private NavigationManager _nav;
        private ConjureInterop _ci;
        private IJSRuntime _js;
        private AuthenticationStateProvider _authStateProvider;
        private SignInManager<IdentityUser> _signInManager;

        public SignInClient(ILogger<SignInClient> logger,
            IOptions<SignInConfig> config,
            NavigationManager nav,
            ConjureInterop ci,
            IJSRuntime js,
            AuthenticationStateProvider authStateProvider,
            SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _config = config.Value;
            _nav = nav;
            _ci = ci;
            _js = js;
            _authStateProvider = authStateProvider;
            _signInManager = signInManager;
        }

        public SignInConfig Config => _config;

        public ValueTask<ClaimsPrincipal> CreateClaimsPrincipal() =>
            ValueTask.FromResult(new ClaimsPrincipal(new ClaimsIdentity()));

        public async Task<ClaimsPrincipal> CreateClaimsPrincipal(string username)
        {
            var user = new IdentityUser(username);
            return await _signInManager.CreateUserPrincipalAsync(user);
        }

        public async Task<bool> SignOutAsync()
        {
            var pathPrefix = DefaultControllerPathPrefix;
            var actionUrl = _nav.ToAbsoluteUri($"{pathPrefix}/signout").ToString();
            await _ci.ConLog("Fetching: {0}", actionUrl);

            var resp = await Fetch(actionUrl);
            await _ci.ConLog($"OK? {resp.Ok} / {resp.Status} / {resp.StatusText}");

            var state = await _authStateProvider.GetAuthenticationStateAsync();

            return resp.Ok;
        }

        public async Task<SignInResult?> SignInAsync(string username, string password, bool rememberMe = false)
        {
            var pathPrefix = DefaultControllerPathPrefix;
            var actionUrl = _nav.ToAbsoluteUri($"{pathPrefix}/signin").ToString();
            await _ci.ConLog("Fetching: " + actionUrl);

            var resp = await FetchJson<Models.SignInInput, Models.SignInOutput>(actionUrl, new Models.SignInInput
            {
                UserName = username,
                Password = password,
                RememberMe = rememberMe,
            });

            await _ci.ConLog($"OK? {resp.Ok} / {resp.Status} / {resp.StatusText}");
            if (!resp.Ok)
                return null;

            await _ci.ConLog("Got response: " + JsonSerializer.Serialize(resp.Value));
            return resp.Value?.ToResult();
        }

        protected async Task<FetchResponse> Fetch(string url,
            string method = DefaultRequestMethod,
            IReadOnlyDictionary<string, string>? headers = null)
        {
            if (headers == null)
                headers = DefaultRequestHeaders;

            await using var resp = await _js.InvokeAsync<IJSObjectReference>("window.fetch", url, new
            {
                method,
                headers,
            });

            var ok = await _ci.GetProperty<bool>(resp, "ok");

            return new()
            {
                Ok = ok,
                Status = await _ci.GetProperty<int>(resp, "status"),
                StatusText = await _ci.GetProperty<string>(resp, "statusText"),
            };
        }

        protected async Task<FetchResponse<TResponse>> FetchJson<TResponse>(string url,
            string method = DefaultRequestMethod,
            IReadOnlyDictionary<string, string>? headers = null)
        {
            if (headers == null)
                headers = DefaultRequestHeaders;

            await using var resp = await _js.InvokeAsync<IJSObjectReference>("window.fetch", url, new
            {
                method,
                headers,
            });

            var ok = await _ci.GetProperty<bool>(resp, "ok");
            var val = ok
                ? await resp.InvokeAsync<TResponse>("json")
                : default;

            return new()
            {
                Ok = ok,
                Status = await _ci.GetProperty<int>(resp, "status"),
                StatusText = await _ci.GetProperty<string>(resp, "statusText"),
                Value = val,
            };
        }

        protected async Task<FetchResponse<TResponse>> FetchJson<TRequest, TResponse>(string url, TRequest body,
            string method = DefaultRequestMethod,
            IReadOnlyDictionary<string, string>? headers = null)
        {
            if (headers == null)
                headers = DefaultRequestHeaders;

            await using var resp = await _js.InvokeAsync<IJSObjectReference>("window.fetch", url, new
            {
                method,
                headers,
                body = JsonSerializer.Serialize<TRequest>(body),
            });

            return new()
            {
                Ok = await _ci.GetProperty<bool>(resp, "ok"),
                Status = await _ci.GetProperty<int>(resp, "status"),
                StatusText = await _ci.GetProperty<string>(resp, "statusText"),

                // Calling json() will validate the response as JSON before marshalling to CLR type            
                Value = await resp.InvokeAsync<TResponse>("json"),
            };
        }

        protected class FetchResponse
        {
            public bool Ok { get; init; }

            public int Status { get; init; }

            public string? StatusText { get; init; }
        }

        protected class FetchResponse<TResponse> : FetchResponse
        {
            public TResponse? Value { get; init; }
        }
    }
}
