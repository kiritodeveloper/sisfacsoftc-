namespace Modelos
{
    class Conexion
    {
        public static string Cn = System.Configuration.ConfigurationManager.ConnectionStrings["CharityManagement"].ConnectionString;
    }
}