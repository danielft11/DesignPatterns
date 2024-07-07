using AbstractFactory.Factory;

/* Código antigo com alto acoplamento
 
MediaSocialFacebook media = new MediaSocialFacebook();

media.Post("Feliz aniversário", "Parabéns pelo seu aniversário!");
media.Like();

*/

AbstractFactory.Abstract.AbstractFactory factory = new MediaSocialFactory();

var mediaSocialFacebook = factory.CreateMediaSocialFacebook();
mediaSocialFacebook.Post(title: "Título do Post", body: "Conteúdo do Post");
mediaSocialFacebook.Like();

var mediaSocialTwitter = factory.CreateMediaSocialTwitter();
mediaSocialTwitter.Post(title: "Título do Post", body: "Conteúdo do Post");
mediaSocialTwitter.Like();