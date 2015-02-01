using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApplicationAtea
{
    class Program
    {
        static void Main()
        {
            string connectionString = "server=kludda.se,49155;user id=_joakimfriberg;password=_jocke321;database=wu14_atea";

            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO ConsoleMessage(ConsoleMsg, Date) VALUES(@ConsoleMsg, @Date)";
                cmd.Prepare();

                Console.WriteLine("Skriv in ett meddelande:");

                Console.WriteLine();
                string consoleMsg = Console.ReadLine();

                if (!string.IsNullOrEmpty(consoleMsg))
                {
                    cmd.Parameters.AddWithValue("@ConsoleMsg", consoleMsg);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("Du måste skriva någonting..");
                    Console.WriteLine();
                    consoleMsg = Console.ReadLine();
                    cmd.Parameters.AddWithValue("@ConsoleMsg", consoleMsg);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
     }
}
