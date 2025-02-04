# Personal Finance Manager

A Personal Finance Manager application built using **Blazor WebAssembly** for the frontend and **ASP.NET Core** for the backend. This app allows users to track their income, expenses, and financial health with the ability to view data visualizations like charts. Users can manage their financial data across different devices through a backend API.

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Technologies](#technologies)
- [Running the Project](#running-the-project)
- [API Documentation](#api-documentation)

---

## Project Overview

This project was created as an inspiration from watching [**OneLion**](https://github.com/one1lion).

The **Personal Finance Manager** helps users track their financial data, including income, expenses, budgets, and trends. The frontend is built using **Blazor WebAssembly** for a responsive and interactive user experience, while the backend is powered by **ASP.NET Core**, providing RESTful API endpoints for managing and storing financial data.

Key features include:
- Track income and expenses.
- View financial data visualizations (e.g., pie charts, bar charts).
- Store data on a cloud-based database (e.g., SQL Server or SQLite).
- Secure user authentication and data protection. (I'm never achieving this)

---

## Features

- **Income and Expense Management**: Users can add and categorize their income and expenses.
- **Data Visualization**: Financial data is represented visually using charts (e.g., pie charts for expenses, line charts for income trends).
- **Budget Tracking**: Set and track monthly budgets for different categories.
- **User Authentication**: Secure user login, registration, and password management using JWT tokens.
- **Data Synchronization**: Sync data across web and mobile apps via a backend API.
- **Offline Storage**: Store data locally in the browser using local storage or IndexedDB for offline use.

---

## Technologies

### Frontend:
- **Blazor WebAssembly** - A C#-based client-side framework for building web apps.
- **MudBlazor** - UI components library for Blazor.
- **Chart.js** - Library for creating interactive charts and graphs for financial data.
- **Blazorise** (optional) - For additional UI components and flexibility.

### Backend:
- **ASP.NET Core Web API** - RESTful API to handle business logic and CRUD operations for managing financial data.
- **Entity Framework Core** - ORM for interacting with the database.
- **JWT Authentication** - Secure token-based authentication for users.
- **Swagger** - API documentation tool for testing and exploring API endpoints.

### Database:
- **SQL Server** or **SQLite** (for mobile sync later) - Relational database to store financial data.

### Authentication:
- **OPENID** (JSON Web Tokens) for stateless authentication across the frontend and backend.

---

## Running the Project

To be added...

---

## API Documentation

To be added...

---