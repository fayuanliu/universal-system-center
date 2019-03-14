FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["UniversalSystemCenter/UniversalSystemCenter.csproj", "UniversalSystemCenter/"]
RUN dotnet restore "UniversalSystemCenter/UniversalSystemCenter.csproj"
COPY . .
WORKDIR "/src/UniversalSystemCenter"
RUN dotnet build "UniversalSystemCenter.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UniversalSystemCenter.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UniversalSystemCenter.dll"]