using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DBConnect
{
    public static DBConnect conn = new DBConnect();
    private string path = "server=localhost; user=root; database=world_x; port=3306; password=";

    private DBConnect()
    {
        try
        {
        MySqlConnection CONNEXION = new MySqlConnection(path);
        Console.WriteLine("Connecting to MySQL...");
        CONNEXION.Open();
        Console.WriteLine("Connected");
        }

        catch (Exception ex)
        {
            Console.WriteLine("erreur.");
            Console.WriteLine(ex.ToString());
        }
    }

    public static DBConnect getInstance()
    {
        return conn;
    }

    public void Close() { 
        this.Close();
        Console.WriteLine("DB closed");
        Console.ReadLine();
    }
}
