namespace ChainOfResponsability.Handlers
{
    public abstract class Autorizador
    {
        protected Autorizador? _autorizador;

        public void ProximoAutorizador(Autorizador sucessor)
        {
            _autorizador = sucessor;
        }

        public abstract void ProcessarLicenca(string nome, int dias);

    }

}
