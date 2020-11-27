FROM mcr.microsoft.com/dotnet/core/sdk

RUN mkdir app
COPY . ./app

RUN dotnet build ./app/Demo4.csproj

CMD dotnet ./app/bin/Debug/netcoreapp3.1/Demo4.dll