# Cloudmersive.APIClient.NETCore.VirusScan.Model.ScanCloudStorageJobStatusResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | Tru eif the operation to check the status of the job was successful, false otherwise | [optional] 
**AsyncJobStatus** | **string** | Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED | [optional] 
**AsyncJobID** | **string** | Job ID of the async batch job | [optional] 
**Result** | [**CloudStorageAdvancedVirusScanResult**](CloudStorageAdvancedVirusScanResult.md) | Output scan result, if applicable | [optional] 
**ErrorMessage** | **string** | Error message (if any) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
