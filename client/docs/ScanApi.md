# Cloudmersive.APIClient.NETCore.VirusScan.Api.ScanApi

All URIs are relative to *https://api.cloudmersive.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ScanFile**](ScanApi.md#scanfile) | **POST** /virus/scan/file | Scan a file for viruses |
| [**ScanFileAdvanced**](ScanApi.md#scanfileadvanced) | **POST** /virus/scan/file/advanced | Advanced Scan a file for viruses |
| [**ScanWebsite**](ScanApi.md#scanwebsite) | **POST** /virus/scan/website | Scan a website for malicious content and threats |

<a id="scanfile"></a>
# **ScanFile**
> VirusScanResult ScanFile (System.IO.Stream inputFile)

Scan a file for viruses

Scan files and content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanApi(config);
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Scan a file for viruses
                VirusScanResult result = apiInstance.ScanFile(inputFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ScanFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan a file for viruses
    ApiResponse<VirusScanResult> response = apiInstance.ScanFileWithHttpInfo(inputFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanApi.ScanFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputFile** | **System.IO.Stream****System.IO.Stream** | Input file to perform the operation on. |  |

### Return type

[**VirusScanResult**](VirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scanfileadvanced"></a>
# **ScanFileAdvanced**
> VirusScanAdvancedResult ScanFileAdvanced (System.IO.Stream inputFile, string fileName = null, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string options = null, string restrictFileTypes = null)

Advanced Scan a file for viruses

Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash, MSG, and a wide range of image file formats.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanFileAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanApi(config);
            var inputFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Input file to perform the operation on.
            var fileName = "fileName_example";  // string | Optional: specify the original file name of the file being scanned.  By default the file name is taken from inputFile parameter, but if this is not provided, or you wish to override it, you can specify the original file name using this parameter. (optional) 
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, BAT scripts, JS scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros (including support for .DOCX, .XLSX, .PPTX, .DOC and .XLS), and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability].  If set to true, HTML files containing script tags will be allowed, but ContainsScript will be set to true if script tags are present. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var options = "options_example";  // string | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include permitJavascriptInHtml to allow JavaScript in HTML files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include blockInvalidUris to block invalid URIs in Office documents.  Include permitAuthenticodeSignedExecutables to allow executables if they have a valid Authenticode signature.  Include scanMultipartFile to scan multi-part files such as split zip files.  Include ignoreRestrictFileTypesForAttachments to ignore restrictFileTypes setting for file attachments.  Default is no options. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan a file for viruses
                VirusScanAdvancedResult result = apiInstance.ScanFileAdvanced(inputFile, fileName, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ScanFileAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanFileAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Scan a file for viruses
    ApiResponse<VirusScanAdvancedResult> response = apiInstance.ScanFileAdvancedWithHttpInfo(inputFile, fileName, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanApi.ScanFileAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inputFile** | **System.IO.Stream****System.IO.Stream** | Input file to perform the operation on. |  |
| **fileName** | **string** | Optional: specify the original file name of the file being scanned.  By default the file name is taken from inputFile parameter, but if this is not provided, or you wish to override it, you can specify the original file name using this parameter. | [optional]  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, BAT scripts, JS scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros (including support for .DOCX, .XLSX, .PPTX, .DOC and .XLS), and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability].  If set to true, HTML files containing script tags will be allowed, but ContainsScript will be set to true if script tags are present. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **options** | **string** | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include permitJavascriptInHtml to allow JavaScript in HTML files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include blockInvalidUris to block invalid URIs in Office documents.  Include permitAuthenticodeSignedExecutables to allow executables if they have a valid Authenticode signature.  Include scanMultipartFile to scan multi-part files such as split zip files.  Include ignoreRestrictFileTypesForAttachments to ignore restrictFileTypes setting for file attachments.  Default is no options. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**VirusScanAdvancedResult**](VirusScanAdvancedResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scanwebsite"></a>
# **ScanWebsite**
> WebsiteScanResult ScanWebsite (WebsiteScanRequest input)

Scan a website for malicious content and threats

Operation includes scanning the content of the URL for various types of malicious content and threats, including viruses and threats (including Phishing).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanWebsiteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanApi(config);
            var input = new WebsiteScanRequest(); // WebsiteScanRequest | 

            try
            {
                // Scan a website for malicious content and threats
                WebsiteScanResult result = apiInstance.ScanWebsite(input);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ScanWebsite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanWebsiteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan a website for malicious content and threats
    ApiResponse<WebsiteScanResult> response = apiInstance.ScanWebsiteWithHttpInfo(input);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanApi.ScanWebsiteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **input** | [**WebsiteScanRequest**](WebsiteScanRequest.md) |  |  |

### Return type

[**WebsiteScanResult**](WebsiteScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

