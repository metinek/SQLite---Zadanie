using System.Data.SQLite;
namespace SQLite
{
    public partial class MainPage : ContentPage
    {
        static SQLiteConnection conn;
        static string connStr = @"DataSource=C:\Users\4m\source\repos\SQLite\SQLite\bin\Debug\net7.0-windows10.0.19041.0\win10-x64\pojazd.db";
        public MainPage()
        {
            InitializeComponent();
            conn = new SQLiteConnection(connStr);
            conn.Open();
            string q = "SELECT * FROM pojazd";

            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = q;
            SQLiteDataReader rdr = command.ExecuteReader();


            while (rdr.Read())
            {
                for (var i = 0; i < rdr.FieldCount-1; i++)
                    wierszeLbl.Text+=(rdr[i].ToString() + " ");
                wierszeLbl.Text += "\n";
            }
            conn.Close();


        }

    }
}