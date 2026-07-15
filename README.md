# VTrack

# Fleet Maintenance Management Platform

A modern fleet and maintenance management platform built with **ASP.NET Core**, **PostgreSQL**, **React/Next.js**, and **Docker**.

The goal of this project is to create a scalable, production-like application that can be used by both individuals and businesses to manage vehicles, maintenance, inspections, costs, and service schedules.

---

## Project Overview

This application allows users to manage a fleet of vehicles or machines from a single dashboard. Every asset has its own maintenance history, documents, service intervals, fuel logs, and cost analysis.

Although the project is inspired by motorcycle maintenance, the architecture is designed to support multiple asset types such as:

* 🏍️ Motorcycles
* 🚗 Cars
* 🚚 Vans
* 🚜 Agricultural machinery
* ⚙️ Industrial equipment

---

## Features

### Dashboard

* Fleet overview
* Upcoming maintenance
* Active issues
* Monthly maintenance costs
* Service reminders

### Asset Management

* Create and manage vehicles/assets
* Vehicle specifications
* Photos
* Documents
* VIN / Registration number
* Purchase information

### Maintenance

* Complete maintenance history
* Oil changes
* Chain maintenance
* Tire replacement
* Brake service
* Inspections
* Custom maintenance tasks

Each maintenance record includes:

* Date
* Mileage / Hours
* Cost
* Parts used
* Notes
* Attachments

### Fuel Tracking

* Fuel logs
* Fuel consumption
* Cost per kilometer
* Average fuel price
* Mileage tracking

### Parts Inventory

* Installed parts
* Purchase history
* Warranty information
* Supplier information

### Service Reminders

Automatic reminders based on:

* Time intervals
* Mileage
* Engine hours

Examples:

* Oil changes
* Tire replacement
* Brake fluid
* Annual inspections

### Issue Reporting

Users can create and manage issues such as:

* Mechanical problems
* Damage reports
* Electrical faults

Each issue includes:

* Priority
* Status
* Description
* Assigned mechanic
* Resolution history

### QR Codes

Each asset receives a unique QR code.

Scanning the QR code opens the maintenance page directly, allowing mechanics to quickly view:

* Maintenance history
* Open issues
* Upcoming service
* Asset information

---

## User Roles

### Administrator

* Full access
* Manage users
* Manage fleet
* Configure system settings

### Mechanic

* Perform maintenance
* Update issues
* Upload service reports

### Employee

* View assigned assets
* Report issues
* View maintenance history

### Viewer

* Read-only access

---

## Technical Goals

This project is intended to demonstrate backend development skills and software architecture rather than only CRUD operations.

The focus includes:

* Clean Architecture
* RESTful API design
* Authentication & Authorization
* Scalable database design
* Logging & Monitoring
* Automated testing
* Dockerized development environment
* CI/CD pipelines
* Cloud deployment

---

## Planned Tech Stack

### Backend

* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* FluentValidation
* Serilog
* JWT Authentication
* Role-Based Authorization

### Frontend

* React
* Next.js
* TypeScript
* Tailwind CSS

### Infrastructure

* Docker
* Docker Compose
* Nginx
* GitHub Actions
* Azure

---

## Future Features

* Mobile application
* Push notifications
* Calendar integration
* Email reminders
* Analytics dashboard
* Multiple organizations
* Asset sharing
* Public maintenance records
* API integrations
* Barcode support
* Offline mode

---

## Learning Objectives

This project is designed to improve skills in:

* Backend architecture
* Database design
* Authentication
* Authorization
* Docker
* Testing
* Cloud deployment
* API development
* Performance optimization
* Production-ready software development

---

## Project Status

🚧 Currently in development.
