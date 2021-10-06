FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Cart.User.API/Cart.User.API.csproj", "Cart.User.API/"]
RUN dotnet restore "Cart.User.API/Cart.User.API.csproj"
COPY . .
WORKDIR "/src/Cart.User.API"
RUN dotnet build "Cart.User.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cart.User.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cart.User.API.dll"]
