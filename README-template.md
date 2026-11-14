# CleanArchitecture

The project was generated using the [Clean.Architecture.Solution.Template](caRepositoryUrl) version caPackageVersion.

## Build

Run `dotnet build` to build the solution.

## Run

To run the application:

Using the [Aspire CLI](https://aspire.dev/get-started/install-cli/) (recommended):

```bash
aspire run
```

Or using the .NET CLI:

```bash
dotnet run --project .\src\AppHost
```

The Aspire dashboard will open automatically, showing the application URLs and logs.

## Development Credentials

No passwords are stored in the repository.

- **Database (Aspire):** the AppHost creates a random Postgres password parameter and stores it in the AppHost user-secrets. Nothing to configure.
- **Database (running `src/Web` without Aspire):** the connection string in `appsettings.json` has no password. Supply it as a secret:

  ```bash
  dotnet user-secrets set "ConnectionStrings:CleanArchitectureDb" "Server=127.0.0.1;Port=5432;Database=CleanArchitectureDb;Username=admin;Password=<your-password>" --project src/Web
  ```

  or set the `ConnectionStrings__CleanArchitectureDb` environment variable.
- **Seeded administrator (Development only):** `administrator@localhost` is created only when a password is configured. Without one, seeding skips the account and logs a warning (register through the API instead).

  ```bash
  dotnet user-secrets set "Seed:AdministratorPassword" "<a-strong-password>" --project src/Web
  ```

  or set the `Seed__AdministratorPassword` environment variable (also required by the acceptance tests, which log in as this user).

## Code Styles & Formatting

The template includes [EditorConfig](https://editorconfig.org/) support to help maintain consistent coding styles for multiple developers working on the same project across various editors and IDEs. The **.editorconfig** file defines the coding styles applicable to this solution.

## Code Scaffolding

The template includes support to scaffold new commands and queries.

Start in the `.\src\Application\` folder.

Create a new command:

```
dotnet new ca-usecase --name CreateTodoList --feature-name TodoLists --usecase-type command --return-type int
```

Create a new query:

```
dotnet new ca-usecase -n GetTodos -fn TodoLists -ut query -rt TodosVm
```

If you encounter the error *"No templates or subcommands found matching: 'ca-usecase'."*, install the template and try again:

```bash
dotnet new install Clean.Architecture.Solution.Template::caPackageVersion
```

## Test

The solution contains unit, integration, and functional tests.

To run the tests:
```bash
dotnet test
```

## Architectural Decisions

Key design decisions are documented as [Architecture Decision Records](docs/decisions/).

## Help
To learn more about the template go to the [project website](caDocsUrl). Here you can find additional guidance, request new features, report a bug, and discuss the template with other users.