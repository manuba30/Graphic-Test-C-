using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphic
{
    internal class functions
    {
        string connectionSql = "Data Source=DESKTOP-COKF0ND\\MYSQL;Initial Catalog=technax;Integrated Security=True;";
        public int id { get; set; }
        public int valeurX { get; set; }
        public int valeurY { get; set; }

        public List<functions> GetAllIds()
        {
            List<functions> ids = new List<functions>();
            SqlConnection con = new SqlConnection(connectionSql);
            string SqlSelect = "Select id,valeur_x,valeur_y from point";
            con.Open();

            SqlCommand cmd = new SqlCommand(SqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    functions register = new functions();
                    register.id = Convert.ToInt32(dr["id"]);
                    register.valeurX = Convert.ToInt32(dr["valeur_x"]);
                    register.valeurY = Convert.ToInt32(dr["valeur_y"]);
                }
            }
            return ids;
        }

        public functions GetChartInfo(int id)
        {
            SqlConnection con = new SqlConnection(connectionSql);
            string SqlSelect = "Select id,valeur_x,valeur_y from point where id = " + id ;
            con.Open();

            SqlCommand cmd = new SqlCommand(SqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();

            functions points = new functions();
            if (dr != null)
            {
                while (dr.Read())
                {
                    functions register = new functions();
                    //register.id = Convert.ToInt32(dr["id"]);
                    register.valeurX = Convert.ToInt32(dr["valeur_x"]);
                    register.valeurY = Convert.ToInt32(dr["valeur_y"]);
                }
            }
            return points;
        }

    }
        
    }
