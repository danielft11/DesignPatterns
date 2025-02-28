namespace ChainOfResponsability.Handlers
{
    public class RH : Autorizador
    {
        private readonly int ALCADA_EM_DIAS = 30;

        public override void ProcessarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_EM_DIAS)
                AprovarLicenca(nome, dias);
            else
                Console.WriteLine($"Não foi possível autorizar a licença de {dias} para {nome}. Comunique a diretoria.\n");
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O setor de RH aprovou {dias} de licença remunerada para {nome}.\n");
        }

    }
}
