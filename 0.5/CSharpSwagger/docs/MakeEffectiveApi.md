# IO.Swagger.Api.MakeEffectiveApi

All URIs are relative to *https://api.landregistry.gov.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeedDeedReferenceMakeEffectivePost**](MakeEffectiveApi.md#deeddeedreferencemakeeffectivepost) | **POST** /deed/{deed_reference}/make-effective | Make Effective


# **DeedDeedReferenceMakeEffectivePost**
> OperativeDeed DeedDeedReferenceMakeEffectivePost (string deedReference)

Make Effective

The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeedDeedReferenceMakeEffectivePostExample
    {
        public void main()
        {
            
            var apiInstance = new MakeEffectiveApi();
            var deedReference = deedReference_example;  // string | Unique reference of the deed.

            try
            {
                // Make Effective
                OperativeDeed result = apiInstance.DeedDeedReferenceMakeEffectivePost(deedReference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MakeEffectiveApi.DeedDeedReferenceMakeEffectivePost: " + e.Message );
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

