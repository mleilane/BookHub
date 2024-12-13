using System;
using BookHub;
using BookHub.Forms;
using Microsoft.Data.SqlClient;

#region Teste da conexao com BD
//class Program
//{
//    static void Main()
//    {
//        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BookHubDBConnection"].ConnectionString;

//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Conexão bem-sucedida!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Erro ao conectar: {ex.Message}");
//            }
//        }
//    }
//}
#endregion


namespace BookHub
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new TelaInicial());

           
        }

    }
}