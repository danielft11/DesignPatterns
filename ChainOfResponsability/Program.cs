using ChainOfResponsability.Handlers;

GerenteDeProjeto gerente = new();
SupervisorDeEquipe supervisor = new();
RH rh = new();

// cadeia de autorização
gerente.ProximoAutorizador(supervisor);
supervisor.ProximoAutorizador(rh);

// Casos de uso
gerente.ProcessarLicenca("Macoratti", 9);
gerente.ProcessarLicenca("Amanda", 14);
gerente.ProcessarLicenca("Benedito", 18);
gerente.ProcessarLicenca("Janice", 30);
gerente.ProcessarLicenca("Felipe", 50);

Console.ReadKey();