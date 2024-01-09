using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GunshopInventorySystem.Properties
{
    public partial class Firearms : Form
    {
        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=gunshop_inventory_db;User=root;Password=;");
        public Firearms()
        {
            InitializeComponent();
            LoadFirearmsData();
        }

        private void LoadFirearmsData()
        {
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Firearms", connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Sidearm_DataV.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading firearm data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO firearms (firearm_id, firearm_name, price, quantityinstock) VALUES (@ID,@Name,@Price,@Quantity)", connection))
                {
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(ID_Tbx.Text));
                    cmd.Parameters.AddWithValue("@Name", Name_Tbx.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(Price_Tbx.Text));
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(Quantity_Tbx.Text));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding firearm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            LoadFirearmsData();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure a row is selected in the data grid
                if (Sidearm_DataV.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = Sidearm_DataV.SelectedRows[0];

                    // Use the value in the first column (assuming it's the ID column) to identify the row
                    int firearmId = Convert.ToInt32(selectedRow.Cells["firearm_id"].Value);

                    // Update the textboxes with the values from the selected row
                    Name_Tbx.Text = selectedRow.Cells["firearm_name"].Value.ToString();
                    Price_Tbx.Text = selectedRow.Cells["price"].Value.ToString();
                    Quantity_Tbx.Text = selectedRow.Cells["quantityinstock"].Value.ToString();

                    // Now you can use these values in the update query
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE firearms SET firearm_name = @Name, price = @Price, quantityinstock = @Quantity WHERE firearm_id = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", firearmId);
                        cmd.Parameters.AddWithValue("@Name", Name_Tbx.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(Price_Tbx.Text));
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(Quantity_Tbx.Text));

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Firearm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            LoadFirearmsData();
        }

        private void Replace_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure a row is selected in the data grid
                if (Sidearm_DataV.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = Sidearm_DataV.SelectedRows[0];

                    // Use the value in the first column (assuming it's the ID column) to identify the row
                    int firearmId = Convert.ToInt32(selectedRow.Cells["firearm_id"].Value);

                    // Update the textboxes with the values from the selected row
                    Name_Tbx.Text = selectedRow.Cells["firearm_name"].Value.ToString();
                    Price_Tbx.Text = selectedRow.Cells["price"].Value.ToString();
                    Quantity_Tbx.Text = selectedRow.Cells["quantityinstock"].Value.ToString();

                    // Now you can use these values in the replace query
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE firearms SET firearm_name = @Name, price = @Price, quantityinstock = @Quantity, stock_status = 'In Stock' WHERE firearm_id = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", firearmId);
                        cmd.Parameters.AddWithValue("@Name", Name_Tbx.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(Price_Tbx.Text));
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(Quantity_Tbx.Text));

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to replace data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error replacing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            LoadFirearmsData();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sidearm_DataV.SelectedRows.Count > 0)
                {
                    int selectedFirearmID = Convert.ToInt32(Sidearm_DataV.SelectedRows[0].Cells["firearm_id"].Value);

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE firearms SET stock_status = 'Out of Stock' WHERE firearm_id = @ID", connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", selectedFirearmID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadFirearmsData();
                }
                else
                {
                    MessageBox.Show("Please select a row to mark as 'Out of Stock'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void MainMen_Btn_Click(object sender, EventArgs e)
        {
            MainMenu_Frm MenuFrm = new MainMenu_Frm();
            this.Hide();
            MenuFrm.Show();
        }
    }
}
