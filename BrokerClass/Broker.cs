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
                        DatumRodjenja = (DateTime) reader["DatumRodjenja"]
                });
                }
            }
            return polaznici;
            //return kategorija == null ? polaznici : polaznici.FindAll(pol => pol.Kategorija == kategorija); ;
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

        public List<Instruktor> VratiInstruktore(Kategorija? kategorija)
        {
            List<Instruktor> instruktori = new List<Instruktor>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from Instruktor";

            if (kategorija != null)
            {
                command.CommandText += " WHERE Kategorija = @kategorija";
                command.Parameters.AddWithValue("@kategorija", kategorija.ToString());
            }

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


        #region Voznje
        public bool KreirajVoznju(Voznja voznja)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT into Voznja VALUES(@idPolaznika,@idInstruktora," +
                "@datum, @brojCasa, @realizovan, @idAutomobila)";

            command.Parameters.AddWithValue("@idPolaznika", voznja.Polaznik.IdPolaznika);
            command.Parameters.AddWithValue("@idInstruktora", voznja.Instruktor.IdInstruktora);
            command.Parameters.AddWithValue("@datum", voznja.Datum);
            command.Parameters.AddWithValue("@brojCasa", voznja.BrojCasa);
            command.Parameters.AddWithValue("@realizovan", voznja.Realizovan);
            command.Parameters.AddWithValue("@idAutomobila", voznja.Automobil.IdAutomobila);

            if (command.ExecuteNonQuery() != 1)
            {
                return false;
            }
            return true;
        }

        public List<Voznja> VratiVoznje(Kategorija? kategorija)
        {
            List<Voznja> voznje = new List<Voznja>();
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * from Voznja as v " +
                "join Polaznik as p on (v.IdPolaznika = p.IdPolaznika) " +
                "join Instruktor i on (v.IdInstruktora = i.IdInstruktora) " +
                "join Automobil a on (v.IdAutomobila = a.IdAutomobila)";
            
            /*if(kategorija != null)
            {
                command.CommandText += " WHERE Kategorija = @kategorija";
                command.Parameters.AddWithValue("@kategorija", kategorija);
            }*/

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    voznje.Add(new Voznja()
                    {
                        Polaznik = new Polaznik()
                        {
                            IdPolaznika = (int)reader[0],
                            Ime = (string)reader[7],
                            Prezime = (string)reader[8],
                            Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader[10]),
                            DatumRodjenja = (DateTime)reader[9]
                        },
                        Instruktor = new Instruktor()
                        {
                            IdInstruktora = (int)reader[1],
                            Ime = (string)reader[12],
                            Prezime = (string)reader[13],
                            Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader[14]),
                        },
                        Automobil = new Automobil()
                        {
                            IdAutomobila = (int) reader[5],
                            Marka = (string) reader[16],
                            Model = (string) reader[17],
                            Godiste = (int) reader[19],
                            Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader[18])
                        },
                        BrojCasa = (int) reader[3],
                        Datum = (DateTime) reader[2],
                        Realizovan = (bool) reader[4],
                        Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader["Kategorija"]),
                    });
                }
            }

            return kategorija == null ? voznje : voznje.FindAll(voz => voz.Kategorija == kategorija);
        }
        
        #endregion


        #region Automobili
        public List<Automobil> VratiAutomobile(Kategorija? kategorija)
        {
            List<Automobil> automobili= new List<Automobil>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * from Automobil";

            if(kategorija != null)
            {
                command.CommandText += " WHERE Kategorija = @kategorija";
                command.Parameters.AddWithValue("@kategorija", kategorija.ToString());
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    automobili.Add(new Automobil()
                    {
                        IdAutomobila = (int) reader["IdAutomobila"],
                        Marka = (string) reader["Marka"],
                        Model = (string) reader["Model"],
                        Godiste = (int) reader["Godiste"],
                        Kategorija = (Kategorija)Enum.Parse(typeof(Kategorija), (string)reader["Kategorija"])
                    });
                }
            }

            return automobili;
        }

        #endregion


        #region

        public bool KreirajGrupuZaPolaganje(List<Polaznik> polaznici)
        {
            throw new NotImplementedException();
        }

        public List<GrupaZaPolaganje> VratiGrupeZaPolaganje()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
