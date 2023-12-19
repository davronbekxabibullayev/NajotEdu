# NajotEdu.Client.Api.AttendanceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAttendanceCheckPost**](AttendanceApi.md#apiattendancecheckpost) | **POST** /api/Attendance/Check |  |

<a id="apiattendancecheckpost"></a>
# **ApiAttendanceCheckPost**
> void ApiAttendanceCheckPost (DoAttendenceCheckModel? doAttendenceCheckModel = null)



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
    public class ApiAttendanceCheckPostExample
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
            var apiInstance = new AttendanceApi(httpClient, config, httpClientHandler);
            var doAttendenceCheckModel = new DoAttendenceCheckModel?(); // DoAttendenceCheckModel? |  (optional) 

            try
            {
                apiInstance.ApiAttendanceCheckPost(doAttendenceCheckModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttendanceApi.ApiAttendanceCheckPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAttendanceCheckPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAttendanceCheckPostWithHttpInfo(doAttendenceCheckModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttendanceApi.ApiAttendanceCheckPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **doAttendenceCheckModel** | [**DoAttendenceCheckModel?**](DoAttendenceCheckModel?.md) |  | [optional]  |

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

