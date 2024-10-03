private Cloudmersive.APIClient.NETCore.VirusScan.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

/// <summary>
/// Advanced Scan a file for viruses using chunked transfer encoding. Provides 360-degree content protection across various threats.
/// </summary>
/// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
/// <param name="inputFile">Input file to perform the operation on.</param>
/// <param name="fileName">Optional: specify the original file name of the file being scanned. (optional)</param>
/// <param name="allowExecutables">Set to false to block executable files. (optional)</param>
/// <param name="allowInvalidFiles">Set to false to block invalid files. (optional)</param>
/// <param name="allowScripts">Set to false to block script files. (optional)</param>
/// <param name="allowPasswordProtectedFiles">Set to false to block password protected files. (optional)</param>
/// <param name="allowMacros">Set to false to block macros. (optional)</param>
/// <param name="allowXmlExternalEntities">Set to false to block XML External Entities. (optional)</param>
/// <param name="allowInsecureDeserialization">Set to false to block Insecure Deserialization. (optional)</param>
/// <param name="allowHtml">Set to false to block HTML input. (optional)</param>
/// <param name="allowUnsafeArchives">Set to false to block unsafe archives. (optional)</param>
/// <param name="allowOleEmbeddedObject">Set to false to block OLE embedded objects. (optional)</param>
/// <param name="options">Comma-separated set of configuration options. (optional)</param>
/// <param name="restrictFileTypes">Comma-separated list of file formats to allow. (optional)</param>
/// <returns>ApiResponse of VirusScanAdvancedResult</returns>
public ApiResponse<VirusScanAdvancedResult> ScanFileAdvancedWithChunkedTransfer(Stream inputFile, string fileName = null, bool? allowExecutables = null, bool? allowInvalidFiles = null, bool? allowScripts = null, bool? allowPasswordProtectedFiles = null, bool? allowMacros = null, bool? allowXmlExternalEntities = null, bool? allowInsecureDeserialization = null, bool? allowHtml = null, bool? allowUnsafeArchives = null, bool? allowOleEmbeddedObject = null, string options = null, string restrictFileTypes = null)
{
    // Verify that the inputFile parameter is set
    if (inputFile == null)
        throw new ApiException(400, "Missing required parameter 'inputFile' when calling ScanApi->ScanFileAdvanced");

    var localVarPath = this.Configuration.BasePath + "/virus/scan/file/advanced";
    var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);

    // Set headers based on optional parameters
    if (fileName != null) localVarHeaderParams.Add("fileName", fileName);
    if (allowExecutables != null) localVarHeaderParams.Add("allowExecutables", allowExecutables.ToString());
    if (allowInvalidFiles != null) localVarHeaderParams.Add("allowInvalidFiles", allowInvalidFiles.ToString());
    if (allowScripts != null) localVarHeaderParams.Add("allowScripts", allowScripts.ToString());
    if (allowPasswordProtectedFiles != null) localVarHeaderParams.Add("allowPasswordProtectedFiles", allowPasswordProtectedFiles.ToString());
    if (allowMacros != null) localVarHeaderParams.Add("allowMacros", allowMacros.ToString());
    if (allowXmlExternalEntities != null) localVarHeaderParams.Add("allowXmlExternalEntities", allowXmlExternalEntities.ToString());
    if (allowInsecureDeserialization != null) localVarHeaderParams.Add("allowInsecureDeserialization", allowInsecureDeserialization.ToString());
    if (allowHtml != null) localVarHeaderParams.Add("allowHtml", allowHtml.ToString());
    if (allowUnsafeArchives != null) localVarHeaderParams.Add("allowUnsafeArchives", allowUnsafeArchives.ToString());
    if (allowOleEmbeddedObject != null) localVarHeaderParams.Add("allowOleEmbeddedObject", allowOleEmbeddedObject.ToString());
    if (options != null) localVarHeaderParams.Add("options", options);
    if (restrictFileTypes != null) localVarHeaderParams.Add("restrictFileTypes", restrictFileTypes);

    // Authentication (Apikey) required
    if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
    {
        localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
    }

    try
    {
        // Define the chunk size (in bytes). Adjust based on requirements.
        int chunkSize = 8192; // 8KB chunk size for example

        // Upload the file using chunked encoding
        var responseMessage = UploadFileInChunks(inputFile, chunkSize, localVarPath, localVarHeaderParams);

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new ApiException((int)responseMessage.StatusCode, $"Error calling ScanFileAdvanced: {responseMessage.ReasonPhrase}");
        }

        // Deserialize the response content using Json.NET
        var responseContent = responseMessage.Content.ReadAsStringAsync().Result;
        var virusScanAdvancedResult = JsonConvert.DeserializeObject<VirusScanAdvancedResult>(responseContent);

        return new ApiResponse<VirusScanAdvancedResult>(
            (int)responseMessage.StatusCode,
            responseMessage.Headers.ToDictionary(h => h.Key, h => string.Join(",", h.Value)),
            virusScanAdvancedResult
        );
    }
    catch (Exception ex)
    {
        throw new ApiException(500, $"Exception occurred during chunked upload: {ex.Message}");
    }
}

private HttpResponseMessage UploadFileInChunks(Stream inputFile, int chunkSize, string uploadUrl, Dictionary<string, string> headerParams)
{
    using (var httpClient = new HttpClient())
    {
        httpClient.Timeout = TimeSpan.FromMinutes(60); // Set timeout if required

        // Create a HttpRequestMessage with Transfer-Encoding set to chunked
        var requestMessage = new HttpRequestMessage(HttpMethod.Post, uploadUrl);

        // Add headers
        foreach (var header in headerParams)
        {
            requestMessage.Headers.Add(header.Key, header.Value);
        }

        // Use chunked transfer encoding
        var content = new ChunkedFileUploadContent(inputFile, chunkSize);
        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
        requestMessage.Headers.TransferEncodingChunked = true;
        requestMessage.Content = content;

        // Send the request
        return httpClient.SendAsync(requestMessage).Result;
    }
}

// ChunkedFileUploadContent class to handle chunked uploading
private class ChunkedFileUploadContent : HttpContent
{
    private readonly Stream _fileStream;
    private readonly int _chunkSize;

    public ChunkedFileUploadContent(Stream fileStream, int chunkSize)
    {
        _fileStream = fileStream;
        _chunkSize = chunkSize;
    }

    protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
    {
        byte[] buffer = new byte[_chunkSize];
        int bytesRead;
        while ((bytesRead = await _fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        {
            await stream.WriteAsync(buffer, 0, bytesRead);
            await stream.FlushAsync();
        }
    }

    protected override bool TryComputeLength(out long length)
    {
        length = -1; // We don't know the exact length in advance for chunked encoding
        return false;
    }
}