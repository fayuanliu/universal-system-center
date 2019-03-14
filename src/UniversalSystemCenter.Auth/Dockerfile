FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UniversalSystemCenter.Auth.dll"]