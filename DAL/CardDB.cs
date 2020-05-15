using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardDB : ICardDB
    {

        public IConfiguration Configuration { get; }
        public CardDB(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\srhmr\\OneDrive\\Bureau\\cours\\HACKATON\\HackatonHevsMagic\\HackatonMagic\\Cards.mdf;Integrated Security=True";
      

        public Card GetCardByName(string name)
        {
            Card card = null;
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [Table] WHERE name LIKE @name";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar, 50).Value = name;

                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            card = new Card();
                            card.name = (string)dr["name"];
                            card.set = (string)dr["set"];
                            card.set_code = (string)dr["set_code"];
                            card.id = (int)dr["id"];
                            if (dr["power"] != DBNull.Value)
                                card.power = (int)dr["power"];

                            if (dr["toughness"] != DBNull.Value)
                                card.tougness = (int)dr["toughness"];

                            if (dr["loyalty"] != DBNull.Value)
                                card.loyalty = (int)dr["loyalty"];

                            if (dr["manacost"] != DBNull.Value)
                                card.manacost = (string)dr["manacost"];

                            if (dr["converted_manacost"] != DBNull.Value)
                                card.converted_manacost = (int)dr["converted_manacost"];

                            if (dr["color"] != DBNull.Value)
                                card.color = (string)dr["color"];

                            if (dr["generated_mana"] != DBNull.Value)
                                card.generated_mana = (string)dr["generated_mana"];

                            if (dr["number"] != DBNull.Value)
                                card.number = (int)dr["number"];

                            if (dr["rarity"] != DBNull.Value)
                                card.rarity = (string)dr["rarity"];

                            if (dr["ability"] != DBNull.Value)
                                card.ability = (string)dr["ability"];

                            
                                
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return card;
        }

    }
    
}
