#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SisAgenda.Api/SisAgenda.Api.csproj", "SisAgenda.Api/"]
RUN dotnet restore "SisAgenda.Api/SisAgenda.Api.csproj"
COPY . .
WORKDIR "/src/SisAgenda.Api"
RUN dotnet build "SisAgenda.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SisAgenda.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SisAgenda.Api.dll"]