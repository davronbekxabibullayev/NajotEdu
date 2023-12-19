# NajotEdu.Client.Api.AuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAuthLoginPost**](AuthApi.md#apiauthloginpost) | **POST** /api/Auth/Login |  |

<a id="apiauthloginpost"></a>
# **ApiAuthLoginPost**
> void ApiAuthLoginPost (LoginRequest? loginRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using NajotEdu.Client.Api;
using NajotEdu.Client.Client;
using NajotEdu.Client.Model;

namespace Example
{
    public class ApiAuthLoginPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthApi(httpClient, config, httpClientHandler);
            var loginRequest = new LoginRequest?(); // LoginRequest? |  (optional) 

            try
            {
                apiInstance.ApiAuthLoginPost(loginRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.ApiAuthLoginPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAuthLoginPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAuthLoginPostWithHttpInfo(loginRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.ApiAuthLoginPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginRequest** | [**LoginRequest?**](LoginRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

