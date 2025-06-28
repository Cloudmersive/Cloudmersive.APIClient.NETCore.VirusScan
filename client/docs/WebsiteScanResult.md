# Cloudmersive.APIClient.NETCore.VirusScan.Model.WebsiteScanResult
Result of running a website scan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CleanResult** | **bool** | True if the scan contained no threats, false otherwise | [optional] 
**WebsiteThreatType** | **string** | Type of threat returned; can be None, Malware, ForcedDownload or Phishing | [optional] 
**FoundViruses** | [**List&lt;VirusFound&gt;**](VirusFound.md) | Array of viruses found, if any | [optional] 
**WebsiteHttpResponseCode** | **int** | The remote server URL HTTP reasponse code; useful for debugging issues with scanning; typically if the remote server returns a 200 or 300-series code this means a successful response, while a 400 or 500 series code would represent an error returned from the remote server for the provided URL. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

