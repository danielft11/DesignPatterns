using AbstractFactory.Abstract.Products;

namespace AbstractFactory.Abstract;

public abstract class AbstractFactory
{
    public abstract MediaSocial CreateMediaSocialFacebook();
    public abstract MediaSocial CreateMediaSocialTwitter();
}


