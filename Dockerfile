FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DpsCalculator/DpsCalculator.csproj", "DpsCalculator/"]
RUN dotnet restore "DpsCalculator/DpsCalculator.csproj"
COPY . .
WORKDIR "/src/DpsCalculator"
RUN dotnet build "DpsCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DpsCalculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DpsCalculator.dll"]
