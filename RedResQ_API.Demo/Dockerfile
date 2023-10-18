FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["RedResQ.Demo/RedResQ.Demo.csproj", "RedResQ.Demo/"]
RUN dotnet restore "RedResQ.Demo/RedResQ.Demo.csproj"
COPY . .
WORKDIR "/src/RedResQ.Demo"
RUN dotnet build "RedResQ.Demo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RedResQ.Demo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RedResQ.Demo.dll"]
