using BuilderPattern.Build;
using BuilderPattern.Director;

var builder = new MediaSocialFacebookBuilder();
var director = new Director(builder);

