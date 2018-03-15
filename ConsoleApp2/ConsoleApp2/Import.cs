using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;
using MySql.Data;

public class Import
{
	public Import()
	{
    }

    public void ReadFile()
    {
        string pathDb = "server=localhost; user=root; database=world_x; port=3306; password=";
  
            MySqlConnection conn = new MySqlConnection(pathDb);
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            Console.WriteLine("Connected");

        string path = @"C:\Users\alexi\Dropbox\ProjetC#\4_Documents\Sourcedonnées.txt";
        int counter = 0;

        String[] file = File.ReadAllLines(path);         // Read the file and display it line by line.  

        foreach (String lines in file)  
        {
            string[] entries = lines.Split(' ');

            int id = int.Parse(Regex.Replace(entries[0], "[^0-9 ]", ""));
            DateTime date = System.DateTime.Parse(entries[1] + " " + entries[2]);
            double temp = double.Parse(Regex.Replace(entries[3], "[^0-9., ]", "").Replace(".", ","));
            double humidity = double.Parse(Regex.Replace(entries[4], "[^0-9., ]", "").Replace(".", ","));

            try
            {
               MySqlCommand cmd = new MySqlCommand("INSERT INTO `meteodata` (`id`, `date`, `temp`, `humidity`) VALUES(@id, @date, @temp, @humidity)",conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@temp", temp);
                cmd.Parameters.AddWithValue("@humidity", humidity);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
   
            counter++;
            
        }

        
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.  
        System.Console.ReadLine();

    }
}
