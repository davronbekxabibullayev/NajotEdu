# NajotEdu.Client.Api.StudentApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiStudentGetAllGet**](StudentApi.md#apistudentgetallget) | **GET** /api/Student/GetAll |  |
| [**ApiStudentGetByIdGet**](StudentApi.md#apistudentgetbyidget) | **GET** /api/Student/GetById |  |
| [**ApiStudentIdDelete**](StudentApi.md#apistudentiddelete) | **DELETE** /api/Student/{Id} |  |
| [**ApiStudentPost**](StudentApi.md#apistudentpost) | **POST** /api/Student |  |
| [**ApiStudentPut**](StudentApi.md#apistudentput) | **PUT** /api/Student |  |

<a id="apistudentgetallget"></a>
# **ApiStudentGetAllGet**
> void ApiStudentGetAllGet ()



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
    public class ApiStudentGetAllGetExample
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
            var apiInstance = new StudentApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ApiStudentGetAllGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentApi.ApiStudentGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiStudentGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiStudentGetAllGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentApi.ApiStudentGetAllGetWithHttpInfo: " + e.Message);
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

<a id="apistudentgetbyidget"></a>
# **ApiStudentGetByIdGet**
> void ApiStudentGetByIdGet (int? id = null)



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
    public class ApiStudentGetByIdGetExample
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
            var apiInstance = new StudentApi(httpClient, config, httpClientHandler);
            var id = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiStudentGetByIdGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentApi.ApiStudentGetByIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiStudentGetByIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiStudentGetByIdGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentApi.ApiStudentGetByIdGetWithHttpInfo: " + e.Message);
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

<a id="apistudentiddelete"></a>
# **ApiStudentIdDelete**
> void ApiStudentIdDelete (int id)



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
    public class ApiStudentIdDeleteExample
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
            var apiInstance = new StudentApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.ApiStudentIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentApi.ApiStudentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiStudentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiStudentIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentApi.ApiStudentIdDeleteWithHttpInfo: " + e.Message);
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

<a id="apistudentpost"></a>
# **ApiStudentPost**
> void ApiStudentPost (CreateStudentModel? createStudentModel = null)



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
    public class ApiStudentPostExample
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
            var apiInstance = new StudentApi(httpClient, config, httpClientHandler);
            var createStudentModel = new CreateStudentModel?(); // CreateStudentModel? |  (optional) 

            try
            {
                apiInstance.ApiStudentPost(createStudentModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentApi.ApiStudentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiStudentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiStudentPostWithHttpInfo(createStudentModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentApi.ApiStudentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createStudentModel** | [**CreateStudentModel?**](CreateStudentModel?.md) |  | [optional]  |

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

<a id="apistudentput"></a>
# **ApiStudentPut**
> void ApiStudentPut (UpdateStudentModel? updateStudentModel = null)



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
    public class ApiStudentPutExample
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
            var apiInstance = new StudentApi(httpClient, config, httpClientHandler);
            var updateStudentModel = new UpdateStudentModel?(); // UpdateStudentModel? |  (optional) 

            try
            {
                apiInstance.ApiStudentPut(updateStudentModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentApi.ApiStudentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiStudentPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiStudentPutWithHttpInfo(updateStudentModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentApi.ApiStudentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateStudentModel** | [**UpdateStudentModel?**](UpdateStudentModel?.md) |  | [optional]  |

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

