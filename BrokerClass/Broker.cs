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
            command.Parameters.AddWithValue("@kategorija", polaznik.Kategorija.ToString());

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
            command.Parameters.AddWithValue("@kategorija", polaznik.Kategorija.ToString());
            command.Parameters.AddWithValue("@idPolaznika", polaznik.IdPolaznika);

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            return true;
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
        public bool UpdateInstruktora(Instruktor instruktor)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Instruktor SET Ime = @ime, Prezime = @prezime, " +
                "Kategorija = @kategorija " +
                "WHERE IdInstruktora = @idInstruktora";

            command.Parameters.AddWithValue("@ime", instruktor.Ime);
            command.Parameters.AddWithValue("@prezime", instruktor.Prezime);
            command.Parameters.AddWithValue("@kategorija", instruktor.Kategorija.ToString());
            command.Parameters.AddWithValue("@idInstruktora", instruktor.IdInstruktora);

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            return true;
        }
        
        public Instruktor VratiInstruktora(Instruktor instruktor)
        {
            throw new NotImplementedException();
        }
        
        public bool ObrisiInstruktora(Instruktor instruktor)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE from Instruktor Where IdInstruktora = @idInstruktora";
            command.Parameters.AddWithValue("@idInstruktora", instruktor.IdInstruktora);

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Instruktor> VratiInstruktore()
        {
            List<Instruktor> instruktori = new List<Instruktor>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from Instruktor";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    instruktori.Add(new Instruktor()
                    {
                        IdInstruktora = (int)reader["IdInstruktora"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader["Kategorija"]),
                    });
                }
            }

            return instruktori;
        }
        #endregion

    }
}
