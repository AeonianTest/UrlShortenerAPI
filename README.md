# Url Shortener Api WIP

A simple C# .NET Core Web Multi-Tenant URL Shortening Api Service, usable as a backend service by any tenant 'User' for shortening long URLs into concise, manageable ones.

## Table of Content

* [Features](#features)
* [Technologies Used](#technologies-used)
* [Installation](#installation)
* [Running the Application](#running-the-application)
* [API Endpoints](#api-endpoints)

## Features

* **EXPAND**

## Technologies Used

* **C#**
* **.NET 8**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **Swagger**
* **Docker**

## Installation

## Running the Application

## API Endpoints EXPAND THIS 

### Swagger Documentation
| Method | Path                       | Description                          | Request Body Example              |
| :----- | :--------------------------| :----------------------------------- | :-------------------------------- |
| `GET`  | `/docs`                    | Get API documentation in Browser     | `(No request body)`               |

### Admin endpoints
| Method | Path                       | Description                          | Request Body Example              |
| :----- | :--------------------------| :----------------------------------- | :-------------------------------- |
| `POST` | `/admin/users`             | Creates a new client User account. | `{ "name": "MyWebAppService", "password": "Password123", "email": "web_app@example.com", "description": "Service for our main website" }` |
| `GET`  | `/admin/users/`            | Get a list of all the users.         | (No request body)               |
| `GET`  | `/admin/users/{id}`        | Get details of a specific client User. | (No request body)               |
| `PUT`  | `/admin/users/{id}`        | Updates an existing client User account. | `{ "name": "MyUpdatedService" }` |
| `DELETE` | `/admin/users/{id}`      | Deactivates a client User account. | (No request body)                   |

### Authentication endpoints
| Method | Path                       | Description                          | Request Body Example              |
| :----- | :--------------------------| :----------------------------------- | :-------------------------------- |
| `POST` | `/oauth/token`             | Retrieve JWT token for client authentification. | `{  }` |
| `POST` | `/oauth/refresh`           | Refresh client JWT token.            | `{  }` |

### URL Shortening endpoints
| Method | Path                       | Description                          | Request Body Example              |
| :----- | :--------------------------| :----------------------------------- | :-------------------------------- |
| `POST` | `/api/shorten`             | Shortens a long URL and returns the short code. | `{ "longUrl": "https://www.example.com/a/very/long/path/to/resource" }` |

### Redirection endpoint
| Method | Path                       | Description                          | Request Body Example              |
| :----- | :--------------------------| :----------------------------------- | :-------------------------------- |
| `GET`  | `/s/{shortCode}`           | Redirects the browser to the associated URL with the short.    | `(No request body)`               |