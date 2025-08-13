using Microsoft.AspNetCore.Mvc;

namespace MY_API.typesformation;

public class Email
{
    private readonly string _email = default!;

    protected Email() { }

    public Email(string email)
    {
        _email = Validate(email);
    }

    public string Validate(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentNullException("O campo email não pode ser nulo");
        }
         
        return email;
    }

    public override string ToString()
    {
        return _email;
    }
}