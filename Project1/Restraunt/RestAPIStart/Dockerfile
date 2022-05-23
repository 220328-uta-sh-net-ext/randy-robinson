FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS build
WORKDIR /app

COPY . .

RUN dotnet publish "RestAPIStart.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "RestAPIStart.dll"]

EXPOSE 80
EXPOSE 443