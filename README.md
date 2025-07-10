# Student Management System (CRUD) – ASP.NET 

A simple web application to manage student records using **ASP.NET**, **Entity Framework Core**, and **SQL Server**. It supports full **CRUD operations**, search functionality, and form validation.

---

## Features

- List all students
- Add new student
- Edit student details
- Delete student
- Search by Name 
- Form validation
- Bootstrap-styled 

---

## Technologies Used

- C#
- ASP.NET
- Entity Framework Core
- SQL Server
- Bootstrap 5


---

## How to Run the Project

1. **Open the project in Visual Studio**

2. **Run the app**
   - Press `Ctrl + F5`
   - Go to `/Students` to view and manage student records

---

## Database Schema

```sql
CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Course NVARCHAR(50),
    EnrollmentDate DATE
);
```
<img width="3840" height="2160" alt="Screenshot (884)" src="https://github.com/user-attachments/assets/1e170892-7c7c-4109-82da-c207b2db50f6" />
Main Page

<img width="3840" height="2160" alt="Screenshot (885)" src="https://github.com/user-attachments/assets/dbd7a2fb-3f07-4e02-936a-37718692d9cb" />
Search


<img width="3840" height="2160" alt="Screenshot (886)" src="https://github.com/user-attachments/assets/ed9d5041-2913-4185-aa9c-c1ef2ed56b92" />
Create new record

<img width="3840" height="2160" alt="Screenshot (888)" src="https://github.com/user-attachments/assets/3c3dc914-624c-43b2-a634-e0fff46a7056" />
Show details

<img width="3840" height="2160" alt="Screenshot (886)" src="https://github.com/user-attachments/assets/187e848d-db87-4c6c-96b1-6ec69241f7da" />
Edit record


<img width="3840" height="2160" alt="Screenshot (881)" src="https://github.com/user-attachments/assets/afc1e5d8-c24b-4da4-bbcd-d5f8161a51f5" />
Validation form


