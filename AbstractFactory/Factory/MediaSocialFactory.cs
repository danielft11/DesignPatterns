using AbstractFactory.Abstract.Products;
using AbstractFactory.Factory.Products;

namespace AbstractFactory.Factory;

public class MediaSocialFactory : Abstract.AbstractFactory
{
    public override MediaSocial CreateMediaSocialFacebook()
    {
        return new MediaSocialFacebook();
    }

    public override MediaSocial CreateMediaSocialTwitter()
    {
        return new MediaSocialTwitter();
    }
}