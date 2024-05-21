FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app

COPY . .

EXPOSE 5124

CMD ["tail", "-f", "/dev/null"]