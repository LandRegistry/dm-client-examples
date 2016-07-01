# IO.Swagger.Api.DeedApi

All URIs are relative to *https://api.landregistry.gov.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeedDeedReferenceGet**](DeedApi.md#deeddeedreferenceget) | **GET** /deed/{deed_reference} | Deed


# **DeedDeedReferenceGet**
> OperativeDeed DeedDeedReferenceGet (string deedReference)

Deed

The Deed endpoint returns details of a specific deed based on the unique deed reference. The response includes the Title Number, Property information, Borrower(s) information and deed information. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeedDeedReferenceGetExample
    {
        public void main()
        {
            
            var apiInstance = new DeedApi();
            var deedReference = deedReference_example;  // string | Unique reference of the deed.

            try
            {
                // Deed
                OperativeDeed result = apiInstance.DeedDeedReferenceGet(deedReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeedApi.DeedDeedReferenceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deedReference** | **string**| Unique reference of the deed. | 

### Return type

[**OperativeDeed**](OperativeDeed.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

