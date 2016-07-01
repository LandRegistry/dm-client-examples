# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://api.landregistry.gov.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDeed**](DefaultApi.md#adddeed) | **POST** /deed/ | Deed


# **AddDeed**
> string AddDeed (DeedApplication body)

Deed

The post Deed endpoint creates a new deed based on the JSON provided.  The reponse will return a URL that can retrieve the created deed.   > REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDeedExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var body = new DeedApplication(); // DeedApplication | 

            try
            {
                // Deed
                string result = apiInstance.AddDeed(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddDeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DeedApplication**](DeedApplication.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

