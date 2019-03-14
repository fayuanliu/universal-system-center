FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["UniversalSystemCenter.Auth/UniversalSystemCenter.Auth.csproj", "UniversalSystemCenter.Auth/"]
RUN dotnet restore "UniversalSystemCenter.Auth/UniversalSystemCenter.Auth.csproj"
COPY . .
WORKDIR "/src/UniversalSystemCenter.Auth"
RUN dotnet build "UniversalSystemCenter.Auth.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UniversalSystemCenter.Auth.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UniversalSystemCenter.Auth.dll"]