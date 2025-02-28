namespace ChainOfResponsability.Handlers
{
    public class SupervisorDeEquipe : Autorizador
    {
        private readonly int ALCADA_EM_DIAS = 15;

        public override void ProcessarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_EM_DIAS)
                AprovarLicenca(nome, dias);
            else
                _autorizador?.ProcessarLicenca(nome, dias);
        }

        private static void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Supervisor da Equipe aprovou {dias} de licença remunerada para {nome}.\n");
        }

    }
}
