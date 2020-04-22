# Cloudmersive.APIClient.NETCore.VirusScan.Model.VirusScanAdvancedResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CleanResult** | **bool?** | True if the scan contained no viruses, false otherwise | [optional] 
**ContainsExecutable** | **bool?** | True if the scan contained an executable (application code), which can be a significant risk factor | [optional] 
**ContainsInvalidFile** | **bool?** | True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor | [optional] 
**ContainsScript** | **bool?** | True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor | [optional] 
**ContainsPasswordProtectedFile** | **bool?** | True if the scan contained a password protected or encrypted file, which can be a significant risk factor | [optional] 
**ContainsRestrictedFileFormat** | **bool?** | True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false | [optional] 
**VerifiedFileFormat** | **string** | For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null. | [optional] 
**FoundViruses** | [**List&lt;VirusFound&gt;**](VirusFound.md) | Array of viruses found, if any | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

