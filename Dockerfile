FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY src/PetWorld.Web/bin/Release/net10.0/publish/ .
ENTRYPOINT ["dotnet", "PetWorld.Web.dll"]