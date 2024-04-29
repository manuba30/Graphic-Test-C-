using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphic
{
    public partial class Form1 : Form
    {
        // Properties to keep track of current X and Y values
        public int CurrentY { get; set; }
        public int CurrentX { get; set; }

        // Class to represent a curve
        public class Curve
        {
            public string Name { get; set; } // Name of the curve
            public List<Point> Points { get; set; } // List of points in the curve
            public int Id { get; set; } // Identifier for the curve

            // Constructor to initialize the list of points
            public Curve()
            {
                Points = new List<Point>();
            }
        }

        // Instance of the Curve class
        public Curve Courbe { get; set; }

        // Connection string for database
        private string _connectionString = "Data Source=DESKTOP-COKF0ND\\MYSQL;Initial Catalog=technax;Integrated Security=True;Encrypt=False;";

        private Timer timer; // Timer for updating chart

        // Class to represent a point in the chart
        class ChartPoint
        {
            public int XValue { get; set; }
            public int YValue { get; set; }

            public ChartPoint(int x, int y)
            {
                XValue = x;
                YValue = y;
            }
        }

        // Form constructor
        public Form1()
        {
            InitializeComponent();
            Courbe = new Curve(); // Initialize the curve object
            ConfigureChart(); // Configure the chart
        }

        // Method to configure the chart
        private void ConfigureChart()
        {
            CurrentX = 0;
            CurrentY = 0;

            // Clear existing series and add a new one
            chart1.Series.Clear();
            chart1.Series.Add("Values");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.DataSource = Courbe.Points; // Set data source for the chart
        }

        // Method to start the timer for updating the chart
        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += UpdateChartWithNewPoint;
            timer.Start();
        }

        // Method to update the chart with a new point
        private void UpdateChartWithNewPoint(object sender, EventArgs e)
        {
            CurrentX += 500; // Increment X value
            int newY;
            if (int.TryParse(txtValue.Text, out newY))
            {
                CurrentY = newY;
                // Add the point to the Curve object
                Courbe.Points.Add(new Point(CurrentX, CurrentY));
                // Add the point to the chart
                chart1.Series[0].Points.AddXY(CurrentX, CurrentY);
            }
        }

        // Event handler for adding a new value manually
        private void btnNewValue_Click(object sender, EventArgs e)
        {
            CurrentY = Convert.ToInt32(txtValue.Text);
            // Add the point to the Curve object
            Courbe.Points.Add(new Point(CurrentX, CurrentY));
            // Add the point to the chart
            chart1.Series[0].Points.AddXY(CurrentX, CurrentY);
        }

        // Event handler for starting the timer
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        // Event handler for saving the data to the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer

            Courbe.Name = txtNom.Text; // Set the name of the curve
            chart1.Titles.Add(Courbe.Name); // Add title to the chart

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                // Create SQL command for inserting data
                SqlCommand cmd = new SqlCommand("CreateData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nom", Courbe.Name)); // Add name parameter

                foreach (var point in Courbe.Points)
                {
                    // Execute SQL function to save each point
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@nom", Courbe.Name)); // Correctly pass the name parameter
                    cmd.Parameters.Add(new SqlParameter("@valeurX", point.X)); // X value parameter
                    cmd.Parameters.Add(new SqlParameter("@valeurY", point.Y)); // Y value parameter
                    cmd.Parameters.Add(new SqlParameter("@idCourbe", Courbe.Id)); // Assuming you retrieve the curve ID somehow

                    cmd.ExecuteNonQuery(); // Execute the command
                }
            }

            MessageBox.Show("Data saved successfully.");
        }

        // Event handler for viewing results
        private void btnResults_Click(object sender, EventArgs e)
        {
            Results results = new Results(); // Open results form
            results.ShowDialog();
            this.Close(); // Close current form
        }

        // Event handler for stopping the timer
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }
        }

        // Event handler for saving the data to the database (alternative method)
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }

            Courbe.Name = txtNom.Text; // Set the name of the curve
            chart1.Titles.Add(Courbe.Name); // Add title to the chart

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                // Insert the curve and retrieve the ID
                SqlCommand cmdInsertCurve = new SqlCommand("INSERT INTO courbe (nom) VALUES (@nom); SELECT SCOPE_IDENTITY();", con);
                cmdInsertCurve.Parameters.AddWithValue("@nom", Courbe.Name);
                int curveId = Convert.ToInt32(cmdInsertCurve.ExecuteScalar());

                // Insert points associated with the curve
                SqlCommand cmdInsertPoint = new SqlCommand("INSERT INTO point (valeur_x, valeur_y, id_courbe) VALUES (@valeurX, @valeurY, @idCourbe);", con);
                cmdInsertPoint.Parameters.Add("@valeurX", SqlDbType.Int);
                cmdInsertPoint.Parameters.Add("@valeurY", SqlDbType.Int);
                cmdInsertPoint.Parameters.Add("@idCourbe", SqlDbType.Int);

                foreach (var point in Courbe.Points)
                {
                    // Set parameter values
                    cmdInsertPoint.Parameters["@valeurX"].Value = point.X;
                    cmdInsertPoint.Parameters["@valeurY"].Value = point.Y;
                    cmdInsertPoint.Parameters["@idCourbe"].Value = curveId;

                    // Execute point insertion
                    cmdInsertPoint.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data saved successfully.");
        }
    }
}
