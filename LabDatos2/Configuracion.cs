namespace LabDatos2
{
    /// <summary>
    /// Configuración centralizada de conexión.
    /// </summary>
    public static class Configuracion
    {
        // linea del red
        private static readonly string Servidor = "192.168.1.75,1433";

        private const string BaseDatos = "LabDatosDB";
        private const string Usuario = "sa";
        private const string Password = "123";

        public static string CadenaConexion =>
            $"Server={Servidor};Database={BaseDatos};User Id={Usuario};Password={Password};TrustServerCertificate=True;";
    }
}