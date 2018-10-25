using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static WindowsFormsApp2.DialogProfile;

namespace WindowsFormsApp2
{
    public partial class ProfileAsReferance : Form
    {

        List<string> data = new List<string>();
        string connectionstring = Properties.Settings.Default.connection;
        public int selectedProfile = -1;
        public ProfileAsReferance()
        {
            InitializeComponent();
        }

        private void ProfileAsReferance_Load(object sender, EventArgs e)
        {
            PopulateProfile();
            cb_profile.SelectedIndex = 0;
        }
        private void PopulateProfile()
        {
            cb_profile.Items.Clear();
            string query = "Select * from Profile";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cb_profile.Items.Add(dr["profile"].ToString());
                    data.Add(dr["data"].ToString());
                }
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            selectedProfile = cb_profile.SelectedIndex;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
