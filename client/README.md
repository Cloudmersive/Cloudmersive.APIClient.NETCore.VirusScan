# Cloudmersive.APIClient.NETCore.VirusScan - the C# library for the virusapi

The Cloudmersive Virus Scan API lets you scan files and content for viruses and identify security issues with content.

This C# SDK is for the [Cloudmersive Virus Scan API](https://www.cloudmersive.com/virus-api):

- API version: v1
- SDK version: 2.1.3
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ScanApi* | [**ScanFile**](docs/ScanApi.md#scanfile) | **POST** /virus/scan/file | Scan a file for viruses
*ScanApi* | [**ScanFileAdvanced**](docs/ScanApi.md#scanfileadvanced) | **POST** /virus/scan/file/advanced | Advanced Scan a file for viruses
*ScanApi* | [**ScanWebsite**](docs/ScanApi.md#scanwebsite) | **POST** /virus/scan/website | Scan a website for malicious content and threats
*ScanCloudStorageApi* | [**ScanCloudStorageScanAwsS3File**](docs/ScanCloudStorageApi.md#scancloudstoragescanawss3file) | **POST** /virus/scan/cloud-storage/aws-s3/single | Scan an AWS S3 file for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanAwsS3FileAdvanced**](docs/ScanCloudStorageApi.md#scancloudstoragescanawss3fileadvanced) | **POST** /virus/scan/cloud-storage/aws-s3/single/advanced | Advanced Scan an AWS S3 file for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanAzureBlob**](docs/ScanCloudStorageApi.md#scancloudstoragescanazureblob) | **POST** /virus/scan/cloud-storage/azure-blob/single | Scan an Azure Blob for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanAzureBlobAdvanced**](docs/ScanCloudStorageApi.md#scancloudstoragescanazureblobadvanced) | **POST** /virus/scan/cloud-storage/azure-blob/single/advanced | Advanced Scan an Azure Blob for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanGcpStorageFile**](docs/ScanCloudStorageApi.md#scancloudstoragescangcpstoragefile) | **POST** /virus/scan/cloud-storage/gcp-storage/single | Scan an Google Cloud Platform (GCP) Storage file for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanGcpStorageFileAdvanced**](docs/ScanCloudStorageApi.md#scancloudstoragescangcpstoragefileadvanced) | **POST** /virus/scan/cloud-storage/gcp-storage/single/advanced | Advanced Scan an Google Cloud Platform (GCP) Storage file for viruses
*ScanCloudStorageApi* | [**ScanCloudStorageScanSharePointOnlineFile**](docs/ScanCloudStorageApi.md#scancloudstoragescansharepointonlinefile) | **POST** /virus/scan/cloud-storage/sharepoint-online/site/single | Virus Scan a file in a SharePoint Online Site Drive
*ScanCloudStorageApi* | [**ScanCloudStorageScanSharePointOnlineFileAdvanced**](docs/ScanCloudStorageApi.md#scancloudstoragescansharepointonlinefileadvanced) | **POST** /virus/scan/cloud-storage/sharepoint-online/site/advanced | Advanced Virus Scan a file in a SharePoint Online Site Drive


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AdditionalAdvancedScanInformation](docs/AdditionalAdvancedScanInformation.md)
 - [Model.CloudStorageAdvancedVirusScanResult](docs/CloudStorageAdvancedVirusScanResult.md)
 - [Model.CloudStorageVirusFound](docs/CloudStorageVirusFound.md)
 - [Model.CloudStorageVirusScanResult](docs/CloudStorageVirusScanResult.md)
 - [Model.VirusFound](docs/VirusFound.md)
 - [Model.VirusScanAdvancedResult](docs/VirusScanAdvancedResult.md)
 - [Model.VirusScanResult](docs/VirusScanResult.md)
 - [Model.WebsiteScanRequest](docs/WebsiteScanRequest.md)
 - [Model.WebsiteScanResult](docs/WebsiteScanResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

