#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ThePhoneBook.FrontendMvc/ThePhoneBook.FrontendMvc.csproj", "ThePhoneBook.FrontendMvc/"]
RUN dotnet restore "ThePhoneBook.FrontendMvc/ThePhoneBook.FrontendMvc.csproj"
COPY . .
WORKDIR "/src/ThePhoneBook.FrontendMvc"
RUN dotnet build "ThePhoneBook.FrontendMvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ThePhoneBook.FrontendMvc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ThePhoneBook.FrontendMvc.dll"]