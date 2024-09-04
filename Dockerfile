FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MagicVila.csproj", "./"]
RUN dotnet restore "MagicVila.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "MagicVila.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MagicVila.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MagicVila.dll"]
