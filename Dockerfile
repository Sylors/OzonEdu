FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /src

COPY ["src/OzonEdu.Merchandise/OzonEdu.Merchandise.csproj", "src/OzonEdu.Merchandise/"]
RUN dotnet restore "src/OzonEdu.Merchandise/OzonEdu.Merchandise.csproj"

COPY . .

WORKDIR "/src/src/OzonEdu.Merchandise"

RUN dotnet build "OzonEdu.Merchandise.csproj" -c Release -o /app/build
FROM build as publish

RUN dotnet publish "OzonEdu.Merchandise.csproj" -c Release -o /app/publish
COPY "entrypoint.sh" "/app/publish/."

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

WORKDIR /app
EXPOSE 80
FROM runtime as finall
WORKDIR /app

COPY --from=publish  /app/publish .

RUN chmod +x entrypoint.sh
CMD /bin/bash entrypoint.sh
