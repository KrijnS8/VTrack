namespace RideConnect.Domain.Errors;

public class UserErrors
{
    public static Error InvalidCredentials => new("INVALID_CREDENTIALS", "Invalid credentials");
    public static Error UsernameTaken => new("USERNAME_TAKEN", "Username already taken");
    public static Error EmailTaken => new("EMAIL_TAKEN", "Email already taken");
}
