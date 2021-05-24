using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StudentLoanSystem.Data;
using StudentLoanSystem.Models;
using System;


namespace StudentLoanSystem
{
    public class Program
    {

        public static string SQLDataSoure = "student-loan-server.database.windows.net";
        public static string SQLUserId = "student-loan-admin";
        public static string SQLPassword = "Password123";
        public static string SQLInitialCatalog = "student-loan-db";

        public static void Main(string[] args)
        {
            //Testing Connection to SQL
            //TestConnection();

            var host = CreateHostBuilder(args).Build();
            /*
            using (var scope = host.Services.CreateScope())
            {
                var serv = scope.ServiceProvider;
                try
                {
                    var context = serv.GetRequiredService<AccountData>();
                    context.Database.EnsureCreated();
                    test_seed.AddStudents(context);
                } catch(Exception ex)
                {
                    var logger = serv.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error Occured with Ensuring DB is there");
                }
            }
            */
            host.Run();  
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });



        // Overall Loading of data creating objects of people?
       // public static void LoadData() { }

        public static void TestConnection()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserId;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                System.Diagnostics.Debug.WriteLine("=================Test Connection================\n");

                String sql = "SELECT username, password FROM test";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Diagnostics.Debug.WriteLine("Username: {0} Password: {1}", reader.GetString(0), reader.GetString(1));
                        }
                    }
                    connection.Close();
                }
                System.Diagnostics.Debug.WriteLine("\n=================End Test Connection================\n");

            }
        }



    }
}
