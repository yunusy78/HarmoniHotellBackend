FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WEB/WEB.csproj", "WEB/"]
RUN dotnet restore "WEB/WEB.csproj"
COPY . .
WORKDIR "/src/WEB"
RUN dotnet build "WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WEB.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WEB.dll"]
