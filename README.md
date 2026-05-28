# Dotnet Core REST API

[![License](https://img.shields.io/github/license/pauloprsdesouza/dotnet-core-rest-api)](./LICENSE)
[![Last Commit](https://img.shields.io/github/last-commit/pauloprsdesouza/dotnet-core-rest-api)](https://github.com/pauloprsdesouza/dotnet-core-rest-api/commits/main)
[![Top Language](https://img.shields.io/github/languages/top/pauloprsdesouza/dotnet-core-rest-api)](https://github.com/pauloprsdesouza/dotnet-core-rest-api)

Reference implementation of a production-style .NET REST API with clean layering and maintainable project organization.

## Tech Stack
- C# / .NET
- ASP.NET Core Web API
- Entity Framework patterns

## Architecture
- `src/` contains the API solution and application modules.
- Request handling, domain logic, and infrastructure concerns are separated for clarity.
- `http/` contains request samples for local API validation.

## Quick Start
1. Install a compatible .NET SDK.
2. Restore dependencies in `src/`.
3. Build and run the API project.
4. Open Swagger (if enabled) from local app output.

## Validation
- Build the solution and run tests (if present in your local setup).
- Use files under `http/` to validate endpoints.

## Contributing
See `CONTRIBUTING.md` for contribution and PR guidelines.