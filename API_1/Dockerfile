FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Datum.Desafio.Api_1/Datum.Desafio.Api_1.csproj", "Datum.Desafio.Api_1/"]
RUN dotnet restore "Datum.Desafio.Api_1/Datum.Desafio.Api_1.csproj"
COPY . .
WORKDIR "/src/Datum.Desafio.Api_1"
RUN dotnet build "Datum.Desafio.Api_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Datum.Desafio.Api_1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Datum.Desafio.Api_1.dll"]