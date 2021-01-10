/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApi
    {
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">Created user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateUserWithHttpInfoAsync(User user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">Created user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> CreateUserAsync(User user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateUsersWithArrayInputWithHttpInfoAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> CreateUsersWithArrayInputAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreateUsersWithListInputWithHttpInfoAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Creates list of users with given input array
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> CreateUsersWithListInputAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserWithHttpInfoAsync(string username, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> DeleteUserAsync(string username, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserByNameWithHttpInfoAsync(string username, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<User> GetUserByNameAsync(string username, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User?)</returns>
        System.Threading.Tasks.Task<User?> GetUserByNameOrDefaultAsync(string username, System.Threading.CancellationToken? cancellationToken = null);
        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> LoginUserWithHttpInfoAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<string> LoginUserAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Logs user into the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string?)</returns>
        System.Threading.Tasks.Task<string?> LoginUserOrDefaultAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null);
        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LogoutUserWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Logs out current logged in user session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> LogoutUserAsync(System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="user">Updated user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateUserWithHttpInfoAsync(string username, User user, System.Threading.CancellationToken? cancellationToken = null);
        
        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>
        /// This can only be done by the logged in user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="user">Updated user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<Object> UpdateUserAsync(string username, User user, System.Threading.CancellationToken? cancellationToken = null);
        
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApi
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserApi(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Returns the token to be used in the api query
        /// </summary>
        public Func<System.Threading.Tasks.ValueTask<string>>? GetTokenAsync { get; set; }  


        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="user">Created user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateCreateUserRequestAsync(User user, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Create user This can only be done by the logged in user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">Created user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> CreateUserWithHttpInfoAsync(User user, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user)); 

            await ValidateCreateUserRequestAsync(user, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user";


            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            // todo localVarRequestOptions.Data = user;


            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string[] contentTypes = new string[] {
                "application/json"
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateCreateUsersWithArrayInputRequestAsync(List<User> user, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Creates list of users with given input array 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> CreateUsersWithArrayInputWithHttpInfoAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user)); 

            await ValidateCreateUsersWithArrayInputRequestAsync(user, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/createWithArray";


            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            // todo localVarRequestOptions.Data = user;


            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string[] contentTypes = new string[] {
                "application/json"
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateCreateUsersWithListInputRequestAsync(List<User> user, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Creates list of users with given input array 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="user">List of user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> CreateUsersWithListInputWithHttpInfoAsync(List<User> user, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user)); 

            await ValidateCreateUsersWithListInputRequestAsync(user, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/createWithList";


            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            // todo localVarRequestOptions.Data = user;


            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string[] contentTypes = new string[] {
                "application/json"
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="username">The name that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateDeleteUserRequestAsync(string username, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Delete user This can only be done by the logged in user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> DeleteUserWithHttpInfoAsync(string username, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username)); 

            await ValidateDeleteUserRequestAsync(username, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/{username}";
            path = path.Replace("{username}", Uri.EscapeDataString(username));



            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");






            string[] contentTypes = new string[] {
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateGetUserByNameRequestAsync(string username, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        

        /// <summary>
        /// Get user by user name 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserByNameAsync(string username, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<User> result = await GetUserByNameWithHttpInfoAsync(username, cancellationToken).ConfigureAwait(false);
            return result.Data ?? throw new NullReferenceException();
        }

        /// <summary>
        /// Get user by user name 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User?> GetUserByNameOrDefaultAsync(string username, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<User> result = await GetUserByNameWithHttpInfoAsync(username, cancellationToken).ConfigureAwait(false);
            
            return result.IsSuccessStatusCode
                ? result.Data
                : null;
        } 

        /// <summary>
        /// Get user by user name 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<User>> GetUserByNameWithHttpInfoAsync(string username, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username)); 

            await ValidateGetUserByNameRequestAsync(username, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/{username}";
            path = path.Replace("{username}", Uri.EscapeDataString(username));



            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");






            string[] contentTypes = new string[] {
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<User> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateLoginUserRequestAsync(string username, string password, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        

        /// <summary>
        /// Logs user into the system 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> LoginUserAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<string> result = await LoginUserWithHttpInfoAsync(username, password, cancellationToken).ConfigureAwait(false);
            return result.Data ?? throw new NullReferenceException();
        }

        /// <summary>
        /// Logs user into the system 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string?> LoginUserOrDefaultAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null)
        {
            Org.OpenAPITools.Client.ApiResponse<string> result = await LoginUserWithHttpInfoAsync(username, password, cancellationToken).ConfigureAwait(false);
            
            return result.IsSuccessStatusCode
                ? result.Data
                : null;
        } 

        /// <summary>
        /// Logs user into the system 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The user name for login</param>
        /// <param name="password">The password for login in clear text</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<string>> LoginUserWithHttpInfoAsync(string username, string password, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username)); 
            if (password == null)
                throw new ArgumentNullException(nameof(password)); 

            await ValidateLoginUserRequestAsync(username, password, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/login";


            path = $"{path}?";
            
            path = $"{path}username={Uri.EscapeDataString(username.ToString()!)&";

            path = $"{path}password={Uri.EscapeDataString(password.ToString()!)&";


            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");






            string[] contentTypes = new string[] {
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);

            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<string> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateLogoutUserRequestAsync(System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Logs out current logged in user session 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> LogoutUserWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {

            await ValidateLogoutUserRequestAsync(cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/logout";


            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");






            string[] contentTypes = new string[] {
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }

        /// <summary>
        /// Validate the input before sending the request
        /// </summary>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="user">Updated user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        protected virtual System.Threading.Tasks.ValueTask ValidateUpdateUserRequestAsync(string username, User user, System.Threading.CancellationToken? cancellationToken)
            => new System.Threading.Tasks.ValueTask();        



        /// <summary>
        /// Updated user This can only be done by the logged in user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">name that need to be deleted</param>
        /// <param name="user">Updated user object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> UpdateUserWithHttpInfoAsync(string username, User user, System.Threading.CancellationToken? cancellationToken = null)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username)); 
            if (user == null)
                throw new ArgumentNullException(nameof(user)); 

            await ValidateUpdateUserRequestAsync(username, user, cancellationToken).ConfigureAwait(false);

            using System.Net.Http.HttpRequestMessage request = new System.Net.Http.HttpRequestMessage();

            string path = "/user/{username}";
            path = path.Replace("{username}", Uri.EscapeDataString(username));



            path = $"{path}?";
            

            if (path.EndsWith("&"))
                path = path[..^1];

            if (path.EndsWith("?"))
                path = path[..^1];

            request.RequestUri = new Uri($"{_httpClient.BaseAddress}{path}");



            // todo localVarRequestOptions.Data = user;


            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string[] contentTypes = new string[] {
                "application/json"
            };

            if (request.Content != null && contentTypes.Length > 0)
                request.Content.Headers.Add("CONTENT-TYPE", contentTypes);


            using System.Net.Http.HttpResponseMessage responseMessage = await _httpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

            string responseContent = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

            ApiResponse<Object> apiResponse = new(responseMessage, responseContent);

            if (apiResponse.IsSuccessStatusCode)
                apiResponse.Data = Newtonsoft.Json.JsonConvert.DeserializeObject<Object>(apiResponse.RawData, CocApi.Client.ClientUtils.JsonSerializerSettings);

            return apiResponse;
        }
    }
}