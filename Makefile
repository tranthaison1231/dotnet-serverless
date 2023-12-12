build: 
	dotnet publish -c Release --self-contained false -r linux-x64 -o bin/api
	zip -r bin/api.zip bin/api
