namespace Hotel.Models;

public class Pessoa
{
    private readonly string nome;
    private readonly string sobrenome;
    private readonly string? nickname;

    public Pessoa(string nome, string sobrenome, string? nickname = "")
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.nickname = nickname;
    }

    public string GetNome()
    {
        return nome;
    }

    public string GetSobrenome()
    {
        return sobrenome;
    }

    public string? GetNickname()
    {
        return nickname;
    }
}