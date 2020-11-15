#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Address_book.csproj", ""]
RUN dotnet restore "./Address_book.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Address_book.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Address_book.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Address_book.dll"]