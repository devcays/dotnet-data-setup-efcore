# Case overview

This is a take-home project designed to let you demonstrate your knowledge on .NET C# and databases as well as your
abilities to reason about design choices.

The case scenario is sourced from real-life client work, and the tasks presented here are common to green-field projects
and early contributors.

**Note: remember there's not a single, best way to solve this case. The most important aspect is your reasoning.**

### Requirements

This case requires you to have installed:

- A .NET C# capable editor or IDE, such as Visual Studio, Visual Studio Code, or JetBrains Rider.
- .NET6 SDK installed.
- Docker desktop or MS-SQL Server installed (See instructions at the bottom of this page).

## The scenario

Imagine you're starting at a new client engagement. The the client has asked you to set up their initial database.  
The client have existing domain entities that outlines which data the client would like to have persisted.

The entity models make up a small user-driven blog, where users can publish posts and write comments on the posts.

### Your task

#### 1. Setting up the database DbContext class.

Set up the [`AppDbContext`](src/Persistence/AppDbContext.cs) class with entities from the [Domain project](src/Domain).
The `AppDbContext` should be used to create migrations as well as querying and manipulating `User`, `Post`,
and `Comment` data.

#### 2. Creating an initial migration

Create a migration file named `Inital` which creates the `Users`, `Posts`, and `Comments` tables.  
Remember to read the entities' property restrictions have those included in the migration, e.g. a User's username cannot
be empty and 50 characters at max.

The inital migration should make the following tables structures:

<table>
    <tr><td colspan="2">Users table</td></tr>
    <tr>
        <td>Id</td>
        <td>Username</td>
    </tr>
    <tr>
        <td>uniqueidentifier</td>
        <td>not null, varchar(50)</td>
    </tr>
</table>  


<table>
    <tr><td colspan="5">Posts table</td></tr>
    <tr>
        <td>Id</td>
        <td>Title</td>
        <td>Content</td>
        <td>Published</td>
        <td>UserId</td>
    </tr>
    <tr>
        <td>uniqueidentifier</td>
        <td>not null, varchar(150)</td>
        <td>varchar(max)</td>
        <td>null, datetimeoffset</td>
        <td>not null, uniqueidentifier</td>
    </tr>
</table>  


<table>
    <tr><td colspan="5">Comments table</td></tr>
    <tr>
        <td>Id</td>
        <td>Text</td>
        <td>Published</td>
        <td>AuthorId</td>
        <td>PostId</td>
    </tr>
    <tr>
        <td>uniqueidentifier</td>
        <td>not null, varchar(2000)</td>
        <td>not null, datetimeoffset</td>
        <td>not null, uniqueidentifier</td>
        <td>not null, uniqueidentifier</td>
    </tr>
</table>

#### 3. Scripting the migration

Based on the generated migration in step 2, create an idempotent SQL script that can be executed against an MS-SQL
server.  
Run the script against your database. Scroll down to see an example of setting up a MS-SQL server using docker.

#### 4. Implement the repository

Data should only be accessed through a repository. Implement the repository methods
in [`EfUserRepository`](src/Persistence/Repositories/EfUserRepository.cs).

## Test project

The test project is only here for your convenience. There's a single
class, [`RapidPrototyping`](tests/DatabaseSetupEfCore.Tests/RapidPrototyping.cs), that you can use to test ideas.

## EF Core Commands

No startup project required.

Run your EF Core commands against the Persistence project (./src/Persistence.csproj). There's
an [`AppContextDesignTimeDbFactory.cs`](src/Persistence/AppContextDesignTimeDbFactory.cs) class that picks up the
connection string from [`appsettings.json`](src/Persistence/appsettings.json).

## Additional information

Feel free to make changes to the domain entities as you see fit. These changes may be to increase code quality, improve
developer experience, or for other great reasons.  
Most importantly, do remember your reasoning for performing changes to the existing entity models.

### SQL Script

There's a convenience [SQL script located at scripts/helper-inserts.sql](scripts/helper-inserts.sql) that inserts a few
rows into the 3 tables.   
Once you've completed Task 3, creating the migration script and applied it to your database, you can run this script.  
Note that you're not required to use this script.

### Docker: MS-SQL

You can create a docker MS SQL container by running the command below.  
Run `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=docker12_*" -p 1433:1433 -d --name devcays-mssql mcr.microsoft.com/mssql/server:2019-latest`

You can then log onto the MS-SQL server using  
Host=`localhost`  
Port=`1433`  
Username=`SA`  
Password=`docker12_*`  

## LICENSE
See [license file](LICENSE).