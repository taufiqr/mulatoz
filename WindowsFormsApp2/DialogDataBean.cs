using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DialogDataBean : Form
    {
        int _id;
        string connectionstring = Properties.Settings.Default.connection;
        bool edit = false;

        public DialogDataBean()
        {
            InitializeComponent();
        }
        public DialogDataBean(int id)
        {
            InitializeComponent();
            _id = id;
            edit = true;
            getSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getSelected()
        {
            string query = "SELECT * FROM Bean WHERE Id=@id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", _id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_beanName.Text = dr["bean_name"].ToString();
                    tb_country.Text = dr["country"].ToString();
                    tb_region.Text = dr["region"].ToString();
                    cb_process.Text = dr["process"].ToString();
                    cb_beanType.Text = dr["bean_type"].ToString();
                    tb_vendor.Text = dr["vendor"].ToString();
                    nud_screenSize.Value = Int32.Parse(dr["screen_size"].ToString());
                    nud_moisture.Value = Int32.Parse(dr["moisture"].ToString());
                    dt_harvest.Value = DateTime.Parse(dr["harvest_date"].ToString());
                    
                }
            }
        }

        private void insertProfile()
        {
            string query = "INSERT INTO Bean (bean_name,bean_type,input_date,country,region,process,screen_size,harvest_date,moisture,vendor) VALUES (@bean_name,@bean_type,@input_date,@country,@region,@process,@screen_size,@harvest_date,@moisture,@vendor)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@bean_name", tb_beanName.Text);
                command.Parameters.AddWithValue("@bean_type", cb_beanType.Text);
                command.Parameters.AddWithValue("@input_date", DateTime.Now.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@country", tb_country.Text);
                command.Parameters.AddWithValue("@region", tb_region.Text);
                command.Parameters.AddWithValue("@process", cb_process.Text);
                command.Parameters.AddWithValue("@vendor", tb_vendor.Text);
                command.Parameters.AddWithValue("@screen_size", nud_screenSize.Value);
                command.Parameters.AddWithValue("@moisture", nud_moisture.Value);
                command.Parameters.AddWithValue("@harvest_date", dt_harvest.Value.ToString("yyyy/MM/dd"));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            this.Close();
        }
        private void editProfile()
        {
            string query = "UPDATE Bean SET bean_name=@bean_name,bean_type=@bean_type,input_date=@input_date,country=@country,region=@region,process=@process,screen_size=@screen_size,harvest_date=@harvest_date,moisture=@moisture,vendor=@vendor WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@bean_name", tb_beanName.Text);
                command.Parameters.AddWithValue("@bean_type", cb_beanType.Text);
                command.Parameters.AddWithValue("@input_date", DateTime.Now.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@country", tb_country.Text);
                command.Parameters.AddWithValue("@region", tb_region.Text);

                command.Parameters.AddWithValue("@process", cb_process.Text);
                command.Parameters.AddWithValue("@vendor", tb_vendor.Text);
                command.Parameters.AddWithValue("@screen_size", nud_screenSize.Value);
                command.Parameters.AddWithValue("@moisture", nud_moisture.Value);
                command.Parameters.AddWithValue("@harvest_date", dt_harvest.Value.ToString("yyyy/MM/dd"));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!edit)
                insertProfile();
            else
                editProfile();
        }
    }
}
