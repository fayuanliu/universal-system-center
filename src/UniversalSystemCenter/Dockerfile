FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["UniversalSystemCenter/UniversalSystemCenter.Api.csproj", "UniversalSystemCenter/"]
COPY ["UniversalSystemCenter.Services/UniversalSystemCenter.Services.csproj", "UniversalSystemCenter.Services/"]
COPY ["UniversalSystemCenter.Datas/UniversalSystemCenter.Datas.csproj", "UniversalSystemCenter.Datas/"]
COPY ["UniversalSystemCenter.Domains/UniversalSystemCenter.Domains.csproj", "UniversalSystemCenter.Domains/"]
COPY ["UniversalSystemCenter.Core/UniversalSystemCenter.Core.csproj", "UniversalSystemCenter.Core/"]
RUN dotnet restore "UniversalSystemCenter/UniversalSystemCenter.Api.csproj"
COPY . .
WORKDIR "/src/UniversalSystemCenter"
RUN dotnet build "UniversalSystemCenter.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UniversalSystemCenter.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UniversalSystemCenter.Api.dll"]