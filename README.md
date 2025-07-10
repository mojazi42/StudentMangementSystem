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
## Screenshots

### Main Page  
<img width="100%" alt="Main Page" src="https://github.com/user-attachments/assets/1e170892-7c7c-4109-82da-c207b2db50f6" />

### Search Functionality  
<img width="100%" alt="Search" src="https://github.com/user-attachments/assets/dbd7a2fb-3f07-4e02-936a-37718692d9cb" />

### Create New Student  
<img width="3840" height="2160" alt="Screenshot (890)" src="https://github.com/user-attachments/assets/51ed76fc-6181-48db-9106-c4e2a2124417" />


### Student Details  
<img width="100%" alt="Show details" src="https://github.com/user-attachments/assets/3c3dc914-624c-43b2-a634-e0fff46a7056" />

###  Edit Student  
<img width="100%" alt="Edit record" src="https://github.com/user-attachments/assets/187e848d-db87-4c6c-96b1-6ec69241f7da" />

### Validation Example  
<img width="3840" height="2160" alt="Screenshot (883)" src="https://github.com/user-attachments/assets/29206706-3cfd-4681-8094-e90fa573df4a" />


