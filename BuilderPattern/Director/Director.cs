using BuilderPattern.Build;

namespace BuilderPattern.Director
{
    public class Director
    {
        public Director(MediaSocialBuilder builder)
        {
            builder.BuildPost();
            builder.BuildLike();
        }
    }
}
