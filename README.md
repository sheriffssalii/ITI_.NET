# 🛒 ITI_.NET - E-Commerce MVC Web Application

This is a complete e-commerce web application built using **ASP.NET Core MVC** as part of my final project for the ITI .NET track. It demonstrates key concepts such as authentication, authorization, database management using Entity Framework Core, and a clean Razor-based UI.

---

## 🚀 Features

- 🧑‍💼 User Registration & Login (Authentication)
- 🔐 Role-based Authorization (Admin vs. Users)
- 📦 Product & Category Management (CRUD)
- 🛒 Shopping Cart functionality (optional if added)
- 🌐 Responsive UI using Razor Pages & Bootstrap
- 🗃️ Data Persistence using **Entity Framework Core**
- 🔎 Input validation & error handling

---

## 🛠️ Technologies Used

| Technology      | Purpose                        |
|----------------|---------------------------------|
| ASP.NET Core MVC | Backend framework              |
| Entity Framework Core | ORM for SQL Server         |
| Razor Pages     | View rendering (HTML + C#)      |
| Bootstrap       | Styling and responsiveness      |
| LINQ / Lambda   | Data querying                   |
| SQL Server      | Database                        |

---

## 📁 Project Structure

Controllers/ → Handles HTTP requests
Models/ → Application data classes
Views/ → Razor-based front-end
wwwroot/ → Static files (CSS, JS, images)
Context/ → EF DbContext and configuration
Migrations/ → EF Core migrations
appsettings.json → App & DB configurations
Program.cs → App startup logic


---

## 💻 How to Run Locally

1. Clone the repo:
   ```bash
   git clone https://github.com/sheriffssalii/ITI_.NET.git
   cd ITI_.NET
Open in Visual Studio

Update the connection string in appsettings.json if needed:
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=YourDBName;Trusted_Connection=True;"
}
Run EF migrations (if applicable):
Press F5 or run the project

📬 Contact

If you'd like to collaborate, ask questions, or offer feedback:

📧 sheriefzaid1@gmail.com

💼 [LinkedIn](https://www.linkedin.com/in/sheriffssalii)
