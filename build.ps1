Remove-Item –path ./client –recurse
& java -jar swagger-codegen-cli.jar generate -i https://api.cloudmersive.com/swagger/api/convert -l csharp -o client -c packageconfig.json
#(Get-Content ./client/src/api/ConvertDocumentApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertDocumentApi.js
#(Get-Content ./client/src/api/ConvertWebApi.js).replace('var returnType = Object;', "var returnType = 'Blob';") | Set-Content ./client/src/api/ConvertWebApi.js
#& npm build ./client
& dotnet build ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj -c Release
& dotnet pack ./client/src/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert/Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj -c Release