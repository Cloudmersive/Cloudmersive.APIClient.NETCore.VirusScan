# Cloudmersive.APIClient.NETCore.VirusScan.Api.ScanCloudStorageApi

All URIs are relative to *https://api.cloudmersive.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ScanCloudStorageGetAsyncJobStatus**](ScanCloudStorageApi.md#scancloudstoragegetasyncjobstatus) | **GET** /virus/scan/cloud-storage/batch-job/status | Get the status and result of a Scan Cloud Storage Batch Job |
| [**ScanCloudStorageScanAwsS3File**](ScanCloudStorageApi.md#scancloudstoragescanawss3file) | **POST** /virus/scan/cloud-storage/aws-s3/single | Scan an AWS S3 file for viruses |
| [**ScanCloudStorageScanAwsS3FileAdvanced**](ScanCloudStorageApi.md#scancloudstoragescanawss3fileadvanced) | **POST** /virus/scan/cloud-storage/aws-s3/single/advanced | Advanced Scan an AWS S3 file for viruses |
| [**ScanCloudStorageScanAzureBlob**](ScanCloudStorageApi.md#scancloudstoragescanazureblob) | **POST** /virus/scan/cloud-storage/azure-blob/single | Scan an Azure Blob for viruses |
| [**ScanCloudStorageScanAzureBlobAdvanced**](ScanCloudStorageApi.md#scancloudstoragescanazureblobadvanced) | **POST** /virus/scan/cloud-storage/azure-blob/single/advanced | Advanced Scan an Azure Blob for viruses |
| [**ScanCloudStorageScanAzureBlobAdvancedBatchJob**](ScanCloudStorageApi.md#scancloudstoragescanazureblobadvancedbatchjob) | **POST** /virus/scan/cloud-storage/azure-blob/single/advanced/batch-job | Advanced Scan an Azure Blob for viruses via a batch job |
| [**ScanCloudStorageScanGcpStorageFile**](ScanCloudStorageApi.md#scancloudstoragescangcpstoragefile) | **POST** /virus/scan/cloud-storage/gcp-storage/single | Scan an Google Cloud Platform (GCP) Storage file for viruses |
| [**ScanCloudStorageScanGcpStorageFileAdvanced**](ScanCloudStorageApi.md#scancloudstoragescangcpstoragefileadvanced) | **POST** /virus/scan/cloud-storage/gcp-storage/single/advanced | Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses |
| [**ScanCloudStorageScanSharePointOnlineFile**](ScanCloudStorageApi.md#scancloudstoragescansharepointonlinefile) | **POST** /virus/scan/cloud-storage/sharepoint-online/site/single | Virus Scan a file in a SharePoint Online Site Drive |
| [**ScanCloudStorageScanSharePointOnlineFileAdvanced**](ScanCloudStorageApi.md#scancloudstoragescansharepointonlinefileadvanced) | **POST** /virus/scan/cloud-storage/sharepoint-online/site/advanced | Advanced Virus Scan a file in a SharePoint Online Site Drive |

<a id="scancloudstoragegetasyncjobstatus"></a>
# **ScanCloudStorageGetAsyncJobStatus**
> ScanCloudStorageJobStatusResult ScanCloudStorageGetAsyncJobStatus (string asyncJobID)

Get the status and result of a Scan Cloud Storage Batch Job

Returns the result of the Async Job - possible states can be STARTED or COMPLETED.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageGetAsyncJobStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var asyncJobID = "asyncJobID_example";  // string | 

            try
            {
                // Get the status and result of a Scan Cloud Storage Batch Job
                ScanCloudStorageJobStatusResult result = apiInstance.ScanCloudStorageGetAsyncJobStatus(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageGetAsyncJobStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageGetAsyncJobStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the status and result of a Scan Cloud Storage Batch Job
    ApiResponse<ScanCloudStorageJobStatusResult> response = apiInstance.ScanCloudStorageGetAsyncJobStatusWithHttpInfo(asyncJobID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageGetAsyncJobStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asyncJobID** | **string** |  |  |

### Return type

[**ScanCloudStorageJobStatusResult**](ScanCloudStorageJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescanawss3file"></a>
# **ScanCloudStorageScanAwsS3File**
> CloudStorageVirusScanResult ScanCloudStorageScanAwsS3File (string accessKey, string secretKey, string bucketRegion, string bucketName, string keyName, string roleArn = null)

Scan an AWS S3 file for viruses

Scan the contents of a single AWS S3 file and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAwsS3FileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var accessKey = "accessKey_example";  // string | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var secretKey = "secretKey_example";  // string | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var bucketRegion = "bucketRegion_example";  // string | Name of the region of the S3 bucket, such as 'US-East-1'
            var bucketName = "bucketName_example";  // string | Name of the S3 bucket
            var keyName = "keyName_example";  // string | Key name (also called file name) of the file in S3 that you wish to scan for viruses.  If the key name contains Unicode characters, you must base64 encode the key name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var roleArn = "roleArn_example";  // string | Optional: Role ARN for STS Credential-based access.  This is for advanced access using the Security Token Service and is not required.  If the roleArn contains Unicode characters, you must base64 encode the key name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'. (optional) 

            try
            {
                // Scan an AWS S3 file for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanAwsS3File(accessKey, secretKey, bucketRegion, bucketName, keyName, roleArn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3File: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanAwsS3FileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan an AWS S3 file for viruses
    ApiResponse<CloudStorageVirusScanResult> response = apiInstance.ScanCloudStorageScanAwsS3FileWithHttpInfo(accessKey, secretKey, bucketRegion, bucketName, keyName, roleArn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3FileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accessKey** | **string** | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console |  |
| **secretKey** | **string** | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console |  |
| **bucketRegion** | **string** | Name of the region of the S3 bucket, such as &#39;US-East-1&#39; |  |
| **bucketName** | **string** | Name of the S3 bucket |  |
| **keyName** | **string** | Key name (also called file name) of the file in S3 that you wish to scan for viruses.  If the key name contains Unicode characters, you must base64 encode the key name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **roleArn** | **string** | Optional: Role ARN for STS Credential-based access.  This is for advanced access using the Security Token Service and is not required.  If the roleArn contains Unicode characters, you must base64 encode the key name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. | [optional]  |

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescanawss3fileadvanced"></a>
# **ScanCloudStorageScanAwsS3FileAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanAwsS3FileAdvanced (string accessKey, string secretKey, string bucketRegion, string bucketName, string keyName, string roleArn = null, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string options = null, string restrictFileTypes = null)

Advanced Scan an AWS S3 file for viruses

Advanced Scan the contents of a single AWS S3 file and its content for viruses and threats. Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAwsS3FileAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var accessKey = "accessKey_example";  // string | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var secretKey = "secretKey_example";  // string | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var bucketRegion = "bucketRegion_example";  // string | Name of the region of the S3 bucket, such as 'US-East-1'
            var bucketName = "bucketName_example";  // string | Name of the S3 bucket
            var keyName = "keyName_example";  // string | Key name (also called file name) of the file in S3 that you wish to scan for viruses.  If the key name contains Unicode characters, you must base64 encode the key name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var roleArn = "roleArn_example";  // string | Optional: Role ARN for STS Credential-based access.  This is for advanced access using the Security Token Service and is not required.  If the roleArn contains Unicode characters, you must base64 encode the key name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'. (optional) 
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var options = "options_example";  // string | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Default is no options. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an AWS S3 file for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanAwsS3FileAdvanced(accessKey, secretKey, bucketRegion, bucketName, keyName, roleArn, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3FileAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanAwsS3FileAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Scan an AWS S3 file for viruses
    ApiResponse<CloudStorageAdvancedVirusScanResult> response = apiInstance.ScanCloudStorageScanAwsS3FileAdvancedWithHttpInfo(accessKey, secretKey, bucketRegion, bucketName, keyName, roleArn, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3FileAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accessKey** | **string** | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console |  |
| **secretKey** | **string** | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console |  |
| **bucketRegion** | **string** | Name of the region of the S3 bucket, such as &#39;US-East-1&#39; |  |
| **bucketName** | **string** | Name of the S3 bucket |  |
| **keyName** | **string** | Key name (also called file name) of the file in S3 that you wish to scan for viruses.  If the key name contains Unicode characters, you must base64 encode the key name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **roleArn** | **string** | Optional: Role ARN for STS Credential-based access.  This is for advanced access using the Security Token Service and is not required.  If the roleArn contains Unicode characters, you must base64 encode the key name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. | [optional]  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **options** | **string** | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Default is no options. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescanazureblob"></a>
# **ScanCloudStorageScanAzureBlob**
> CloudStorageVirusScanResult ScanCloudStorageScanAzureBlob (string connectionString, string containerName, string blobPath)

Scan an Azure Blob for viruses

Scan the contents of a single Azure Blob and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAzureBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var connectionString = "connectionString_example";  // string | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal.
            var containerName = "containerName_example";  // string | Name of the Blob container within the Azure Blob Storage account
            var blobPath = "blobPath_example";  // string | Path to the blob within the container, such as 'hello.pdf' or '/folder/subfolder/world.pdf'.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.

            try
            {
                // Scan an Azure Blob for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanAzureBlob(connectionString, containerName, blobPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanAzureBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan an Azure Blob for viruses
    ApiResponse<CloudStorageVirusScanResult> response = apiInstance.ScanCloudStorageScanAzureBlobWithHttpInfo(connectionString, containerName, blobPath);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectionString** | **string** | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal. |  |
| **containerName** | **string** | Name of the Blob container within the Azure Blob Storage account |  |
| **blobPath** | **string** | Path to the blob within the container, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39;.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescanazureblobadvanced"></a>
# **ScanCloudStorageScanAzureBlobAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanAzureBlobAdvanced (string connectionString, string containerName, string blobPath, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string options = null, string restrictFileTypes = null)

Advanced Scan an Azure Blob for viruses

Advanced Scan the contents of a single Azure Blob and its content for viruses and threats.  Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAzureBlobAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var connectionString = "connectionString_example";  // string | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal.
            var containerName = "containerName_example";  // string | Name of the Blob container within the Azure Blob Storage account
            var blobPath = "blobPath_example";  // string | Path to the blob within the container, such as 'hello.pdf' or '/folder/subfolder/world.pdf'.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var options = "options_example";  // string | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include scanMultipartFile to scan multi-part files such as split zip files.  Default is no options. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an Azure Blob for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanAzureBlobAdvanced(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanAzureBlobAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Scan an Azure Blob for viruses
    ApiResponse<CloudStorageAdvancedVirusScanResult> response = apiInstance.ScanCloudStorageScanAzureBlobAdvancedWithHttpInfo(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectionString** | **string** | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal. |  |
| **containerName** | **string** | Name of the Blob container within the Azure Blob Storage account |  |
| **blobPath** | **string** | Path to the blob within the container, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39;.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **options** | **string** | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include scanMultipartFile to scan multi-part files such as split zip files.  Default is no options. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescanazureblobadvancedbatchjob"></a>
# **ScanCloudStorageScanAzureBlobAdvancedBatchJob**
> ScanCloudStorageBatchJobCreateResult ScanCloudStorageScanAzureBlobAdvancedBatchJob (string connectionString, string containerName, string blobPath, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string options = null, string restrictFileTypes = null)

Advanced Scan an Azure Blob for viruses via a batch job

Via a batch job, advanced Scan the contents of a single Azure Blob and its content for viruses and threats, great for larger/longer processing jobs.  Requires Managed Instance or Private Cloud.  Returns a job ID which you can then use the Get Job Status API to get the status and output of the job.  Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAzureBlobAdvancedBatchJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var connectionString = "connectionString_example";  // string | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal.
            var containerName = "containerName_example";  // string | Name of the Blob container within the Azure Blob Storage account
            var blobPath = "blobPath_example";  // string | Path to the blob within the container, such as 'hello.pdf' or '/folder/subfolder/world.pdf'.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var options = "options_example";  // string | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include scanMultipartFile to scan multi-part files such as split zip files.  Default is no options. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an Azure Blob for viruses via a batch job
                ScanCloudStorageBatchJobCreateResult result = apiInstance.ScanCloudStorageScanAzureBlobAdvancedBatchJob(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobAdvancedBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanAzureBlobAdvancedBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Scan an Azure Blob for viruses via a batch job
    ApiResponse<ScanCloudStorageBatchJobCreateResult> response = apiInstance.ScanCloudStorageScanAzureBlobAdvancedBatchJobWithHttpInfo(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobAdvancedBatchJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **connectionString** | **string** | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal. |  |
| **containerName** | **string** | Name of the Blob container within the Azure Blob Storage account |  |
| **blobPath** | **string** | Path to the blob within the container, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39;.  If the blob path contains Unicode characters, you must base64 encode the blob path and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **options** | **string** | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Include scanMultipartFile to scan multi-part files such as split zip files.  Default is no options. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**ScanCloudStorageBatchJobCreateResult**](ScanCloudStorageBatchJobCreateResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescangcpstoragefile"></a>
# **ScanCloudStorageScanGcpStorageFile**
> CloudStorageVirusScanResult ScanCloudStorageScanGcpStorageFile (string bucketName, string objectName, System.IO.Stream jsonCredentialFile)

Scan an Google Cloud Platform (GCP) Storage file for viruses

Scan the contents of a single Google Cloud Platform (GCP) Storage file and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanGcpStorageFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var bucketName = "bucketName_example";  // string | Name of the bucket in Google Cloud Storage
            var objectName = "objectName_example";  // string | Name of the object or file in Google Cloud Storage.  If the object name contains Unicode characters, you must base64 encode the object name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var jsonCredentialFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Service Account credential for Google Cloud stored in a JSON file.

            try
            {
                // Scan an Google Cloud Platform (GCP) Storage file for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanGcpStorageFile(bucketName, objectName, jsonCredentialFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanGcpStorageFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Scan an Google Cloud Platform (GCP) Storage file for viruses
    ApiResponse<CloudStorageVirusScanResult> response = apiInstance.ScanCloudStorageScanGcpStorageFileWithHttpInfo(bucketName, objectName, jsonCredentialFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** | Name of the bucket in Google Cloud Storage |  |
| **objectName** | **string** | Name of the object or file in Google Cloud Storage.  If the object name contains Unicode characters, you must base64 encode the object name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **jsonCredentialFile** | **System.IO.Stream****System.IO.Stream** | Service Account credential for Google Cloud stored in a JSON file. |  |

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

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

<a id="scancloudstoragescangcpstoragefileadvanced"></a>
# **ScanCloudStorageScanGcpStorageFileAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanGcpStorageFileAdvanced (string bucketName, string objectName, System.IO.Stream jsonCredentialFile, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string options = null, string restrictFileTypes = null)

Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses

Advanced Scan the contents of a single Google Cloud Platform (GCP) Storage file and its content for viruses and threats. Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanGcpStorageFileAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var bucketName = "bucketName_example";  // string | Name of the bucket in Google Cloud Storage
            var objectName = "objectName_example";  // string | Name of the object or file in Google Cloud Storage.  If the object name contains Unicode characters, you must base64 encode the object name and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var jsonCredentialFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Service Account credential for Google Cloud stored in a JSON file.
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var options = "options_example";  // string | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Default is no options. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanGcpStorageFileAdvanced(bucketName, objectName, jsonCredentialFile, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFileAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanGcpStorageFileAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses
    ApiResponse<CloudStorageAdvancedVirusScanResult> response = apiInstance.ScanCloudStorageScanGcpStorageFileAdvancedWithHttpInfo(bucketName, objectName, jsonCredentialFile, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, options, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFileAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bucketName** | **string** | Name of the bucket in Google Cloud Storage |  |
| **objectName** | **string** | Name of the object or file in Google Cloud Storage.  If the object name contains Unicode characters, you must base64 encode the object name and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **jsonCredentialFile** | **System.IO.Stream****System.IO.Stream** | Service Account credential for Google Cloud stored in a JSON file. |  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **options** | **string** | Comma separated set of configuration operations.  Include permitJavascriptAndHtmlInPDFs to allow JavaScript and HTML in PDF files.  Include blockOfficeXmlOleEmbeddedFile to block embedded OLE files in Office Documents using the modern file format.  Default is no options. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

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

<a id="scancloudstoragescansharepointonlinefile"></a>
# **ScanCloudStorageScanSharePointOnlineFile**
> CloudStorageVirusScanResult ScanCloudStorageScanSharePointOnlineFile (string clientID, string clientSecret, string sharepointDomainName, string siteID, string filePath, string tenantID = null, string itemID = null)

Virus Scan a file in a SharePoint Online Site Drive

Virus Scan the contents of a single SharePoint Online Site Drive file and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time. To get the Client ID and Client Secret, follow these steps: (1) Navigate to the Azure Portal and click on Azure Active Directory, (2) click on App Registrations on the left hand side, (3) click on Register Application, (4) Name the application CloudmersiveAntiVirus and click on Register, (5) Get the client ID by clicking on Overview and copying the value labeled Application (client) ID, (6) click on Certificates and Secrets, (7) click on New client secret, choose a longer expiration and give the secret a name, (8) copy the secret value to the clipboard and save it securely, this is your Client Secret, (9) Now we need to grant permissions to SharePOint; click on API Permissions on the left hand side, (10) click on Add a permission and choose Microsoft Graph, (11) click on Application Permissions, (12) search for Sites.FullControl.All, (13) Click on Add Permissions, (14) now navigate back to Azure Active Directory and click on Enterprise Applications, click on CloudmersiveAntiVirus and click on Permissions, and (15) click on Grant Admin Consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanSharePointOnlineFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var clientID = "clientID_example";  // string | Client ID access credentials; see description above for instructions on how to get the Client ID from the Azure Active Directory portal.
            var clientSecret = "clientSecret_example";  // string | Client Secret access credentials; see description above for instructions on how to get the Client Secret from the Azure Active Directory portal
            var sharepointDomainName = "sharepointDomainName_example";  // string | SharePoint Online domain name, such as mydomain.sharepoint.com
            var siteID = "siteID_example";  // string | Site ID (GUID) of the SharePoint site you wish to retrieve the file from
            var filePath = "filePath_example";  // string | Path to the file within the drive, such as 'hello.pdf' or '/folder/subfolder/world.pdf'.  If the file path contains Unicode characters, you must base64 encode the file path and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'.
            var tenantID = "tenantID_example";  // string | Optional; Tenant ID of your Azure Active Directory (optional) 
            var itemID = "itemID_example";  // string | SharePoint itemID, such as a DriveItem Id (optional) 

            try
            {
                // Virus Scan a file in a SharePoint Online Site Drive
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanSharePointOnlineFile(clientID, clientSecret, sharepointDomainName, siteID, filePath, tenantID, itemID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanSharePointOnlineFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanSharePointOnlineFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Virus Scan a file in a SharePoint Online Site Drive
    ApiResponse<CloudStorageVirusScanResult> response = apiInstance.ScanCloudStorageScanSharePointOnlineFileWithHttpInfo(clientID, clientSecret, sharepointDomainName, siteID, filePath, tenantID, itemID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanSharePointOnlineFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientID** | **string** | Client ID access credentials; see description above for instructions on how to get the Client ID from the Azure Active Directory portal. |  |
| **clientSecret** | **string** | Client Secret access credentials; see description above for instructions on how to get the Client Secret from the Azure Active Directory portal |  |
| **sharepointDomainName** | **string** | SharePoint Online domain name, such as mydomain.sharepoint.com |  |
| **siteID** | **string** | Site ID (GUID) of the SharePoint site you wish to retrieve the file from |  |
| **filePath** | **string** | Path to the file within the drive, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39;.  If the file path contains Unicode characters, you must base64 encode the file path and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. |  |
| **tenantID** | **string** | Optional; Tenant ID of your Azure Active Directory | [optional]  |
| **itemID** | **string** | SharePoint itemID, such as a DriveItem Id | [optional]  |

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scancloudstoragescansharepointonlinefileadvanced"></a>
# **ScanCloudStorageScanSharePointOnlineFileAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanSharePointOnlineFileAdvanced (string clientID, string clientSecret, string sharepointDomainName, string siteID, string tenantID = null, string filePath = null, string itemID = null, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, bool? allowUnwantedAction = null, string restrictFileTypes = null)

Advanced Virus Scan a file in a SharePoint Online Site Drive

Advanced Virus Scan the contents of a single SharePoint Online Site Drive file and its content for viruses and threats.  Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time. To get the Client ID and Client Secret, follow these steps: (1) Navigate to the Azure Portal and click on Azure Active Directory, (2) click on App Registrations on the left hand side, (3) click on Register Application, (4) Name the application CloudmersiveAntiVirus and click on Register, (5) Get the client ID by clicking on Overview and copying the value labeled Application (client) ID, (6) click on Certificates and Secrets, (7) click on New client secret, choose a longer expiration and give the secret a name, (8) copy the secret value to the clipboard and save it securely, this is your Client Secret, (9) Now we need to grant permissions to SharePOint; click on API Permissions on the left hand side, (10) click on Add a permission and choose Microsoft Graph, (11) click on Application Permissions, (12) search for Sites.FullControl.All, (13) Click on Add Permissions, (14) now navigate back to Azure Active Directory and click on Enterprise Applications, click on CloudmersiveAntiVirus and click on Permissions, and (15) click on Grant Admin Consent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanSharePointOnlineFileAdvancedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cloudmersive.com";
            // Configure API key authorization: Apikey
            config.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi(config);
            var clientID = "clientID_example";  // string | Client ID access credentials; see description above for instructions on how to get the Client ID from the Azure Active Directory portal.
            var clientSecret = "clientSecret_example";  // string | Client Secret access credentials; see description above for instructions on how to get the Client Secret from the Azure Active Directory portal
            var sharepointDomainName = "sharepointDomainName_example";  // string | SharePoint Online domain name, such as mydomain.sharepoint.com
            var siteID = "siteID_example";  // string | Site ID (GUID) of the SharePoint site you wish to retrieve the file from
            var tenantID = "tenantID_example";  // string | Optional; Tenant ID of your Azure Active Directory (optional) 
            var filePath = "filePath_example";  // string | Path to the file within the drive, such as 'hello.pdf' or '/folder/subfolder/world.pdf'.  If the file path contains Unicode characters, you must base64 encode the file path and prepend it with 'base64:', such as: 'base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV'. (optional) 
            var itemID = "itemID_example";  // string | SharePoint itemID, such as a DriveItem Id (optional) 
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowXmlExternalEntities = true;  // bool? | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). (optional) 
            var allowInsecureDeserialization = true;  // bool? | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowHtml = true;  // bool? | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. (optional) 
            var allowUnsafeArchives = true;  // bool? | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. (optional) 
            var allowOleEmbeddedObject = true;  // bool? | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. (optional) 
            var allowUnwantedAction = true;  // bool? | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. (optional) 
            var restrictFileTypes = "restrictFileTypes_example";  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Virus Scan a file in a SharePoint Online Site Drive
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanSharePointOnlineFileAdvanced(clientID, clientSecret, sharepointDomainName, siteID, tenantID, filePath, itemID, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanSharePointOnlineFileAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanCloudStorageScanSharePointOnlineFileAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advanced Virus Scan a file in a SharePoint Online Site Drive
    ApiResponse<CloudStorageAdvancedVirusScanResult> response = apiInstance.ScanCloudStorageScanSharePointOnlineFileAdvancedWithHttpInfo(clientID, clientSecret, sharepointDomainName, siteID, tenantID, filePath, itemID, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, allowXmlExternalEntities, allowInsecureDeserialization, allowHtml, allowUnsafeArchives, allowOleEmbeddedObject, allowUnwantedAction, restrictFileTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanSharePointOnlineFileAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientID** | **string** | Client ID access credentials; see description above for instructions on how to get the Client ID from the Azure Active Directory portal. |  |
| **clientSecret** | **string** | Client Secret access credentials; see description above for instructions on how to get the Client Secret from the Azure Active Directory portal |  |
| **sharepointDomainName** | **string** | SharePoint Online domain name, such as mydomain.sharepoint.com |  |
| **siteID** | **string** | Site ID (GUID) of the SharePoint site you wish to retrieve the file from |  |
| **tenantID** | **string** | Optional; Tenant ID of your Azure Active Directory | [optional]  |
| **filePath** | **string** | Path to the file within the drive, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39;.  If the file path contains Unicode characters, you must base64 encode the file path and prepend it with &#39;base64:&#39;, such as: &#39;base64:6ZWV6ZWV6ZWV6ZWV6ZWV6ZWV&#39;. | [optional]  |
| **itemID** | **string** | SharePoint itemID, such as a DriveItem Id | [optional]  |
| **allowExecutables** | **bool?** | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional]  |
| **allowInvalidFiles** | **bool?** | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional]  |
| **allowScripts** | **bool?** | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowPasswordProtectedFiles** | **bool?** | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowMacros** | **bool?** | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowXmlExternalEntities** | **bool?** | Set to false to block XML External Entities and other threats embedded in XML files, and other files that contain embedded content threats. Set to true to allow these file types. Default is false (recommended). | [optional]  |
| **allowInsecureDeserialization** | **bool?** | Set to false to block Insecure Deserialization and other threats embedded in JSON and other object serialization files, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional]  |
| **allowHtml** | **bool?** | Set to false to block HTML input in the top level file; HTML can contain XSS, scripts, local file accesses and other threats.  Set to true to allow these file types.  Default is false (recommended) [for API keys created prior to the release of this feature default is true for backward compatability]. | [optional]  |
| **allowUnsafeArchives** | **bool?** | Set to false to block unsafe archives such as Zip Bombs, and other archives that can cause unsafe extraction outcomes.  Default is false (recommended).  If set to true, unsafe archives will be allowed. | [optional]  |
| **allowOleEmbeddedObject** | **bool?** | Set to false to block OLE embedded objects, which can contain vulnerabilities and executable code.  Default is false (recommended).  If set to true, OLE embedded objects will be allowed. | [optional]  |
| **allowUnwantedAction** | **bool?** | Set to false to block unwanted or undesired actions, which can contain execute or open links or content when the file is viewed.  Default is false (recommended).  If set to true, unwanted actions will be allowed. | [optional]  |
| **restrictFileTypes** | **string** | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional]  |

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

