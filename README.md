# EF Core: Doctor Who

## **Before you start**

- Use .NET Core 3.0+
- Do one task at a time. Run tests, many tests!
- Follow GIT best practices you learned to push your code.
- This exercise depends on [SQL: Doctor Who](https://www.notion.so/SQL-Doctor-Who-90e72eb5ba544847a9c2bd7a90dff9ca) exercise.

## Requirements

1. Create a DB named `DoctorWhoCore` (using SSMS).
2. Create a console application project named `DoctorWho`.
3. Create a library project named `DoctorWho.Db` and reference it from `DoctorWho` project.
4. Create `DoctorWhoCoreDbContext` and add it to `DoctorWho.Db`
5. Create the data models for **Doctor Who** tables with all necessary keys, relationships, constraints and navigations. These models should exist in `DoctorWho.Db`
6. Write migrations to create the previous tables. Migrations should exist in `DoctorWho.Db`.
7. Seed the tables with at least 5 records in each.
8. Write migrations to create the `functions`, `sprocs` and `views` from previous exercise.
9. Write methods in EF in the console app to execute the `functions`, `sprocs` and `views` from previous exercise.
10. Write `Create/Update/Delete` methods for companions, enemies, doctors, authors, and episodes.
11. Write methods to:
    1. `AddEnemyToEpisode`: Add an enemy to an episode.
    2. `AddCompanionToEpisode`: Add a companion to an episode.
    3. `GetAllDoctors`: Get all available doctors.
    4. `GetEnemyById`: Get an enemy by ID.
    5. `GetCompanionById`: Get a companion by ID.
12. Create a repository class for each entity and call it: `{EntityName}Repository.cs`, and move related methods from the previous requirements to the right repository. These repositories should exist in `Repositories` folder `DoctorWho.Db`
