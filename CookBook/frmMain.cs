using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookBook
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionString;
        
        public frmMain()
        {
            InitializeComponent();
            btnAddReteta.Click +=btnAddReteta_Click;
            btnUpdateNumeReteta.Click +=btnUpdateNumeReteta_Click;
            btnAdaugaInReteta.Click +=btnAdaugaInReteta_Click;
            connectionString = ConfigurationManager.ConnectionStrings["CookBook.Properties.Settings.CookBookConnectionString"].ConnectionString;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateRetete();
            PopulateToateIngredientele();
        }

        private void PopulateRetete()
        {
            using (connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reteta", connection))
            {
           
                DataTable retetaTable = new DataTable();
                adapter.Fill(retetaTable);

                lstRetete.DisplayMember = "Nume";
                lstRetete.ValueMember = "Id";
                lstRetete.DataSource = retetaTable;
            }
        }


        private void PopulateToateIngredientele()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstToateIngredientele.DisplayMember = "Nume";
                lstToateIngredientele.ValueMember = "Id";
                lstToateIngredientele.DataSource = ingredientTable;
            }
        }


        private void PopulateIngrediente()
        {
            string query = "SELECT a.Nume FROM Ingredient a " +
                "INNER JOIN RetetaIngredient b ON a.Id = b.IngredientId " +
                "WHERE b.RetetaId = @ReteteId";
            
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ReteteId", lstRetete.SelectedValue);
                
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstIngrediente.DisplayMember = "Nume";
                lstIngrediente.ValueMember = "Id";
                lstIngrediente.DataSource = ingredientTable;
            }
        }


        private void lstRetete_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngrediente();
        }

        private void btnAddReteta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Reteta VALUES (@NumeReteta, 80, 'Mix toate, pe rand')";
            
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@NumeReteta", txtNumeReteta.Text);

                command.ExecuteNonQuery();
            }

            PopulateRetete();

        }

        private void btnUpdateNumeReteta_Click(object sender, EventArgs e)
        {
         string query = "UPDATE Reteta SET Nume = @NumeReteta WHERE Id = @ReteteId";
            
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@NumeReteta", txtNumeReteta.Text);
                command.Parameters.AddWithValue ("@ReteteId", lstRetete.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateRetete();
        }

        private void btnAdaugaInReteta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RetetaIngredient VALUES (@ReteteId, @IngredientId)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ReteteId", lstRetete.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", lstToateIngredientele.SelectedValue);

                command.ExecuteNonQuery();
            }

            PopulateRetete();

        }
    }
}
