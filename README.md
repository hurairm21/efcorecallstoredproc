# Task Planner Api

# Pre-requisites: Ensure the following is installed in your system.

* .NET Core v2.2
* Editor: VS 2017/VS Code
* Database: SQL SERVER MANAGEMENT STUDIO(>=2014)

# Your Assignment: Develop a REST API.

* The Rest API should contain CRUD endpoints for all the entities.
* I should be able to get all tasks of a team and a user.
* I should be able to get completed/in-progress/todo tasks of a team and a user.
* I should be able to get all notes created by a team and a user.
* I should be able to get all notes of a completed/in-progress/todo tasks of a team and a user.

NOTE:
* Follow 'DRY': DO NOT REPEAT YOURSELF
* Follow 'KISS': KEEP IT SHORT AND SIMPLE/STUPID
* Follow Naming Conventions.

# Steps to start the assignment.

* Checkout branch feature/assignment-{{YourName}}.

* Map Database to your local.

Go to TaskPlannerApi/appsettings.json, The connection string is 
```Server=localhost\\SQLEXPRESS;Database=TaskPlannerDb;Integrated Security=True;```

Replace the connection string with your local sql server instance (your local connection string)

* Press F5/Start Application.

* Go to your SQL SERVER MANAGEMENT STUDIO and look for ```TaskPlannerDb``` that would have been created.

* Some Status, User and Team data have been pre-seeded. Modify them as you like.


# In case of any Problem.
* In case of a problem/question/suggestion/feedback reach out to saurabh.pati@grapecity.com/saurabhpati.pati@gmail.com 

AND 

Do raise the same issue on https://gitlab.com/saurabhpati/TaskPlannerApi/issues to document any shortcomings and their solutions with this starter template.

# Swagger Is Enabled at ```/swagger```