FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Until this makes it into the current stable we should use this nightly as it'll tell us 
# where errors are.
RUN dotnet tool install -tool-path /app/tools dotnet-format --version 3.1.36303 --add-source https://dotnet.myget.org/F/format/api/v3/index.json 

# Copy everything else and build
COPY . ./
RUN dotnet format --dry-run --check
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "aspnetapp.dll"]