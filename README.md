# Razor Pages CRUD Application

This is a simple .NET Core Razor Page application that demonstrates CRUD (Create, Read, Update, Delete) functionality using a local database. 

The application allows users to create, read, update, and delete items in the database.
## Technologies Used
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET Core 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-7.0&tabs=visual-studio)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [MS SQL](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Getting Started

To get started with this project, follow these steps:
1. Clone this repository to your local machine.
2. Open the project in your preferred IDE (e.g. Visual Studio, Visual Studio Code).
3. Restore the NuGet packages.
4. Update the database by running the following command in the Package Manager Console:

    ```Update-Database```
5. Run the application.

## Functionality

- **Create:** Users can create a new Category by filling out a form and submitting it by clicking on Create button.
- **Read:** Users can view a list of all Category in the database on the Category page.
- **Update:** Users can edit an existing Category by clicking the "Edit" button next to the item on the Category page, making changes in the form, 
              and submitting the changes by clicking on Update button.
- **Delete:** Users can delete an existing item by clicking the "Delete" button next to the item on the Category page and then click on Delete button.

## Contributing

Contributions are welcome! If you have any suggestions or bug reports, please open an issue or submit a pull request.

If you are new to .NET Core you can check out this course [Complete guide to ASP.NET Core MVC (.NET 8)](https://www.udemy.com/course/complete-aspnet-core-21-course/) on
Udemy for better understanding. 

## License

This project is licensed under the MIT License - see the [ LICENSE](https://opensource.org/licenses/MIT) file for details.
