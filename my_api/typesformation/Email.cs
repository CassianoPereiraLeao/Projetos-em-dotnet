using Microsoft.AspNetCore.Mvc;

namespace MY_API.typesformation;

public class Email
{
    private readonly string email;

    public Email(string email)
    {
        this.email = Validate(email);
    }

    public string Validate(string email)
    {
        return email;
    }

    public override string ToString()
    {
        return email;
    }
}