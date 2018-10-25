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
    public partial class DialogProfile : Form
    {
        int _id;
        string connectionstring = Properties.Settings.Default.connection;
        bool edit = false;
        public DialogProfile()
        {
            InitializeComponent();
            getBean();
        }

        public DialogProfile(int id)
        {
            InitializeComponent();
            getBean();
            this._id = id;
            getSelected();
            edit = true;
            
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboboxItem(string txt,int n)
            {
                this.Text = txt;
                this.Value = n;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!edit)
                insertProfile();
            else
                editProfile();
        }

        private void getBean()
        {
            string query = "Select * from Bean";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cb_bean.Items.Add(new ComboboxItem(dr["bean_name"].ToString(), Int32.Parse(dr["id"].ToString())));
                }
            }
        }

        private void getSelected()
        {
            string query = "SELECT * FROM Profile WHERE Id=@id";
            
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", _id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    tb_profile.Text = dr["profile"].ToString();
                    nud_batch.Value = Int32.Parse(dr["weight"].ToString());
                    nud_weightLoss.Value = Int32.Parse(dr["weight_lost"].ToString());
                    tb_operator.Text = dr["username"].ToString();
                    int index = 0;
                    for(int i=0;i<cb_bean.Items.Count;i++)
                    {
                        ComboboxItem item = (ComboboxItem)cb_bean.Items[i];
                        if (item.Value == Int32.Parse(dr["beanId"].ToString()))
                            index = i;
                            
                    }
                    cb_bean.SelectedIndex =index;

                }
            }
        }

        private void insertProfile()
        {
            string query = "INSERT INTO Profile (profile,beanId,weight,weight_lost,username,date) VALUES (@profile,@bean,@weight,@weight_lost,@user,@date)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@profile", tb_profile.Text);
                ComboboxItem cbi = (ComboboxItem)cb_bean.SelectedItem;
                command.Parameters.AddWithValue("@bean", cbi.Value);
                command.Parameters.AddWithValue("@weight", nud_batch.Value);
                command.Parameters.AddWithValue("@weight_lost", nud_weightLoss.Value);
                command.Parameters.AddWithValue("@user", tb_operator.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd"));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            this.Close();
        }
        private void editProfile()
        {
            string query = "UPDATE Profile SET profile=@profile,beanId=@bean,weight=@weight,weight_lost=@weight_lost,username=@user,date=@date WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@profile", tb_profile.Text);
                ComboboxItem cbi = (ComboboxItem)cb_bean.SelectedItem;
                command.Parameters.AddWithValue("@bean", cbi.Value);
                command.Parameters.AddWithValue("@weight", nud_batch.Value);
                command.Parameters.AddWithValue("@weight_lost", nud_weightLoss.Value);
                command.Parameters.AddWithValue("@user", tb_operator.Text);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd"));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            this.Close();
        }

        private void DialogProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
