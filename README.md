# Observatory

![GitHub issues](https://img.shields.io/github/issues/dayvidwhy/observatory)
![GitHub pull requests](https://img.shields.io/github/issues-pr/dayvidwhy/observatory)
![GitHub](https://img.shields.io/github/license/dayvidwhy/observatory)

Log aggregator.

## Prerequisites

Before you begin, ensure you have the following installed:
- Docker
- Git

## Getting Started

The development environment is provided by containers.

```bash
git clone git@github.com:dayvidwhy/observatory.git
cd observatory
docker-compose up --build
docker exec -it observatory-observatory-1 bash
cd Observatory
dotnet build
```

Then run the project

```bash
dotnet run

# Or in watch mode
dotnet watch run
```

Server will be available at `localhost:5124` on your machine.

## VSCode Integration
For an optimized development experience, attach VSCode to the running container:

1. Use the command palette (Ctrl+Shift+P or Cmd+Shift+P on Mac) and select: `>Dev Containers: Attach to Running Container...`
2. Choose /observatory-observatory-1 from the list.
