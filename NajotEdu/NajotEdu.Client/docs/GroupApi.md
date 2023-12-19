# NajotEdu.Client.Api.GroupApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiGroupGetAllGet**](GroupApi.md#apigroupgetallget) | **GET** /api/Group/GetAll |  |
| [**ApiGroupGroupIdLessonsGet**](GroupApi.md#apigroupgroupidlessonsget) | **GET** /api/Group/{groupId}/lessons |  |
| [**ApiGroupGroupIdStudentDelete**](GroupApi.md#apigroupgroupidstudentdelete) | **DELETE** /api/Group/{groupId}/student |  |
| [**ApiGroupGroupIdStudentPost**](GroupApi.md#apigroupgroupidstudentpost) | **POST** /api/Group/{groupId}/student |  |
| [**ApiGroupIdDelete**](GroupApi.md#apigroupiddelete) | **DELETE** /api/Group/{Id} |  |
| [**ApiGroupIdGet**](GroupApi.md#apigroupidget) | **GET** /api/Group/{Id} |  |
| [**ApiGroupPost**](GroupApi.md#apigrouppost) | **POST** /api/Group |  |
| [**ApiGroupPut**](GroupApi.md#apigroupput) | **PUT** /api/Group |  |

<a id="apigroupgetallget"></a>
# **ApiGroupGetAllGet**
> void ApiGroupGetAllGet ()



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
    public class ApiGroupGetAllGetExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ApiGroupGetAllGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupGetAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupGetAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupGetAllGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupGetAllGetWithHttpInfo: " + e.Message);
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

<a id="apigroupgroupidlessonsget"></a>
# **ApiGroupGroupIdLessonsGet**
> void ApiGroupGroupIdLessonsGet (int groupId)



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
    public class ApiGroupGroupIdLessonsGetExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var groupId = 56;  // int | 

            try
            {
                apiInstance.ApiGroupGroupIdLessonsGet(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdLessonsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupGroupIdLessonsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupGroupIdLessonsGetWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdLessonsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** |  |  |

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

<a id="apigroupgroupidstudentdelete"></a>
# **ApiGroupGroupIdStudentDelete**
> void ApiGroupGroupIdStudentDelete (int groupId, int? studentId = null)



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
    public class ApiGroupGroupIdStudentDeleteExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var groupId = 56;  // int | 
            var studentId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiGroupGroupIdStudentDelete(groupId, studentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdStudentDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupGroupIdStudentDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupGroupIdStudentDeleteWithHttpInfo(groupId, studentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdStudentDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** |  |  |
| **studentId** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apigroupgroupidstudentpost"></a>
# **ApiGroupGroupIdStudentPost**
> void ApiGroupGroupIdStudentPost (int groupId, AddStudentGroupModel? addStudentGroupModel = null)



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
    public class ApiGroupGroupIdStudentPostExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var groupId = 56;  // int | 
            var addStudentGroupModel = new AddStudentGroupModel?(); // AddStudentGroupModel? |  (optional) 

            try
            {
                apiInstance.ApiGroupGroupIdStudentPost(groupId, addStudentGroupModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdStudentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupGroupIdStudentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupGroupIdStudentPostWithHttpInfo(groupId, addStudentGroupModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupGroupIdStudentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **int** |  |  |
| **addStudentGroupModel** | [**AddStudentGroupModel?**](AddStudentGroupModel?.md) |  | [optional]  |

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

<a id="apigroupiddelete"></a>
# **ApiGroupIdDelete**
> void ApiGroupIdDelete (string id, int? id2 = null)



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
    public class ApiGroupIdDeleteExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | 
            var id2 = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiGroupIdDelete(id, id2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupIdDeleteWithHttpInfo(id, id2);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **id2** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apigroupidget"></a>
# **ApiGroupIdGet**
> void ApiGroupIdGet (int id)



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
    public class ApiGroupIdGetExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.ApiGroupIdGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupIdGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupIdGetWithHttpInfo: " + e.Message);
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

<a id="apigrouppost"></a>
# **ApiGroupPost**
> void ApiGroupPost (CreateGroupModel? createGroupModel = null)



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
    public class ApiGroupPostExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var createGroupModel = new CreateGroupModel?(); // CreateGroupModel? |  (optional) 

            try
            {
                apiInstance.ApiGroupPost(createGroupModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupPostWithHttpInfo(createGroupModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupModel** | [**CreateGroupModel?**](CreateGroupModel?.md) |  | [optional]  |

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

<a id="apigroupput"></a>
# **ApiGroupPut**
> void ApiGroupPut (int? id = null, string? name = null, DateTime? startDate = null, DateTime? endDate = null, int? teacherId = null)



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
    public class ApiGroupPutExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 56;  // int? |  (optional) 
            var name = "name_example";  // string? |  (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var teacherId = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiGroupPut(id, name, startDate, endDate, teacherId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.ApiGroupPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGroupPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiGroupPutWithHttpInfo(id, name, startDate, endDate, teacherId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.ApiGroupPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  | [optional]  |
| **name** | **string?** |  | [optional]  |
| **startDate** | **DateTime?** |  | [optional]  |
| **endDate** | **DateTime?** |  | [optional]  |
| **teacherId** | **int?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

