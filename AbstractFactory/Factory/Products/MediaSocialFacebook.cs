using AbstractFactory.Abstract.Products;

namespace AbstractFactory.Factory.Products;

public class MediaSocialFacebook : MediaSocial
{
    public override void Post(string title, string body)
    {
        Console.WriteLine("Postando");
        Console.WriteLine(title);
        Console.WriteLine(body + " - via Facebook");
    }

    public override void Like()
    {
        Console.WriteLine("Post curtido no Facebook");
    }
}