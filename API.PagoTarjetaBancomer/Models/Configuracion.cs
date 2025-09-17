namespace API.PagoTarjetaBancomer.Models
{
    public class Configuracion
    {
        public string ComercioAfiliacion { get; set; } = "";
        public string ComercioTerminal { get; set; } = "";
        public string ComercioMac { get; set; } = "";
        public string HostUrl { get; set; } = "";
        public bool FuncionalidadMoto { get; set; } = false;
        public bool PinpadCargaLlaves { get; set; } = false;
        public bool Logs { get; set; } = true;
    }
}
