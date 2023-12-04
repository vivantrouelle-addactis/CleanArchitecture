#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CleanArchitecture.Presentation.WebApi/CleanArchitecture.Presentation.WebApi.csproj", "CleanArchitecture.Presentation.WebApi/"]
COPY ["CleanArchitecture.Core.Application/CleanArchitecture.Core.Application.csproj", "CleanArchitecture.Core.Application/"]
COPY ["CleanArchitecture.Core.Domain/CleanArchitecture.Core.Domain.csproj", "CleanArchitecture.Core.Domain/"]
COPY ["CleanArchitecture.Infrastructure.Persistence/CleanArchitecture.Infrastructure.Persistence.csproj", "CleanArchitecture.Infrastructure.Persistence/"]
RUN dotnet restore "CleanArchitecture.Presentation.WebApi/CleanArchitecture.Presentation.WebApi.csproj"
COPY . .
WORKDIR "/src/CleanArchitecture.Presentation.WebApi"
RUN dotnet build "CleanArchitecture.Presentation.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CleanArchitecture.Presentation.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.Presentation.WebApi.dll"]