# 
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy source code and publish
COPY . ./
RUN dotnet publish -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /app

# Copy published files from build stage
COPY --from=build /app/out .

# Entry point to run the app
ENTRYPOINT ["dotnet", "OllamaClient.dll"]
