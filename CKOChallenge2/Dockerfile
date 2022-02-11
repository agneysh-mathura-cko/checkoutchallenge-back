FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CKOChallenge2/CKOChallenge2.csproj", "CKOChallenge2/"]
RUN dotnet restore "CKOChallenge2/CKOChallenge2.csproj"
COPY . .
WORKDIR "/src/CKOChallenge2"
RUN dotnet build "CKOChallenge2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CKOChallenge2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CKOChallenge2.dll"]
