#DotNet MVC

##Scaffolding

###Gerando os controllers e view com base nos models
>- dotnet aspnet-codegenerator controller -name PessoaController -m Pessoa -dc MyContext --relativeFolderPath Controllers --useDefaultLayout

[ASP .NET Core - Scaffolding : criando Controllers e Views via linha de comando] (http://www.macoratti.net/17/12/aspcore_ctrlcmd2.htm)

##Migrations

###Gerando o banco de dados e as tabelas com base no model
>- dotnet ef dbcontext scaffold "Data Source=db.sqlite" Microsoft.EntityFrameworkCore.Sqlite -o Models -f -c MyContext
>- dotnet ef migrations add InitialCreate
>- dotnet ef database update