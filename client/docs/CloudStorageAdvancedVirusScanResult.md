# Cloudmersive.APIClient.NETCore.VirusScan.Model.CloudStorageAdvancedVirusScanResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation of retrieving the file, and scanning it were successfully completed, false if the file could not be downloaded from cloud storage, or if the file could not be scanned.  Note that successful completion does not mean the file is clean; for the output of the virus scanning operation itself, use the CleanResult and FoundViruses parameters. | [optional] 
**CleanResult** | **bool?** | True if the scan contained no viruses, false otherwise | [optional] 
**ContainsExecutable** | **bool?** | True if the scan contained an executable (application code), which can be a significant risk factor | [optional] 
**ContainsInvalidFile** | **bool?** | True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor | [optional] 
**ContainsScript** | **bool?** | True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor | [optional] 
**ContainsPasswordProtectedFile** | **bool?** | True if the scan contained a password protected or encrypted file, which can be a significant risk factor | [optional] 
**ContainsRestrictedFileFormat** | **bool?** | True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false | [optional] 
**ContainsMacros** | **bool?** | True if the uploaded file contains embedded Macros of other embedded threats within the document, which can be a significant risk factor | [optional] 
**VerifiedFileFormat** | **string** | For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null. | [optional] 
**FoundViruses** | [**List&lt;CloudStorageVirusFound&gt;**](CloudStorageVirusFound.md) | Array of viruses found, if any | [optional] 
**ErrorDetailedDescription** | **string** | Detailed error message if the operation was not successful | [optional] 
**FileSize** | **long?** | Size in bytes of the file that was retrieved and scanned | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

