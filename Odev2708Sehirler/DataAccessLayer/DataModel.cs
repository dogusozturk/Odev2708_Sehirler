using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }
        public List<Sehirler> GetSehir()
        {
            try
            {
                cmd.CommandText = "SELECT SehirID, Isim FROM Sehirler";
                con.Open();
                List<Sehirler> sehirler = new List<Sehirler>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sehirler.Add(new Sehirler { SehirID = reader.GetInt32(0), Isim = reader.GetString(1) });
                }
                return sehirler;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Ilceler> GetIlce(int SehirID)
        {
            try
            {
                List<Ilceler> Ilceler = new List<Ilceler>();
                cmd.CommandText = "SELECT IlceID, SehirID, Isim FROM Ilceler WHERE SehirID=@SehirID";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@SehirID", SehirID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ilceler.Add(new Ilceler { IlceID = reader.GetInt32(0), SehirID = reader.GetInt32(1), Isim = reader.GetString(2) });
                }
                return Ilceler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
