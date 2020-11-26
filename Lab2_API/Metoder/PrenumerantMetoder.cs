using Labb2_API.Modeller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Labb2_API.Metoder
{
    public class PrenumerantMetoder
    {
        public List<PrenumerantModell> GetPrenumeranter(out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection();

            dbConnection.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Prenumeranter;Integrated Security=True;";

            String sqlstring = "SELECT * FROM tbl_subscribers;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<PrenumerantModell> Premlista = new List<PrenumerantModell>();

            try
            {
                dbConnection.Open();

                myAdapter.Fill(myDS, "subs");

                int count = 0;
                int i = 0;

                count = myDS.Tables["subs"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        PrenumerantModell pm = new PrenumerantModell();

                        pm.ID = Convert.ToInt32(myDS.Tables["subs"].Rows[i]["sub_ID"]);
                        pm.Name = myDS.Tables["subs"].Rows[i]["sub_name"].ToString();
                        pm.Phonenumber = myDS.Tables["subs"].Rows[i]["sub_phonenumber"].ToString();
                        pm.DelAdress = myDS.Tables["subs"].Rows[i]["sub_delAdress"].ToString();
                        pm.Zipcode = Convert.ToInt32(myDS.Tables["subs"].Rows[i]["sub_zipcode"]);
                        pm.Town = myDS.Tables["subs"].Rows[i]["sub_town"].ToString();

                        i++;
                        Premlista.Add(pm);
                    }
                    errormsg = "";
                    return Premlista;
                }
                else
                {
                    errormsg = "Kan inte hämta prenumeranter";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public List<PrenumerantModell> GetEnPrenumerant(int id, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection();

            dbConnection.ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Prenumeranter;Integrated Security=True;";

            String sqlstring = "SELECT * FROM tbl_subscribers WHERE sub_ID = @id;";
            SqlCommand dbCommand = new SqlCommand(sqlstring, dbConnection);

            SqlDataAdapter myAdapter = new SqlDataAdapter(dbCommand);
            DataSet myDS = new DataSet();

            List<PrenumerantModell> Premlista = new List<PrenumerantModell>();

            try
            {
                dbConnection.Open();

                myAdapter.Fill(myDS, "subs");

                int count = 0;
                int i = 0;

                count = myDS.Tables["subs"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        PrenumerantModell pm = new PrenumerantModell();

                        pm.ID = Convert.ToInt32(myDS.Tables["subs"].Rows[i]["sub_ID"]);
                        pm.Name = myDS.Tables["subs"].Rows[i]["sub_name"].ToString();
                        pm.Phonenumber = myDS.Tables["subs"].Rows[i]["sub_phonenumber"].ToString();
                        pm.DelAdress = myDS.Tables["subs"].Rows[i]["sub_delAdress"].ToString();
                        pm.Zipcode = Convert.ToInt32(myDS.Tables["subs"].Rows[i]["sub_zipcode"]);
                        pm.Town = myDS.Tables["subs"].Rows[i]["sub_town"].ToString();

                        i++;
                        Premlista.Add(pm);
                    }
                    errormsg = "";
                    return Premlista;
                }
                else
                {
                    errormsg = "Kan inte hämta prenumeranter";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}