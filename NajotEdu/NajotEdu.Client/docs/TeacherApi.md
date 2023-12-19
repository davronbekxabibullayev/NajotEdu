# NajotEdu.Client.Api.TeacherApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiTeacherGetAllGet**](TeacherApi.md#apiteachergetallget) | **GET** /api/Teacher/GetAll |  |
| [**ApiTeacherGetByIdGet**](TeacherApi.md#apiteachergetbyidget) | **GET** /api/Teacher/GetById |  |
| [**ApiTeacherIdDelete**](TeacherApi.md#apiteacheriddelete) | **DELETE** /api/Teacher/{Id} |  |
| [**ApiTeacherPost**](TeacherApi.md#apiteacherpost) | **POST** /api/Teacher |  |
| [**ApiTeacherPut**](TeacherApi.md#apiteacherput) | **PUT** /api/Teacher |  |

<a id="apiteachergetallget"></a>
# **ApiTeacherGetAllGet**
> void ApiTeacherGetAllGet ()



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
    public class ApiTeacherGetAllGetExample
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
            var apiInstance = new TeacherApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ApiTeacherGetAllGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeacherApi.ApiTeacherGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTeacherGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiTeacherGetAllGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeacherApi.ApiTeacherGetAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiteachergetbyidget"></a>
# **ApiTeacherGetByIdGet**
> void ApiTeacherGetByIdGet (int? id = null)



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
    public class ApiTeacherGetByIdGetExample
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
            var apiInstance = new TeacherApi(httpClient, config, httpClientHandler);
            var id = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiTeacherGetByIdGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeacherApi.ApiTeacherGetByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTeacherGetByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiTeacherGetByIdGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeacherApi.ApiTeacherGetByIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiteacheriddelete"></a>
# **ApiTeacherIdDelete**
> void ApiTeacherIdDelete (int id)



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
    public class ApiTeacherIdDeleteExample
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
            var apiInstance = new TeacherApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.ApiTeacherIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeacherApi.ApiTeacherIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTeacherIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiTeacherIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeacherApi.ApiTeacherIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiteacherpost"></a>
# **ApiTeacherPost**
> void ApiTeacherPost (CreateTeacherModel? createTeacherModel = null)



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
    public class ApiTeacherPostExample
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
            var apiInstance = new TeacherApi(httpClient, config, httpClientHandler);
            var createTeacherModel = new CreateTeacherModel?(); // CreateTeacherModel? |  (optional) 

            try
            {
                apiInstance.ApiTeacherPost(createTeacherModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeacherApi.ApiTeacherPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTeacherPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiTeacherPostWithHttpInfo(createTeacherModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeacherApi.ApiTeacherPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTeacherModel** | [**CreateTeacherModel?**](CreateTeacherModel?.md) |  | [optional]  |

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

<a id="apiteacherput"></a>
# **ApiTeacherPut**
> void ApiTeacherPut (UpdateTeacherModel? updateTeacherModel = null)



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
    public class ApiTeacherPutExample
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
            var apiInstance = new TeacherApi(httpClient, config, httpClientHandler);
            var updateTeacherModel = new UpdateTeacherModel?(); // UpdateTeacherModel? |  (optional) 

            try
            {
                apiInstance.ApiTeacherPut(updateTeacherModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeacherApi.ApiTeacherPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiTeacherPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiTeacherPutWithHttpInfo(updateTeacherModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TeacherApi.ApiTeacherPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateTeacherModel** | [**UpdateTeacherModel?**](UpdateTeacherModel?.md) |  | [optional]  |

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

