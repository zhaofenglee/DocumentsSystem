FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["JS.DocumentsSystem/JS.DocumentsSystem.csproj", "JS.DocumentsSystem/"]
RUN dotnet restore "JS.DocumentsSystem/JS.DocumentsSystem.csproj"
COPY . .
WORKDIR "/src/JS.DocumentsSystem"
RUN dotnet build "JS.DocumentsSystem.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "JS.DocumentsSystem.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JS.DocumentsSystem.dll"]
