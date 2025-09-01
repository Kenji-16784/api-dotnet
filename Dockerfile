# Imagen base para compilar
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app

# Imagen base para ejecutar
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .

# Puerto que Render asigna dinámicamente
ENV ASPNETCORE_URLS=http://+:10000

# Ejecutar la API
CMD ["dotnet", "api-dotnet.dll"]
