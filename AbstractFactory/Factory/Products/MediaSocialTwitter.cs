using AbstractFactory.Abstract.Products;

namespace AbstractFactory.Factory.Products;

public class MediaSocialTwitter : MediaSocial
{
    public override void Post(string title, string body)
    {
        Console.WriteLine("Postando");
        Console.WriteLine(title);
        Console.WriteLine(body + " - via Twitter");
    }

    public override void Like()
    {
        Console.WriteLine("Post curtido no Twitter");
    }
}