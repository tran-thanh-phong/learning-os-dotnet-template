namespace CleanArchitecture.Web.AcceptanceTests;

internal static class AdministratorCredentials
{
    public const string Email = "administrator@localhost";

    // Must match Seed:AdministratorPassword consumed by the Web app; Aspire forwards the test process environment.
    public static string Password =>
        Environment.GetEnvironmentVariable("Seed__AdministratorPassword")
        ?? throw new InvalidOperationException("Set the Seed__AdministratorPassword environment variable before running the acceptance tests.");
}
