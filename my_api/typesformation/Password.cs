namespace MY_API.typesformation;

public class Password
{
    private readonly string password;

    public Password(string password)
    {
        this.password = Validate(password);
    }

    public string Validate(string password)
    {
        return password;
    }

    public string HashPassword(string password)
    {
        return password;
    }
}
