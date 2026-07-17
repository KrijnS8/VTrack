# RideConnect Backend Roadmap

> Current status: **Foundation complete** ✅

You now have:

-   Clean Architecture solution
-   ASP.NET Core API
-   EF Core
-   PostgreSQL running in Docker
-   Initial migration applied
-   Database schema created successfully

------------------------------------------------------------------------

# Phase 1 --- Foundation ✅

Completed:

-   [x] Database design (DrawDB)
-   [x] Domain entities
-   [x] EF Core configurations
-   [x] DbContext
-   [x] PostgreSQL
-   [x] Docker Compose
-   [x] Initial migration
-   [x] Database update

------------------------------------------------------------------------

# Phase 2 --- Authentication

This should be the next focus.

## Register

**Endpoint**

`POST /auth/register`

Learn:

-   DTOs
-   Validation
-   Password hashing (BCrypt)
-   Saving users
-   Duplicate email/username checks

------------------------------------------------------------------------

## Login

**Endpoint**

`POST /auth/login`

Learn:

-   Password verification
-   JWT generation
-   Refresh token strategy (later)

------------------------------------------------------------------------

## Current User

**Endpoint**

`GET /users/me`

Learn:

-   Authentication
-   Authorization
-   Claims
-   Reading the current user

------------------------------------------------------------------------

# Phase 3 --- User Features

## User Profile

-   GET `/users/{id}`
-   PUT `/users/me`

## User Motorcycles

-   POST `/motorcycles`
-   GET `/motorcycles`
-   PUT `/motorcycles/{id}`
-   DELETE `/motorcycles/{id}`

------------------------------------------------------------------------

# Phase 4 --- Ride Requests

This becomes the first "real" RideConnect feature.

## Create Ride Request

-   POST `/ride-requests`

## Browse Ride Requests

-   GET `/ride-requests`

Initially: - newest first

Later: - nearby - filtering - pagination

## Ride Details

-   GET `/ride-requests/{id}`

## Join Ride

-   POST `/ride-requests/{id}/join`

## Leave Ride

-   DELETE `/ride-requests/{id}/join`

------------------------------------------------------------------------

# Phase 5 --- Location

Replace

``` csharp
string Location
```

with PostGIS:

``` csharp
Point MeetingLocation
```

This enables:

-   rides within X km
-   spatial indexing
-   efficient nearby searches

------------------------------------------------------------------------

# Phase 6 --- Meets

Keep Ride Requests simple:

> "Anyone wants to ride?"

Create a new entity for Meets:

> "Large planned group ride."

Separate concerns.

------------------------------------------------------------------------

# Phase 7 --- Nice-to-have Features

-   Notifications
-   Manufacturer seed data
-   Motorcycle model seed data
-   Profile pictures
-   Ride history
-   Search
-   Favorites
-   Ratings
-   Achievements

------------------------------------------------------------------------

# Recommended Development Order

1.  Authentication
2.  Users
3.  User Motorcycles
4.  Ride Requests
5.  Joining Ride Requests
6.  Location / PostGIS
7.  Meets
8.  Notifications

------------------------------------------------------------------------

# Request Flow (Recommended)

Instead of introducing CQRS immediately, keep the architecture
straightforward.

``` text
HTTP Request
      │
      ▼
Controller
      │
      ▼
Application Service
      │
      ▼
Repository
      │
      ▼
DbContext
      │
      ▼
PostgreSQL
```

Once the project grows and you understand the complete flow, you can
decide whether introducing CQRS/MediatR provides enough value.

------------------------------------------------------------------------

# Immediate Next Goal

Build authentication.

1.  User entity is already finished.
2.  Create authentication DTOs.
3.  Create `IAuthService`.
4.  Implement password hashing.
5.  Register users.
6.  Login users.
7.  Generate JWTs.
8.  Protect endpoints.

Once authentication works, every other feature becomes significantly
easier to build.