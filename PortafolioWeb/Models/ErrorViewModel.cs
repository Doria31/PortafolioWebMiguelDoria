namespace PortafolioWeb.Models
{

    public class Persona
    {
        public string Nombre { get; set; }
        public int edad { get; set; }

    }
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
