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





            int nr = 1;
            conn = new SQLiteConnection(connStr);
            conn.Open();
            string q = "SELECT * FROM pojazd";

            SQLiteCommand command = conn.CreateCommand();
            command.CommandText = q;
            SQLiteDataReader rdr = command.ExecuteReader();
            rdr.Read();
            wierszeLbl.Text += (rdr[0].ToString() + ". "+
                                rdr[1].ToString() + " "+
                                rdr[2].ToString() + " "+
                                rdr[3].ToString() + " "+
                                rdr[4].ToString() + "r "+
                                rdr[5].ToString() + "km "+
                                rdr[6].ToString() + "zł ");
            pojazdImg.Source = (rdr[7].ToString()+".png");

            /*
            while (rdr.Read())
            {
                for (var i = 0; i < rdr.FieldCount-1; i++)
                    wierszeLbl.Text+=(rdr[i].ToString() + " ");
                wierszeLbl.Text += "\n";
            }
            */
            conn.Close();


        }

        private void OnPoprzedniClicked(object sender, EventArgs e)
        {
            nr++;
            wierszeLbl.Text += (rdr[0].ToString() + ". " +
                    rdr[1].ToString() + " " +
                    rdr[2].ToString() + " " +
                    rdr[3].ToString() + " " +
                    rdr[4].ToString() + "r " +
                    rdr[5].ToString() + "km " +
                    rdr[6].ToString() + "zł ");
            pojazdImg.Source = (rdr[7].ToString() + ".png");
        }

        private void OnNastepnyClicked(object sender, EventArgs e)
        {

        }

        private void OnWybranyClicked(object sender, EventArgs e)
        {

        }

        private void OnUsunClicked(object sender, EventArgs e)
        {

        }


    }
}