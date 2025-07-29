# VB.NET Inventory Management System

This project is a **Windows Forms Application** built with **VB.NET** and **Microsoft SQL Server** for managing user accounts (Admin/User) and inventory products.

---

## 💾 Database Connection

The application uses ADODB for connecting to the database. You need to **configure the connection string** to match your machine’s SQL Server setup.

### ⚠️ Edit Your Connection String

Open your VB.NET code and locate this line:
```
Dim connString As String = "Provider=SQLOLEDB;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;"
```
-------------------------------------------------------

# 🧾 VB.NET Inventory Management System (With Microsoft SQL Server)

A Windows Forms application built with **VB.NET**, using **ADODB** for database access and **Microsoft SQL Server** as the backend. This system handles **user login (Admin/User)** and **inventory management**.

---

## ⚙️ Requirements

- Visual Studio with VB.NET support
- Microsoft SQL Server (any edition)
- SSMS (SQL Server Management Studio) for managing the database

---

## 🧠 What This Project Does

- Login system (Admin/User roles)
- Account management with separate Admin/User tables
- Inventory system with product catalog and stock management

---

## 🚀 How to Set It Up

#  🖥️ Create the SQL Server Database

Open SQL Server Management Studio (SSMS) and run the following script to create the `INVENTORY` database and its tables.

## 1. Create Database
```
CREATE DATABASE INVENTORY;
```

## 2. Use the new database
```
USE INVENTORY;
```

## 3. Create Accounts table
```
CREATE TABLE Accounts (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL  -- 'Admin' or 'User'
);
```
## 4. Create Admins table
```
CREATE TABLE Admins (
    AdminID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT FOREIGN KEY REFERENCES Accounts(AccountID),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL
);
```
## 5. Create Users table
```
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT FOREIGN KEY REFERENCES Accounts(AccountID),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL
);
```
## 6. Create ProductCatalog table
```
CREATE TABLE ProductCatalog (
    product_name VARCHAR(100) PRIMARY KEY,
    group_name VARCHAR(100)
);
```
## 7. Create ProductStock table
```
CREATE TABLE ProductStock (
    product_number INT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    expiry_date DATE,
    quantity INT NOT NULL DEFAULT 0,
    status VARCHAR(20),
    FOREIGN KEY (product_name) REFERENCES ProductCatalog(product_name)
);
```
---
## 🧑‍💼 How to Insert a New Admin Account (On a New Database)

If you're starting with a **new database** and want to create a working Admin account, you must insert data into **two tables**:

## Step 1: Insert into Accounts
```
INSERT INTO Accounts (Username, Email, Password, Role)
VALUES ('admin1', 'admin@example.com', 'adminpass', 'Admin');
```
## Step 2: Capture the AccountID
```
DECLARE @adminAccountID INT = SCOPE_IDENTITY();
```
## Step 3: Insert into Admins table
```
INSERT INTO Admins (AccountID, FirstName, LastName, DateOfBirth)
VALUES (@adminAccountID, 'Firstname', 'Lastname', '2000-01-01');
```

