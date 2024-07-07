using BuilderPattern.Products;

namespace BuilderPattern.Build
{
    public class MediaSocialFacebookBuilder : MediaSocialBuilder
    {
        public MediaSocialFacebookBuilder()
        {
            _mediaSocial = new MediaSocial("Facebook");
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("Título da publicação");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post("Título da publicação", "Corpo da publicação");
        }
    }
}
