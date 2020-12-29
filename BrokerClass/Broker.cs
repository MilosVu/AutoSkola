using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerClass
{
    public class Broker
    {

        private SqlConnection connection;

        public Broker()
        {
            this.connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoSkola;Integrated Security=True;Connect Timeout=30;");
        }

        #region Konekcija
        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }
        #endregion

        #region Polaznik
        public bool KreirajPolaznika(Polaznik polaznik)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT into Polaznik VALUES(@ime,@prezime," +
                "@datumRodjenja, @kategorija)";

            command.Parameters.AddWithValue("@ime", polaznik.Ime);
            command.Parameters.AddWithValue("@prezime", polaznik.Prezime);
            command.Parameters.AddWithValue("@datumRodjenja", polaznik.DatumRodjenja);
            command.Parameters.AddWithValue("@kategorija", VratiKategoriju(polaznik.Kategorija));

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePolaznika(Polaznik polaznik)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Polaznik SET Ime = @ime, Prezime = @prezime, " +
                "DatumRodjenja = @datumRodjenja, Kategorija = @kategorija " +
                "WHERE IdPolaznika = @idPolaznika";

            command.Parameters.AddWithValue("@ime", polaznik.Ime);
            command.Parameters.AddWithValue("@prezime", polaznik.Prezime);
            command.Parameters.AddWithValue("@datumRodjenja", polaznik.DatumRodjenja);
            command.Parameters.AddWithValue("@kategorija", VratiKategoriju(polaznik.Kategorija));
            command.Parameters.AddWithValue("@idPolaznika", polaznik.IdPolaznika);

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            return true;
        }

        private string VratiKategoriju(Kategorija kategorija)
        {
            return kategorija.ToString();
        }

        public List<Polaznik> VratiPolaznike()
        {
            List<Polaznik> polaznici = new List<Polaznik>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from Polaznik";

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    polaznici.Add(new Polaznik()
                    {
                        IdPolaznika = (int) reader["IdPolaznika"],
                        Ime = (string) reader["Ime"],
                        Prezime = (string) reader["Prezime"],
                        Kategorija = (Kategorija) Enum.Parse(typeof(Kategorija),(string) reader["Kategorija"]),
                        DatumRodjenja = (DateTime)reader["DatumRodjenja"]
                });
                }
            }

            return polaznici;
        }

        public Polaznik VratiPolaznika(Polaznik polaznik)
        {
            Polaznik NovPolaznik = new Polaznik();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from Polaznik Where Ime = @ime AND Prezime = @Prezime";
            command.Parameters.AddWithValue("@ime", polaznik.Ime);
            command.Parameters.AddWithValue("@prezime", polaznik.Prezime);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    NovPolaznik = new Polaznik()
                    {
                        IdPolaznika = (int) reader["IdPolaznika"],
                        Ime = (string) reader["Ime"],
                        Prezime = (string) reader["Prezime"],
                        Kategorija = (Kategorija) Enum.Parse(typeof(Kategorija),(string) reader["Kategorija"]),
                        DatumRodjenja = (DateTime)reader["DatumRodjenja"]
                    };
                }
            }
            Console.WriteLine(NovPolaznik);
            return NovPolaznik;
        }

        public bool ObrisiPolaznika(Polaznik polaznik)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE from Polaznik Where IdPolaznika = @idPolaznika" ;
            command.Parameters.AddWithValue("@idPolaznika", polaznik.IdPolaznika);

            if(command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Instruktor

        #endregion

    }
}
