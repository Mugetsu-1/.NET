# Lab 10 - ASP.NET Core Identity - Database Setup

Unit 8 (Securing ASP.NET Core Application): ASP.NET Core Identity + EF Core + SQL Server.

Routes: `/Account/Register`, `/Account/Login`, `/Account/Logout`, `/Home/Secured` (`[Authorize]`).

## 1. Prereq
- SQL Server `SAUGAT\SQLEXPRESS` running
- .NET 10 SDK (`net10.0`)
- Packages already referenced in `Lab10.csproj` (all `10.0.12`):
  `Microsoft.AspNetCore.Identity.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer`, `Microsoft.EntityFrameworkCore.Design`, `Microsoft.EntityFrameworkCore.Tools`
- `dotnet-ef` CLI - only needed to re-generate the migration:
```
dotnet tool install --global dotnet-ef --version 10.0.12
```

## 2. Connection string
`appsettings.json` -> `ConnectionStrings:DefaultConnection`:
```
Server=SAUGAT\\SQLEXPRESS;Database=IdentityUserDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True
```
Note: `\\` in JSON = single `\` in the real server name.

## 3. Create the database
The migration is already generated in `Migrations/` (`20260918192145_InitialCreate`), so just run:
```
dotnet ef database update
```
If the `Migrations` folder is ever deleted, re-create it first:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
`InitialCreate` creates 8 tables: `AspNetUsers`, `AspNetRoles`, `AspNetUserClaims`, `AspNetRoleClaims`, `AspNetUserLogins`, `AspNetUserRoles`, `AspNetUserTokens`, `__EFMigrationsHistory`.

## 4. Run
```
dotnet run
```
or F5 in Visual Studio -> `https://localhost:7215` (http `http://localhost:5205`).

## 5. Test walkthrough (verified end-to-end)
| # | Do this | What you get |
| :-- | :-- | :-- |
| 1 | Open `/` | "You are not logged in..." + Register / Login buttons |
| 2 | Open `/Home/Secured` | 302 redirect to `/Account/Login?ReturnUrl=%2FHome%2FSecured` (blocked by `[Authorize]`) |
| 3 | Register: UserName `SauTest`, Email `sautest@test.com`, Password `Test@123`, ConfirmPassword `Test@123` | 302 redirect to `/Account/Login` |
| 4 | Login with that email + password | 302 redirect to `/`, nav bar shows `Logout (SauTest)` |
| 5 | Open `/Home/Secured` | `Hello SauTest` + a Logout button |
| 6 | Click Logout | 302 back to `/`, and `/Home/Secured` is protected again |
| 7 | Open `/Account/Login?returnUrl=https://evil.example.com` and log in | Redirected to `/` (the local-URL check in `AccountController` blocks the open redirect) |

Check the row that was created:
```sql
USE IdentityUserDB;
SELECT UserName, Email, LEN(PasswordHash) AS HashLength FROM dbo.AspNetUsers;
```
`PasswordHash` is a stored hash (84 chars), the password itself is never saved. Delete the test user when you are done:
```sql
DELETE FROM dbo.AspNetUsers WHERE Email = 'sautest@test.com';
```

## 6. Password rules (default Identity policy)
Errors shown by the Register form (verified live):
- Passwords must be at least 6 characters.
- Passwords must have at least one uppercase ('A'-'Z').
- Passwords must have at least one lowercase ('a'-'z').
- Passwords must have at least one digit ('0'-'9').
- Passwords must have at least one non alphanumeric character.
- `Password and Confirm Password do not match` (from `[Compare]` in `Models/Register.cs`)

So `Test@123` works, `abc` does not.

## If it fails
- Keep `TrustServerCertificate=True` (required by EF Core 10)
- `Login Failed: Invalid Email or password` -> the user must be registered first (`/Account/Register`), and the DB must exist
- `dotnet ef` not recognized -> install the tool (step 1) or run `dotnet tool restore`
- Deleting rows with `sqlcmd` needs `-I` (`SET QUOTED_IDENTIFIER ON`), otherwise you get "DELETE failed because the following SET options have incorrect settings: 'QUOTED_IDENTIFIER'"
- Database already exists with an older schema -> drop `IdentityUserDB` in SSMS and run `dotnet ef database update` again
