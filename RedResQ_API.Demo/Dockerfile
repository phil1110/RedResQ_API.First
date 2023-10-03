FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["RedResQ_API.Demo/RedResQ_API.Demo.csproj", "RedResQ_API.Demo/"]
RUN dotnet restore "RedResQ_API.Demo/RedResQ_API.Demo.csproj"
COPY . .
WORKDIR "/src/RedResQ_API.Demo"
RUN dotnet build "RedResQ_API.Demo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RedResQ_API.Demo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RedResQ_API.Demo.dll"]
