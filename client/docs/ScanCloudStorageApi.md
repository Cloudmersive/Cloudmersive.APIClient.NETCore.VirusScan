# Cloudmersive.APIClient.NETCore.VirusScan.Api.ScanCloudStorageApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScanCloudStorageScanAwsS3File**](ScanCloudStorageApi.md#scancloudstoragescanawss3file) | **POST** /virus/scan/cloud-storage/aws-s3/single | Scan an AWS S3 file for viruses
[**ScanCloudStorageScanAwsS3FileAdvanced**](ScanCloudStorageApi.md#scancloudstoragescanawss3fileadvanced) | **POST** /virus/scan/cloud-storage/aws-s3/single/advanced | Advanced Scan an AWS S3 file for viruses
[**ScanCloudStorageScanAzureBlob**](ScanCloudStorageApi.md#scancloudstoragescanazureblob) | **POST** /virus/scan/cloud-storage/azure-blob/single | Scan an Azure Blob for viruses
[**ScanCloudStorageScanAzureBlobAdvanced**](ScanCloudStorageApi.md#scancloudstoragescanazureblobadvanced) | **POST** /virus/scan/cloud-storage/azure-blob/single/advanced | Advanced Scan an Azure Blob for viruses
[**ScanCloudStorageScanGcpStorageFile**](ScanCloudStorageApi.md#scancloudstoragescangcpstoragefile) | **POST** /virus/scan/cloud-storage/gcp-storage/single | Scan an Google Cloud Platform (GCP) Storage file for viruses
[**ScanCloudStorageScanGcpStorageFileAdvanced**](ScanCloudStorageApi.md#scancloudstoragescangcpstoragefileadvanced) | **POST** /virus/scan/cloud-storage/gcp-storage/single/advanced | Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses


<a name="scancloudstoragescanawss3file"></a>
# **ScanCloudStorageScanAwsS3File**
> CloudStorageVirusScanResult ScanCloudStorageScanAwsS3File (string accessKey, string secretKey, string bucketRegion, string bucketName, string keyName)

Scan an AWS S3 file for viruses

Scan the contents of a single AWS S3 file and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAwsS3FileExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var accessKey = accessKey_example;  // string | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var secretKey = secretKey_example;  // string | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var bucketRegion = bucketRegion_example;  // string | Name of the region of the S3 bucket, such as 'US-East-1'
            var bucketName = bucketName_example;  // string | Name of the S3 bucket
            var keyName = keyName_example;  // string | Key name (also called file name) of the file in S3 that you wish to scan for viruses

            try
            {
                // Scan an AWS S3 file for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanAwsS3File(accessKey, secretKey, bucketRegion, bucketName, keyName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3File: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessKey** | **string**| AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console | 
 **secretKey** | **string**| AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console | 
 **bucketRegion** | **string**| Name of the region of the S3 bucket, such as &#39;US-East-1&#39; | 
 **bucketName** | **string**| Name of the S3 bucket | 
 **keyName** | **string**| Key name (also called file name) of the file in S3 that you wish to scan for viruses | 

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scancloudstoragescanawss3fileadvanced"></a>
# **ScanCloudStorageScanAwsS3FileAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanAwsS3FileAdvanced (string accessKey, string secretKey, string bucketRegion, string bucketName, string keyName, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, string restrictFileTypes = null)

Advanced Scan an AWS S3 file for viruses

Advanced Scan the contents of a single AWS S3 file and its content for viruses and threats. Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAwsS3FileAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var accessKey = accessKey_example;  // string | AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var secretKey = secretKey_example;  // string | AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console
            var bucketRegion = bucketRegion_example;  // string | Name of the region of the S3 bucket, such as 'US-East-1'
            var bucketName = bucketName_example;  // string | Name of the S3 bucket
            var keyName = keyName_example;  // string | Key name (also called file name) of the file in S3 that you wish to scan for viruses
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var restrictFileTypes = restrictFileTypes_example;  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an AWS S3 file for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanAwsS3FileAdvanced(accessKey, secretKey, bucketRegion, bucketName, keyName, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAwsS3FileAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessKey** | **string**| AWS S3 access key for the S3 bucket; you can get this from My Security Credentials in the AWS console | 
 **secretKey** | **string**| AWS S3 secret key for the S3 bucket; you can get this from My Security Credentials in the AWS console | 
 **bucketRegion** | **string**| Name of the region of the S3 bucket, such as &#39;US-East-1&#39; | 
 **bucketName** | **string**| Name of the S3 bucket | 
 **keyName** | **string**| Key name (also called file name) of the file in S3 that you wish to scan for viruses | 
 **allowExecutables** | **bool?**| Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional] 
 **allowInvalidFiles** | **bool?**| Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional] 
 **allowScripts** | **bool?**| Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowPasswordProtectedFiles** | **bool?**| Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowMacros** | **bool?**| Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **restrictFileTypes** | **string**| Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional] 

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scancloudstoragescanazureblob"></a>
# **ScanCloudStorageScanAzureBlob**
> CloudStorageVirusScanResult ScanCloudStorageScanAzureBlob (string connectionString, string containerName, string blobPath)

Scan an Azure Blob for viruses

Scan the contents of a single Azure Blob and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAzureBlobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var connectionString = connectionString_example;  // string | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal.
            var containerName = containerName_example;  // string | Name of the Blob container within the Azure Blob Storage account
            var blobPath = blobPath_example;  // string | Path to the blob within the container, such as 'hello.pdf' or '/folder/subfolder/world.pdf'

            try
            {
                // Scan an Azure Blob for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanAzureBlob(connectionString, containerName, blobPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectionString** | **string**| Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal. | 
 **containerName** | **string**| Name of the Blob container within the Azure Blob Storage account | 
 **blobPath** | **string**| Path to the blob within the container, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39; | 

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scancloudstoragescanazureblobadvanced"></a>
# **ScanCloudStorageScanAzureBlobAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanAzureBlobAdvanced (string connectionString, string containerName, string blobPath, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, string restrictFileTypes = null)

Advanced Scan an Azure Blob for viruses

Advanced Scan the contents of a single Azure Blob and its content for viruses and threats.  Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanAzureBlobAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var connectionString = connectionString_example;  // string | Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal.
            var containerName = containerName_example;  // string | Name of the Blob container within the Azure Blob Storage account
            var blobPath = blobPath_example;  // string | Path to the blob within the container, such as 'hello.pdf' or '/folder/subfolder/world.pdf'
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var restrictFileTypes = restrictFileTypes_example;  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an Azure Blob for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanAzureBlobAdvanced(connectionString, containerName, blobPath, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanAzureBlobAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectionString** | **string**| Connection string for the Azure Blob Storage Account; you can get this connection string from the Access Keys tab of the Storage Account blade in the Azure Portal. | 
 **containerName** | **string**| Name of the Blob container within the Azure Blob Storage account | 
 **blobPath** | **string**| Path to the blob within the container, such as &#39;hello.pdf&#39; or &#39;/folder/subfolder/world.pdf&#39; | 
 **allowExecutables** | **bool?**| Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional] 
 **allowInvalidFiles** | **bool?**| Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional] 
 **allowScripts** | **bool?**| Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowPasswordProtectedFiles** | **bool?**| Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowMacros** | **bool?**| Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **restrictFileTypes** | **string**| Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional] 

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scancloudstoragescangcpstoragefile"></a>
# **ScanCloudStorageScanGcpStorageFile**
> CloudStorageVirusScanResult ScanCloudStorageScanGcpStorageFile (string bucketName, string objectName, System.IO.Stream jsonCredentialFile)

Scan an Google Cloud Platform (GCP) Storage file for viruses

Scan the contents of a single Google Cloud Platform (GCP) Storage file and its content for viruses. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanGcpStorageFileExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var bucketName = bucketName_example;  // string | Name of the bucket in Google Cloud Storage
            var objectName = objectName_example;  // string | Name of the object or file in Google Cloud Storage
            var jsonCredentialFile = new System.IO.Stream(); // System.IO.Stream | Service Account credential for Google Cloud stored in a JSON file.

            try
            {
                // Scan an Google Cloud Platform (GCP) Storage file for viruses
                CloudStorageVirusScanResult result = apiInstance.ScanCloudStorageScanGcpStorageFile(bucketName, objectName, jsonCredentialFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bucketName** | **string**| Name of the bucket in Google Cloud Storage | 
 **objectName** | **string**| Name of the object or file in Google Cloud Storage | 
 **jsonCredentialFile** | **System.IO.Stream**| Service Account credential for Google Cloud stored in a JSON file. | 

### Return type

[**CloudStorageVirusScanResult**](CloudStorageVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scancloudstoragescangcpstoragefileadvanced"></a>
# **ScanCloudStorageScanGcpStorageFileAdvanced**
> CloudStorageAdvancedVirusScanResult ScanCloudStorageScanGcpStorageFileAdvanced (string bucketName, string objectName, System.IO.Stream jsonCredentialFile, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, string restrictFileTypes = null)

Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses

Advanced Scan the contents of a single Google Cloud Platform (GCP) Storage file and its content for viruses and threats. Advanced Scan files with 360-degree Content Protection across Viruses and Malware, executables, invalid files, scripts, and even restrictions on accepted file types with complete content verification. Customize threat rules to your needs. Leverage continuously updated signatures for millions of threats, and advanced high-performance scanning capabilities.  Over 17 million virus and malware signatures.  Continuous cloud-based updates.  Block threats beyond viruses including executables, scripts, invalid files, and more.  Optionally limit input files to a specific set of file types (e.g. PDF and Word Documents only).  Wide file format support including Office, PDF, HTML, Flash.  Zip support including .Zip, .Rar, .DMG, .Tar, and other archive formats.  Multi-threat scanning across viruses, malware, trojans, ransomware, and spyware.  High-speed in-memory scanning delivers subsecond typical response time.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class ScanCloudStorageScanGcpStorageFileAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ScanCloudStorageApi();
            var bucketName = bucketName_example;  // string | Name of the bucket in Google Cloud Storage
            var objectName = objectName_example;  // string | Name of the object or file in Google Cloud Storage
            var jsonCredentialFile = new System.IO.Stream(); // System.IO.Stream | Service Account credential for Google Cloud stored in a JSON file.
            var allowExecutables = true;  // bool? | Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). (optional) 
            var allowInvalidFiles = true;  // bool? | Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). (optional) 
            var allowScripts = true;  // bool? | Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowPasswordProtectedFiles = true;  // bool? | Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var allowMacros = true;  // bool? | Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). (optional) 
            var restrictFileTypes = restrictFileTypes_example;  // string | Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult=false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. (optional) 

            try
            {
                // Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses
                CloudStorageAdvancedVirusScanResult result = apiInstance.ScanCloudStorageScanGcpStorageFileAdvanced(bucketName, objectName, jsonCredentialFile, allowExecutables, allowInvalidFiles, allowScripts, allowPasswordProtectedFiles, allowMacros, restrictFileTypes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScanCloudStorageApi.ScanCloudStorageScanGcpStorageFileAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bucketName** | **string**| Name of the bucket in Google Cloud Storage | 
 **objectName** | **string**| Name of the object or file in Google Cloud Storage | 
 **jsonCredentialFile** | **System.IO.Stream**| Service Account credential for Google Cloud stored in a JSON file. | 
 **allowExecutables** | **bool?**| Set to false to block executable files (program code) from being allowed in the input file.  Default is false (recommended). | [optional] 
 **allowInvalidFiles** | **bool?**| Set to false to block invalid files, such as a PDF file that is not really a valid PDF file, or a Word Document that is not a valid Word Document.  Default is false (recommended). | [optional] 
 **allowScripts** | **bool?**| Set to false to block script files, such as a PHP files, Python scripts, and other malicious content or security threats that can be embedded in the file.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowPasswordProtectedFiles** | **bool?**| Set to false to block password protected and encrypted files, such as encrypted zip and rar files, and other files that seek to circumvent scanning through passwords.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **allowMacros** | **bool?**| Set to false to block macros and other threats embedded in document files, such as Word, Excel and PowerPoint embedded Macros, and other files that contain embedded content threats.  Set to true to allow these file types.  Default is false (recommended). | [optional] 
 **restrictFileTypes** | **string**| Specify a restricted set of file formats to allow as clean as a comma-separated list of file formats, such as .pdf,.docx,.png would allow only PDF, PNG and Word document files.  All files must pass content verification against this list of file formats, if they do not, then the result will be returned as CleanResult&#x3D;false.  Set restrictFileTypes parameter to null or empty string to disable; default is disabled. | [optional] 

### Return type

[**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

