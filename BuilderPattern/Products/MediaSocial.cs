namespace BuilderPattern.Products;

public class MediaSocial
{
    private readonly string _nomeRedeSocial;

    public MediaSocial(string nomeRedeSocial)
    {
        _nomeRedeSocial = nomeRedeSocial;
    }

    public void Post(string title, string body)
    {
        Console.WriteLine(_nomeRedeSocial);
        Console.WriteLine(title);
        Console.WriteLine(body);
    }

    public void Like(string publicacao)
    {
        Console.WriteLine($"A publicação {publicacao} foi curtida no {_nomeRedeSocial}");
    }
    
}