# build stage
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /src
COPY Demo5.csproj .
RUN dotnet restore Demo5.csproj
COPY . .
RUN dotnet build Demo5.csproj -c Release
#Publish
FROM build as publish
RUN dotnet publish Demo5.csproj -c Release -o /app/publish

# Final Stage
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine as final
USER 1000
EXPOSE 5000
ENV ASPNETCORE_URLS http://*:5000

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT dotnet ./Demo5.dll