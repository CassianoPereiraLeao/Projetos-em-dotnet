namespace MY_API.typesformation;

public class Password
{
    private string _password = default!;

    protected Password() { }

    public Password(string password)
    {
        _password = Validate(password);
    }

    public string Validate(string password)
    {
        return password;
    }

    public string HashPassword(string password)
    {
        return password;
    }

    public override string ToString()
    {
        return _password;
    }
}
