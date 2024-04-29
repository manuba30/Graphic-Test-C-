using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Results : Form
    {
        // Dictionary to map curve IDs to their corresponding information
        private Dictionary<int, Info> idInfoMap = new Dictionary<int, Info>();

        // Class to store information related to a curve
        public class Info
        {
            public List<int> ValeurXList { get; set; } // List to store X values
            public List<int> ValeurYList { get; set; } // List to store Y values

            // Constructor to initialize the lists
            public Info()
            {
                ValeurXList = new List<int>();
                ValeurYList = new List<int>();
            }
        }

        // SQL connection string
        string connectionSql = "Data Source=DESKTOP-COKF0ND\\MYSQL;Initial Catalog=technax;Integrated Security=True;";

        // Form constructor
        public Results()
        {
            InitializeComponent();
            this.FormClosing += Results_FormClosing; // Associate the FormClosing event
            dataGridViewIds.SelectionChanged += dataGridViewIds_SelectionChanged; // Associate the SelectionChanged event for DataGridView
            FillGrid(); // Fill the DataGridView
            SeeResults(); // Show the initial results
        }

        // Method to fill the DataGridView
        private void FillGrid()
        {
            // Unbind the DataGridView temporarily
            dataGridViewIds.DataSource = null;

            // Clear existing data
            dataGridViewIds.Rows.Clear();

            // Retrieve data from the database
            GetAll();

            // Populate the DataGridView
            dataGridViewIds.DataSource = idInfoMap.Values.ToList();
        }

        // Method to retrieve data from the database
        public void GetAll()
        {
            SqlConnection con = new SqlConnection(connectionSql);
            string SqlSelect = "Select id_courbe, valeur_x, valeur_y from point";
            con.Open();

            SqlCommand cmd = new SqlCommand(SqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    int idCourbe = Convert.ToInt32(dr["id_courbe"]);

                    // Check if there's already an Info instance for this id_courbe
                    if (!idInfoMap.ContainsKey(idCourbe))
                    {
                        // If not, create a new Info instance and add it to the dictionary
                        Info newInfo = new Info();
                        idInfoMap.Add(idCourbe, newInfo);
                    }

                    // Add valeurX and valeurY values to the corresponding instance
                    Info info = idInfoMap[idCourbe];
                    info.ValeurXList.Add(Convert.ToInt32(dr["valeur_x"]));
                    info.ValeurYList.Add(Convert.ToInt32(dr["valeur_y"]));
                }
            }

            con.Close();
        }

        // Method to display the results
        public void SeeResults()
        {
            // Check if there is a selected row in the DataGridView
            if (dataGridViewIds.CurrentRow != null)
            {
                // Get the selected index from the current row in the DataGridView
                int selectedIndex = dataGridViewIds.CurrentRow.Index;

                // Get the corresponding Info instance for the selected index
                Info selectedInfo = idInfoMap.Values.ElementAt(selectedIndex);

                // Show the chart with the selected information
                ChartResult chartResult = new ChartResult(selectedInfo);
                chartResult.Show();
            }
        }

        // Event handler for the button to view chart
        private void btnChart_Click(object sender, EventArgs e)
        {
            // If you want to create a ChartResult without specific data
            ChartResult result = new ChartResult(null);
            result.ShowDialog();
            this.Close();
        }

        // Event handler for the button to run tests
        private void btnTests_Click(object sender, EventArgs e)
        {
            Form1 test = new Form1();
            test.ShowDialog();
            this.Close();
        }

        // Event handler for form activation
        private void Results_Activated(object sender, EventArgs e)
        {
            FillGrid();
        }

        // Event handler for DataGridView selection change
        private void dataGridViewIds_SelectionChanged(object sender, EventArgs e)
        {
            SeeResults();
        }

        // Event handler for form closing
        private void Results_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent opening multiple instances of Results
            if (Application.OpenForms.OfType<Results>().Any(form => form != this))
            {
                e.Cancel = true; // Cancel closing if there are other instances open
            }
        }
    }
}
