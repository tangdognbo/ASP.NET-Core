#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["core.webapi/core.webapi.csproj", "core.webapi/"]
RUN dotnet restore "core.webapi/core.webapi.csproj"
COPY . .
WORKDIR "/src/core.webapi"
RUN dotnet build "core.webapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "core.webapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "core.webapi.dll"]