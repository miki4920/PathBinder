
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8000

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["PathBinder/PathBinder.csproj", "PathBinder/"]
RUN dotnet restore "PathBinder/PathBinder.csproj"
COPY . .
WORKDIR "/src/PathBinder"
RUN dotnet build "PathBinder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PathBinder.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PathBinder.dll"]