# DotNet MVC

## Scaffolding

### Gerando os controllers e view com base nos models
>- dotnet aspnet-codegenerator controller -name ContatoController -m Contato -dc PessoaContext --relativeFolderPath Controllers --useDefaultLayout 

## Migrations

### Gerando o banco de dados e as tabelas com base no model

>- dotnet ef dbcontext scaffold "Data Source=db.sqlite" Microsoft.EntityFrameworkCore.Sqlite -o Models --context-dir Context -f -c PessoaContext 
>- dotnet ef dbcontext scaffold "server=127.0.0.1;port=3306;database=marcio_paro;uid=root" Pomelo.EntityFrameworkCore.MySql -o Models --context-dir Context -f -c PessoaContextScallfold

>- dotnet ef migrations add InitialCreate
>- dotnet ef database update

## Para rodar o projeto
>- cd src
>- dotnet run

### Referências
[ ASP .NET Core - Scaffolding : criando Controllers e Views via linha de comando ] ( http://www.macoratti.net/17/12/aspcore_ctrlcmd2.htm )

usando contexto:[ https://stackoverflow.com/questions/36488461/sqlite-in-asp-net-core-with-entityframeworkcore ]
( https://www.c-sharpcorner.com/UploadFile/ff2f08/multiple-models-in-single-view-in-mvc/ )
