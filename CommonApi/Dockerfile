# Stage base (runtime Azure Functions)
FROM mcr.microsoft.com/azure-functions/dotnet-isolated:4-dotnet-isolated9.0 AS base
WORKDIR /home/site/wwwroot
EXPOSE 7071

# Stage build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release

# Permitir pasar proxy desde docker build
ARG HTTP_PROXY
ARG HTTPS_PROXY
ENV HTTP_PROXY=${HTTP_PROXY}
ENV HTTPS_PROXY=${HTTPS_PROXY}

WORKDIR /src

# Ajusta la ruta del csproj según el contexto de build: si ejecutas docker build desde CommonApi, esto está bien.
# Si ejecutas desde la raíz de la solución, cambia a ["CommonApi/CommonApi.csproj","./"]
COPY ["CommonApi.csproj", "./"]

# Si tienes nuget.config para feeds privados:
# COPY ["nuget.config", "./"]

RUN dotnet restore "./CommonApi.csproj"

COPY . .
WORKDIR "/src"
RUN dotnet build "./CommonApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CommonApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /home/site/wwwroot
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/home/site/wwwroot \
    AzureFunctionsJobHost__Logging__Console__IsEnabled=true