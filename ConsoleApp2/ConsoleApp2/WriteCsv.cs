using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Text;

public class CsvFileWriter
{

    public CsvFileWriter()
    {
        string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";

        MySqlConnection conn = new MySqlConnection(pathDb);
        Console.WriteLine("Connecting to MySQL...");
        conn.Open();
        Console.WriteLine("Connected");

        MySqlCommand cmd = new MySqlCommand("SELECT * from `meteodata`", conn);

        StringBuilder csvcontent = new StringBuilder();
        csvcontent.AppendLine("name, age");
        csvcontent.AppendLine("alex, 32");

        string pathCsv = @"C:\Users\alexi\Dropbox\ProjetC#\4_Documents\sourcedonnees.csv";
        File.AppendAllText(pathCsv, csvcontent.ToString());
    }
    
}