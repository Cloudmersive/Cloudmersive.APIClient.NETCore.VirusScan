# Cloudmersive.APIClient.NETCore.VirusScan.Api.ScanApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScanFile**](ScanApi.md#scanfile) | **POST** /virus/scan/file | Scan a file for viruses


<a name="scanfile"></a>
# **ScanFile**
> VirusScanResult ScanFile (System.IO.Stream inputFile)

Scan a file for viruses

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanFileExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Scan a file for viruses
                VirusScanResult result = apiInstance.ScanFile(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanApi.ScanFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**VirusScanResult**](VirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

