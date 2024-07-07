using BuilderPattern.Products;

namespace BuilderPattern.Build
{
    public class MediaSocialTwitterBuilder : MediaSocialBuilder
    {
        public MediaSocialTwitterBuilder()
        {
            _mediaSocial = new MediaSocial("Twitter");
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("Título da publicação do Twitter");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post("Título da publicação", "Corpo da publicação do Twitter");
        }

    }

}
