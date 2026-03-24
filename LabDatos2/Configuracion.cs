namespace LabDatos2
{
    /// <summary>
    /// Configuración centralizada de conexión.
    /// Cambia SOLO aquí cuando cambies de red.
    /// </summary>
    public static class Configuracion
    {
        // ══════════════════════════════════════════════
        //  CAMBIA SOLO ESTA LÍNEA AL CAMBIAR DE RED
        // ══════════════════════════════════════════════
        private static readonly string Servidor = "10.12.13.137,1433";

        // Si necesitas cambiar de red, comenta la línea de arriba
        // y descomenta la que corresponda:
        // private static readonly string Servidor = "192.168.1.77,1433";
        // private static readonly string Servidor = "localhost,1433";

        // ══════════════════════════════════════════════
        //  NO TOQUES LO DE ABAJO
        // ══════════════════════════════════════════════
        private const string BaseDatos = "LabDatosDB";
        private const string Usuario = "sa";
        private const string Password = "123";

        public static string CadenaConexion =>
            $"Server={Servidor};Database={BaseDatos};User Id={Usuario};Password={Password};TrustServerCertificate=True;";
    }
}