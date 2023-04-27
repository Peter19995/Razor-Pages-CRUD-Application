# Razor Pages CRUD Application

This is a simple .NET Core Razor Page application that demonstrates CRUD (Create, Read, Update, Delete) functionality using a local database. 

The application allows users to create, read, update, and delete Categories in the database.



## Technologies Used
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET Core 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
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
<img width="772" alt="Create Category" src="https://user-images.githubusercontent.com/55706749/234907573-6454b983-f277-4aa3-ba5b-8b98c9efa6ed.png">

- **Read:** Users can view a list of all Category in the database on the Category page.
<img width="774" alt="Screenshot 2023-04-27 181206" src="https://user-images.githubusercontent.com/55706749/234906867-5824e8d2-0a68-4e77-9ada-80cac899db71.png">

- **Update:** Users can edit an existing Category by clicking the "Edit" button next to the item on the Category page, making changes in the form, 
              and submitting the changes by clicking on Update button.
<img width="777" alt="Update" src="https://user-images.githubusercontent.com/55706749/234907968-415775d1-b08a-4b2f-ad69-50b528787392.png">

- **Delete:** Users can delete an existing item by clicking the "Delete" button next to the item on the Category page and then click on Delete button.
<img width="779" alt="Delete" src="https://user-images.githubusercontent.com/55706749/234908162-d1461ffb-6229-4688-acf8-c46c15a673ff.png">

## Contributing

Contributions are welcome! If you have any suggestions or bug reports, please open an issue or submit a pull request.

If you are new to .NET Core you can check out this course [Complete guide to ASP.NET Core MVC (.NET 8)](https://www.udemy.com/course/complete-aspnet-core-21-course/) on
Udemy for better understanding. 

## License

This project is licensed under the MIT License - see the [ LICENSE](https://opensource.org/licenses/MIT) file for details.
