# GameWebsite - ASP.NET Core MVC 8 Web Application
### Developed With DevCreed's Playlist On Youtube [CRUD Operations with .Net 8](https://www.youtube.com/playlist?list=PL62tSREI9C-cQ21T5HIWqqBOHQiNMOhBG)

This is a simple CRUD application built using **ASP.NET Core MVC 8** as a framework, Entity Framework Core for the ORM, SQL Server for a relational database.
The app also incorporates **HTML**, **CSS**, **JavaScript**, **jQuery** and **Bootstrap**  to deliver a dynamic and user-friendly interface.

## Table of Contents
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Folder Structure](#folder-Structure)
---

## Features
- **Data Management**: CRUD (Create, Read, Update, Delete) operations for data entries.
- **Interactive UI**: Dynamic content loading using jQuery and AJAX.
- **Responsive Design**: Responsive layout optimized with Bootstrap.
- **Server-Side Validation**: Ensuring data integrity through model validation in ASP.NET Core MVC.

## Technologies
- **ASP.NET Core MVC 8**: The core framework for developing server-side logic and routing.
- **HTML5 & CSS3**: Markup and styling to structure and design the front-end of the app.
- **JavaScript**: For front-end scripting and interactivity.
- **jQuery**: Simplifies JavaScript code and adds dynamic behavior.
- **Bootstrap**: Used for responsive design and pre-styled UI components.


## Getting Started
To get a local copy of this project up and running, follow these instructions.

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) version 8.0 or higher
- A code editor (e.g., [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/))

### Setup and Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/abdullahyousr/GameWebsite.git
   cd GameWebsite

2. **Restore NuGet Packages**:
   ```bash
   dotnet restore

3. **Run Database Migrations**:
   ```bash
   dotnet ef database update

5. **Run the Application**:
    ```bash
    dotnet run
   
7. **Access the App**:
   ```bash
   Open browser and go to http://localhost:PortNumber

## Usage
After setting up the app, you can:

- **Do CRUD Operations: CREATE, READ, UPDATE, DELETE records.**
- **Interact with the UI for a seamless user experience.**

## Folder Structure
```plaintext
GameWebsite
│
├── Controllers          # ASP.NET Core MVC Controllers for handling requests.
├── Views                # Razor Views for rendering the UI.
├── wwwroot              # Static files, including CSS, BootStrap, JavaScript, JQuery, and images.
├── Models               # Data models representing the application data.
├── Attributes           # Custom validation attributes, to validate model data.
├── Services             # Contains business logic and application services
├── ViewModels           # Data transfer objects to pass data between the controller and the view
└── Settings             # Configuration settings for the files uploaded to the application (e.g., MaxFileSizeInBytes, AllowedExtensions)
