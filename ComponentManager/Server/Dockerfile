#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ComponentManager/Server/ComponentManager.Server.csproj", "ComponentManager/Server/"]
COPY ["ComponentManager/Shared/ComponentManager.Shared.csproj", "ComponentManager/Shared/"]
COPY ["ComponentManager/Client/ComponentManager.Client.csproj", "ComponentManager/Client/"]
RUN dotnet restore "ComponentManager/Server/ComponentManager.Server.csproj"
COPY . .
WORKDIR "/src/ComponentManager/Server"
RUN dotnet build "ComponentManager.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ComponentManager.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ComponentManager.Server.dll"]