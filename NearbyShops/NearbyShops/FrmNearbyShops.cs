using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //Add this as a reference to the project before using
using System.Data.SqlClient;

namespace NearbyShops {
    public partial class FrmNearbyShops : Form {

        #region Class Variables
        /// <summary>
        /// Create connection object and connection string for use 
        /// throughout the app
        /// </summary>
        SqlConnection connection;
        string connectionString;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize the windows form and set connection string to be used throughout the app
        /// </summary>
        public FrmNearbyShops() {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["NearbyShops.Properties.Settings.LocationsConnectionString"].ConnectionString;
        }
        #endregion

        #region Form Load
        /// <summary>
        /// When form loads, populate categories since function is find by default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNearbyShops_Load(object sender, EventArgs e) {
            PopulateCategories();
        }
        #endregion

        #region Custom Functions
        /// <summary>
        /// Custom functions to load and manipulate data
        /// </summary>
        private void PopulateCategories() {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Category", connection)) {
                DataTable categoryTable = new DataTable();
                adapter.Fill(categoryTable);

                cboCategory.DisplayMember = "Category";
                cboCategory.ValueMember = "Id";
                cboCategory.DataSource = categoryTable;
            }
        }
        #endregion

        #region Action Function Calls
        /// <summary>
        /// Action function calls that fire based on selected function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRunCalculation_Click(object sender, EventArgs e) {
            if (rdoFind.Checked) {
                CalculateResults();
            } else if (rdoAdd.Checked) {
                AddRecord();
            } else if (rdoUpdate.Checked){
                updateRecord();
            } else if (rdoDelete.Checked) {
                deleteRecord();
            }
            
        }
        #endregion

        #region Action Functions
        /// <summary>
        /// Action functions that show, add, update and delete records
        /// </summary>
        private void CalculateResults() {
            var category    = cboCategory.SelectedValue.ToString();
            var lat         = txtLat.Text;
            var lng         = txtLng.Text;
            var radius      = numRadius.Value;
            var single      = (chkSingle.Checked) ? 1 : 0;
            var query       = "EXEC Spherical_Calculation @category = " + category + ", @lat = " + lat + ", @lng = " + lng + ", @radius = " + radius + ", @single = " + single;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection)) {
                DataTable resultTable = new DataTable();
                adapter.Fill(resultTable);
                dgvResults.DataSource = resultTable;
                dgvResults.Columns[0].Visible = false;
                dgvResults.ReadOnly = true;
                rdoUpdate.Enabled = true;
                rdoDelete.Enabled = true;
                //DataGridViewElementStates states = DataGridViewElementStates.None;
                //dgvResults.ScrollBars = ScrollBars.None;
                //DataGridViewColumn column0 = dgvResults.Columns[0];
                //column0.Width = 90;
                //DataGridViewColumn column1 = dgvResults.Columns[1];
                //column1.Width = 345;
                //DataGridViewColumn column2 = dgvResults.Columns[2];
                //column2.Width = 150;
                //var totalHeight = dgvResults.Rows.GetRowsHeight(states) + dgvResults.ColumnHeadersHeight;
                //totalHeight += dgvResults.Rows.Count * 4;  // a correction I need
                //var totalWidth = dgvResults.Columns.GetColumnsWidth(states) + dgvResults.RowHeadersWidth;
                //dgvResults.ClientSize = new Size(totalWidth, totalHeight);

                dgvResults.Visible = true;
            }
        }

        private void AddRecord() {
            var category    = txtCategory.Text;
            var lat         = txtLat.Text;
            var lng         = txtLng.Text;
            var location    = txtLocation.Text;
            var address     = txtAddress.Text;

            string categoryQuery = "INSERT INTO Category output INSERTED.ID VALUES (@category)";
            string locationQuery = "INSERT INTO Location VALUES (@location,@address,@lat,@lng,@cid)";
            int cid;
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand categoryCommand = new SqlCommand(categoryQuery, connection)) {
                connection.Open();
                categoryCommand.Parameters.AddWithValue("@category", category);
                cid = (int)categoryCommand.ExecuteScalar();
                connection.Close();
            }

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand locationCommand = new SqlCommand(locationQuery, connection)) {
                connection.Open();
                locationCommand.Parameters.AddWithValue("@location", location);
                locationCommand.Parameters.AddWithValue("@address", address);
                locationCommand.Parameters.AddWithValue("@lat", lat);
                locationCommand.Parameters.AddWithValue("@lng", lng);
                locationCommand.Parameters.AddWithValue("@cid", cid);
                locationCommand.ExecuteNonQuery();
                connection.Close();
            }
            txtCategory.Text = "";
            txtLat.Text = "";
            txtLng.Text = "";
            txtLocation.Text = "";
            txtAddress.Text = "";
            PopulateCategories();
            MessageBox.Show(location + " was successfully added!");
        }

        private void updateRecord() {
            if (dgvResults.SelectedCells.Count > 0) {
                int selectedRowIndex = dgvResults.SelectedCells[0].RowIndex;
                int locationId = (int)dgvResults.Rows[selectedRowIndex].Cells[0].Value;

                var category = txtCategory.Text;
                var lat = txtLat.Text;
                var lng = txtLng.Text;
                var location = txtLocation.Text;
                var address = txtAddress.Text;

                string categoryQuery = "INSERT INTO Category output INSERTED.ID VALUES (@category)";
                string locationQuery = "UPDATE Location SET Location = @location, Address = @address, Latitude =  @lat, Longitude = @lng, CategoryId = @cId WHERE Id = @locationID";
                int cid;
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand categoryCommand = new SqlCommand(categoryQuery, connection)) {
                    connection.Open();
                    categoryCommand.Parameters.AddWithValue("@category", category);
                    cid = (int)categoryCommand.ExecuteScalar();
                    connection.Close();
                }

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand locationCommand = new SqlCommand(locationQuery, connection)) {
                    connection.Open();
                    locationCommand.Parameters.AddWithValue("@location", location);
                    locationCommand.Parameters.AddWithValue("@address", address);
                    locationCommand.Parameters.AddWithValue("@lat", lat);
                    locationCommand.Parameters.AddWithValue("@lng", lng);
                    locationCommand.Parameters.AddWithValue("@cid", cid);
                    locationCommand.Parameters.AddWithValue("@locationId", locationId);
                    locationCommand.ExecuteNonQuery();
                    connection.Close();
                }
                txtCategory.Text = "";
                txtLat.Text = "";
                txtLng.Text = "";
                txtLocation.Text = "";
                txtAddress.Text = "";
                PopulateCategories();
                MessageBox.Show(location + " was successfully updated!");
            }
        }

        private void deleteRecord() {
            if (dgvResults.SelectedCells.Count > 0) {
                int selectedRowIndex = dgvResults.SelectedCells[0].RowIndex;
                int locationId = (int)dgvResults.Rows[selectedRowIndex].Cells[0].Value;
                string location = dgvResults.Rows[selectedRowIndex].Cells[1].Value.ToString();

                DialogResult dr = MessageBox.Show("Are you sure you want to permanently remove " + location + "?", "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    string locationQuery = "DELETE FROM Location WHERE Id = @locationID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand locationCommand = new SqlCommand(locationQuery, connection)) {
                        connection.Open();
                        locationCommand.Parameters.AddWithValue("@locationId", locationId);
                        locationCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    PopulateCategories();
                    MessageBox.Show("Record was successfully deleted!");
                }
            }
        }
        #endregion

        #region State Changed
        /// <summary>
        /// These functions fire when a state changes
        /// ie radio button change or gridview row change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rdoAdd_CheckedChanged(object sender, EventArgs e) {
            if (rdoAdd.Checked) {
                txtLat.Text = "";
                txtLng.Text = "";
                btnRunCalculation.Text = "Add";
                cboCategory.Visible = false;
                txtCategory.Visible = true;
                lblAddress.Visible = true;
                txtAddress.Visible = true;
                lblRadius.Visible = false;
                numRadius.Visible = false;
                lblSingle.Visible = false;
                chkSingle.Visible = false;
                lblLocation.Visible = true;
                txtLocation.Visible = true;
            }
        }

        private void rdoFind_CheckedChanged(object sender, EventArgs e) {
            if (rdoFind.Checked) {
                txtLat.Text = "45.3776091";
                txtLng.Text = "-75.7230555";
                btnRunCalculation.Text = "Find";
                cboCategory.Visible = true;
                txtCategory.Visible = false;
                lblAddress.Visible = false;
                txtAddress.Visible = false;
                lblRadius.Visible = true;
                numRadius.Visible = true;
                lblSingle.Visible = true;
                chkSingle.Visible = true;
                lblLocation.Visible = false;
                txtLocation.Visible = false;
            }
        }

        private void rdoUpdate_CheckedChanged(object sender, EventArgs e) {
            if (rdoUpdate.Checked) {
                btnRunCalculation.Text = "Update";
                txtLat.Text = "";
                txtLng.Text = "";
                cboCategory.Visible = false;
                txtCategory.Visible = true;
                lblAddress.Visible = true;
                txtAddress.Visible = true;
                lblRadius.Visible = false;
                numRadius.Visible = false;
                lblSingle.Visible = false;
                chkSingle.Visible = false;
                lblLocation.Visible = true;
                txtLocation.Visible = true;
            }
        }

        private void rdoDelete_CheckedChanged(object sender, EventArgs e) {
            if (rdoDelete.Checked) {
                btnRunCalculation.Text = "Delete";
            }
            
        }

        private void dgvResults_SelectionChanged(object sender, EventArgs e) {
            //if (dgvResults.SelectedCells.Count > 0 && rdoUpdate.Checked) {
            //    int selectedRowIndex = dgvResults.SelectedCells[0].RowIndex;
           //     MessageBox.Show(dgvResults.Rows[selectedRowIndex].Cells[0].Value.ToString());
           // }
        }
        #endregion
    }
}
