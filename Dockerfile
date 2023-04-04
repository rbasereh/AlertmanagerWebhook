#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /AlertmanagerWebhook

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /AlertmanagerWebhook
COPY --from=build-env /AlertmanagerWebhook/out .
ENTRYPOINT ["dotnet", "AlertmanagerWebhook.dll"]