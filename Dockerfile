FROM mcr.microsoft.com/dotnet/runtime:10.0
WORKDIR /app
COPY out/ .
ENTRYPOINT ["dotnet", "MyApp.dll"]