using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                        Import import = new Import();
                        import.ReadFile();
                        Console.ReadLine();


                        string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";

                        MySqlConnection conn = new MySqlConnection(pathDb);
                        Console.WriteLine("Connecting to MySQL...");
                        conn.Open();
                        Console.WriteLine("Connected");


                        MySqlCommand cmd = new MySqlCommand("SELECT * from `meteodata`", conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        StringBuilder csvcontent = new StringBuilder();
                        csvcontent.AppendLine("id, date, temperature, taux d'humidite");

                        while (reader.Read())
                        {
                            csvcontent.AppendLine(reader.GetString("id")+","+
                                reader.GetString("date") + "," +
                                reader.GetString("temp").Replace(",", ".") + "," +
                                reader.GetString("humidity")+"%");

                        }
                        Console.ReadLine();

                        string pathCsv = @"C:\Users\alexi\Dropbox\ProjetC#\4_Documents\sourcedonnees.csv";
                        File.AppendAllText(pathCsv, csvcontent.ToString());
                        */

            
            


            MailMessage email = new MailMessage();
            email.From = new MailAddress("bo76h211@gmail.com");
            email.To.Add(new MailAddress("alexi.bdn@gmail.com"));
            email.IsBodyHtml = true;
            email.Subject = "objet du mail";
            email.Body = " contenu du mail";
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("bo76h211@gmail.com", "Cesi2017");

            string file = @"C:\Users\alexi\Dropbox\ProjetC#\4_Documents\sourcedonnees.csv";
            // Create  the file attachment for this e-mail message.
            Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
            // Add the file attachment to this e-mail message.
            email.Attachments.Add(data);

            try
                {
                    smtp.Send(email);
                    Console.WriteLine("email envoye");
                }
                catch (SmtpException ex)
                {
                Console.WriteLine(ex.Message);
                }
            }
    }
}


