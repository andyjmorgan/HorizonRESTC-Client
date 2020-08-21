# VMware.Horizon.RESTAPI.Api.AuthApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginUser**](AuthApi.md#loginuser) | **POST** /login | Logs in a user. Returns access token and refresh token.
[**LogoutUser**](AuthApi.md#logoutuser) | **POST** /logout | Logs out a user.
[**RefreshAccessToken**](AuthApi.md#refreshaccesstoken) | **POST** /refresh | Refreshes access token from refresh token.


<a name="loginuser"></a>
# **LoginUser**
> AuthTokens LoginUser (AuthLogin body)

Logs in a user. Returns access token and refresh token.

Note: UPN(e.g. testadmin@example.com) based login is not supported.<br/> Only Administrators on Root access group are allowed to login.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class LoginUserExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var body = new AuthLogin(); // AuthLogin | Login credentials needed for Authentication

            try
            {
                // Logs in a user. Returns access token and refresh token.
                AuthTokens result = apiInstance.LoginUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.LoginUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthLogin**](AuthLogin.md)| Login credentials needed for Authentication | 

### Return type

[**AuthTokens**](AuthTokens.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoutuser"></a>
# **LogoutUser**
> void LogoutUser (RefreshToken body)

Logs out a user.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class LogoutUserExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var body = new RefreshToken(); // RefreshToken | Refresh token needed for Logout

            try
            {
                // Logs out a user.
                apiInstance.LogoutUser(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.LogoutUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefreshToken**](RefreshToken.md)| Refresh token needed for Logout | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshaccesstoken"></a>
# **RefreshAccessToken**
> AccessToken RefreshAccessToken (RefreshToken body)

Refreshes access token from refresh token.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RefreshAccessTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var body = new RefreshToken(); // RefreshToken | Refresh token needed to generate new Access Token

            try
            {
                // Refreshes access token from refresh token.
                AccessToken result = apiInstance.RefreshAccessToken(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.RefreshAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefreshToken**](RefreshToken.md)| Refresh token needed to generate new Access Token | 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

