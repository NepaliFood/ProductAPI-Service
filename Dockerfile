
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.csproj ./
RUN dotnet restore
COPY . .
WORKDIR "/src/ProductAPI/ProductAPI"
RUN dotnet build "ProductAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProductAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProductAPI.dll"]