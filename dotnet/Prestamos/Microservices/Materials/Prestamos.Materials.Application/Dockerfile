FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy Everything.
COPY ../ ./

#Restore as distinct layers.
RUN dotnet restore ./Prestamos.Materials.Application/Prestamos.Materials.Application.csproj

#Build and publish release.
RUN dotnet publish ./Prestamos.Materials.Application/Prestamos.Materials.Application.csproj -c Release -o out

#Build runtime image.
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Prestamos.Materials.Application.dll"]