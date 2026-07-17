# Creating a New Endpoint

## 1. Define the endpoint
- Decide the route
- Decide the HTTP method (GET, POST, PUT, DELETE)
- Decide what the endpoint should do

Example:
POST /api/auth/register

---

## 2. Create DTOs (Application)

Create request and/or response DTOs.

Example:
- RegisterRequest
- AuthResponse

---

## 3. Create validators (Application)

Validate:
- Required fields
- Lengths
- Formats
- Simple business-independent rules

Do NOT access the database here.

---

## 4. Create/update repository interface (Application)

If persistence is needed:

- Add methods to the repository interface

Example:

- GetByEmailAsync()
- GetByUsernameAsync()
- AddAsync()

---

## 5. Implement repository (Infrastructure)

Implement the repository methods using EF Core.

Examples:

- FirstOrDefaultAsync()
- AnyAsync()
- AddAsync()
- SaveChangesAsync()

---

## 6. Create/update service interface (Application)

Define the business operation.

Example:

Task<AuthResponse> RegisterAsync(RegisterRequest request);

---

## 7. Implement service (Application)

Business logic goes here.

Typical order:

- Validate business rules
- Query repositories
- Create/update entities
- Save changes
- Return DTO

---

## 8. Register dependencies (API)

If new services were added:

- AddScoped<IUserRepository, UserRepository>()
- AddScoped<IAuthService, AuthService>()

---

## 9. Create/update controller (API)

Keep controllers thin.

Example:

- Receive DTO
- Call service
- Return response

---

## 10. Test with Swagger

Test:

- Valid request
- Invalid request
- Edge cases

---

## 11. Refactor if needed

Ask:

- Is business logic inside the service?
- Is persistence inside repositories?
- Is the controller thin?
- Are DTOs only used for transport?