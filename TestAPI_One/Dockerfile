#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestAPI_One/TestAPI_One.csproj", "TestAPI_One/"]
RUN dotnet restore "TestAPI_One/TestAPI_One.csproj"
COPY . .
WORKDIR "/src/TestAPI_One"
RUN dotnet build "TestAPI_One.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestAPI_One.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestAPI_One.dll"]