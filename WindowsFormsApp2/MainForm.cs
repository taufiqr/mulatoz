using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApp2.Object;
using WindowsFormsApp2.Object.Maintenance;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        System.Threading.Timer TheTimer = null;
        MqttClient mqttClient;
        string connectionstring = Properties.Settings.Default.connection;
        LineSeries lineseries = new OxyPlot.Series.LineSeries();
        LineSeries rorseries = new OxyPlot.Series.LineSeries();
        LineSeries historyseries = new OxyPlot.Series.LineSeries();
        LineSeries rorhistoryseries = new OxyPlot.Series.LineSeries();
        PlotModel pm;
        int selectedProfileId;
        Label[] eventLables=new Label[6];
        int recordedEventCount = 0;
        int[] data = { 141, 141, 141, 141, 141, 141, 142, 142, 142, 142, 142, 142, 143, 143, 143, 143, 143, 143, 144, 144, 144, 144, 144, 144, 145, 145, 145, 145, 145, 145, 146, 146, 146, 146, 146, 146, 147, 147, 147, 147, 147, 147, 148, 148, 148, 149, 149, 149, 149, 149, 149, 150, 150, 150, 150, 150, 150, 151, 151, 151, 150, 150, 150, 146, 146, 146, 142, 142, 142, 137, 137, 137, 132, 132, 132, 128, 128, 128, 124, 124, 124, 120, 120, 120, 117, 117, 117, 114, 114, 114, 111, 111, 111, 109, 109, 109, 107, 107, 107, 105, 105, 105, 104, 104, 104, 103, 103, 103, 102, 102, 102, 101, 101, 101, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 101, 101, 101, 101, 101, 101, 102, 102, 102, 102, 102, 102, 103, 103, 103, 104, 104, 104, 105, 105, 105, 105, 105, 105, 106, 106, 106, 107, 107, 107, 109, 109, 109, 110, 110, 110, 111, 111, 111, 112, 112, 112, 113, 113, 113, 114, 114, 114, 115, 115, 115, 116, 116, 116, 117, 117, 117, 118, 118, 118, 119, 119, 119, 120, 120, 120, 121, 121, 121, 122, 122, 122, 123, 123, 123, 124, 124, 124, 125, 125, 125, 126, 126, 126, 126, 126, 126, 127, 127, 127, 128, 128, 128, 129, 129, 129, 130, 130, 130, 131, 131, 131, 131, 131, 131, 132, 132, 132, 133, 133, 133, 134, 134, 134, 135, 135, 135, 135, 135, 135, 136, 136, 136, 137, 137, 137, 137, 137, 137, 138, 138, 138, 139, 139, 139, 139, 139, 139, 140, 140, 140, 141, 141, 141, 142, 142, 142, 142, 142, 142, 143, 143, 143, 144, 144, 144, 144, 144, 144, 145, 145, 145, 146, 146, 146, 146, 146, 146, 147, 147, 147, 147, 147, 147, 148, 148, 148, 149, 149, 149, 149, 149, 149, 150, 150, 150, 150, 150, 150, 151, 151, 151, 151, 151, 151, 152, 152, 152, 152, 152, 152, 153, 153, 153, 154, 154, 154, 154, 154, 154, 155, 155, 155, 155, 155, 155, 156, 156, 156, 156, 156, 156, 157, 157, 157, 157, 157, 157, 158, 158, 158, 158, 158, 158, 159, 159, 159, 160, 160, 160, 160, 160, 160, 161, 161, 161, 161, 161, 161, 162, 162, 162, 162, 162, 162, 163, 163, 163, 163, 163, 163, 164, 164, 164, 164, 164, 164, 165, 165, 165, 165, 165, 165, 166, 166, 166, 166, 166, 166, 167, 167, 167, 167, 167, 167, 168, 168, 168, 168, 168, 168, 169, 169, 169, 169, 169, 169, 170, 170, 170, 170, 170, 170, 171, 171, 171, 171, 171, 171, 171, 171, 171, 172, 172, 172, 172, 172, 172, 173, 173, 173, 173, 173, 173, 174, 174, 174, 174, 174, 174, 175, 175, 175, 175, 175, 175, 176, 176, 176, 176, 176, 176, 177, 177, 177, 177, 177, 177, 178, 178, 178, 178, 178, 178, 179, 179, 179, 179, 179, 179, 180, 180, 180, 180, 180, 180, 181, 181, 181, 181, 181, 181, 182, 182, 182, 182, 182, 182, 183, 183, 183, 183, 183, 183, 183, 183, 183, 184, 184, 184, 184, 184, 184, 185, 185, 185, 185, 185, 185, 185, 185, 185, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 186, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 187, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 188, 187, 187, 187, 184, 184, 184, 179, 179, 179, 174, 174, 174, 169, 169, 169, 164, 164, 164, 159, 159, 159, 156, 156, 156, 154, 154, 154, 153, 153, 153, 153, 153, 153 };
        bool roasting = false;

        public MainForm()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.SelectedTab = tabPage6;
            eventLables[0] = lbl_charge;
            eventLables[1] = lbl_dryend;
            eventLables[2] = lbl_fcstart;
            eventLables[3] = lbl_fcend;
            eventLables[4] = lbl_drop;
            eventLables[5] = lbl_coolend;
            init_graph();
        }

        private void init_graph()
        {
            pm = new PlotModel
            {
                PlotType = PlotType.Cartesian,
                PlotAreaBorderColor = OxyColor.FromRgb(178, 100, 57),
                SelectionColor = OxyColor.FromRgb(178, 100, 57)
            };
            

            var c = OxyColors.DarkBlue;
            historyseries.Color = OxyColor.FromArgb(255,178, 100, 57);
            rorhistoryseries.Color = OxyColor.FromArgb(255,178, 100, 57);
            lineseries.StrokeThickness = 5;
            historyseries.StrokeThickness = 5;
            rorhistoryseries.StrokeThickness = 5;
            pm.Axes.Add(new TimeSpanAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0, Maximum = 300,AbsoluteMinimum=0, IsZoomEnabled = false, MajorGridlineColor = OxyColor.FromRgb(178, 100, 57), MajorGridlineStyle = LineStyle.Solid, MajorStep = 150, TextColor = OxyColors.White, TicklineColor = OxyColor.FromRgb(178, 100, 57), StringFormat = "mm:ss" });
            pm.Axes.Add(new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, IsZoomEnabled = false, AbsoluteMinimum = 0,Minimum=0, AbsoluteMaximum = 300,Maximum=300, MajorGridlineColor = OxyColor.FromRgb(178, 100, 57), MajorGridlineStyle = LineStyle.Solid, MajorStep = 25, TextColor = OxyColors.White, TicklineColor = OxyColor.FromRgb(178, 100, 57) });
            pm.Axes.Add(new LinearAxis { Position = OxyPlot.Axes.AxisPosition.Right,Key="ror", IsZoomEnabled = false, AbsoluteMinimum = -50, AbsoluteMaximum = 50, MajorGridlineColor = OxyColor.FromRgb(178, 100, 57), MajorGridlineStyle = LineStyle.Solid, MajorStep = 10, TextColor = OxyColors.White, TicklineColor = OxyColor.FromRgb(178, 100, 57) });

            lineseries.Color = OxyColors.Blue;
            rorseries.YAxisKey = "ror";
            rorhistoryseries.YAxisKey = "ror";
            pm.Series.Add(historyseries);
            pm.Series.Add(rorhistoryseries);

            pm.Series.Add(lineseries);
            var Event = new PolygonAnnotation();

            Event.Layer = AnnotationLayer.BelowAxes;
            Event.StrokeThickness = 0;
            Event.Stroke = OxyColor.FromRgb(0, 0, 255);
            Event.LineStyle = LineStyle.Automatic;


            Event.Points.Add(new DataPoint(0, 0));
            Event.Points.Add(new DataPoint(0, 200));
            Event.Points.Add(new DataPoint(3000, 0));
            Event.Points.Add(new DataPoint(3000, 200));

            pm.Annotations.Add(new PolygonAnnotation());
            pm.Annotations.Add(new PolygonAnnotation());

            plot1.Model = pm;
            plot1.InvalidatePlot(true);

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.Publish("suhu", Encoding.UTF8.GetBytes("{\"d\":{\"suhu\":99}}"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new DialogProfile().ShowDialog(); ;
            PopulateProfile();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
        }



        int roastTime = 0;
        int DevTime = 0;
        bool startDev = false;
        int currentTemp = 0;
        List<int> ror = new List<int>();

        private void timer1_Tick(object sender, EventArgs e)
        {
            string minute = "" + (roastTime / 60);
            string second = "" + (roastTime % 60);
            if (minute.Length < 2)
                minute = "0" + minute;
            if (second.Length < 2)
                second = "0" + second;
            lbl_roast_timer.Text = minute + ":" + second;
            
            if (startDev)
            {
                minute = "" + (DevTime / 60);
                second = "" + (DevTime % 60);
                if (minute.Length < 2)
                    minute = "0" + minute;
                if (second.Length < 2)
                    second = "0" + second;
                lbl_dev_time.Text = minute + ":" + second;
                DevTime++;
            }
            roastTime++;
        }


        
        
        private void btn_mqttConnect_Click(object sender, EventArgs e)
        {
            
            mqttClient = new MqttClient(IPAddress.Parse(tb_brokerIP.Text));
            // register to message received 
            mqttClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
            string clientId = Guid.NewGuid().ToString();
            try
            {
                mqttClient.Connect(clientId);
                lbl_mqttStatus.Text = "Status: Connected";
            }
            catch (Exception ex)
            {
                lbl_mqttStatus.Text = "Status: Fail to connect";
            }

            // subscribe to the topic "/home/temperature" with QoS 2 

            mqttClient.Subscribe(new string[] { "topic" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "slider" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "maint" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "event_fcstart" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "event_fcend" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "event_drop" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            mqttClient.Subscribe(new string[] { "event_coolend" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            //timer1.Start();
        }
        
        List<double> rordata = new List<double>();

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            System.Text.Encoding enc = System.Text.Encoding.ASCII;
            string msg = enc.GetString(e.Message);
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            if (e.Topic == "topic")
            {
                DataSensor dataSensor = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSensor>(msg);
                lbl_beanTemp.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbl_beanTemp.Text = dataSensor.d.Sensor_suhu[0] + "°";

                    if (dataSensor.d.Sensor_suhu[0] > 500)
                        cp_temp.Value = 500;
                    else
                        cp_temp.Value = dataSensor.d.Sensor_suhu[0];
                    lbl_airflow.Text = dataSensor.d.airflow[0] + "";
                    cp_airflow.Value = dataSensor.d.airflow[0];
                    lbl_drumSpeed.Text = dataSensor.d.drum[0] + "";
                    cp_drum.Value = dataSensor.d.drum[0];
                    lbl_burner.Text = dataSensor.d.burner[0] + "";
                    cp_burner.Value = dataSensor.d.burner[0];
                    
                    rordata.Add((currentTemp - (int)dataSensor.d.Sensor_suhu[0]) / 0.0166);

                    lineseries.Points.Add(new DataPoint(roastTime, (double)dataSensor.d.Sensor_suhu[0]));
                    currentTemp = cp_temp.Value;

                    if (roastTime > 44)
                    {
                        double sum = 0;
                        foreach(double x in rordata)
                        {
                            sum += x;
                        }
                        double rorvalue = sum/45;
                        rorseries.Points.Add(new DataPoint(roastTime, rorvalue));
                        rordata.RemoveAt(0);
                    }

                    //lineseries.Points.Add(new DataPoint(roastTime, data[roastTime]));
                    //currentTemp = data[roastTime];

                    if (lineseries.Points.Count == pm.Axes[0].Maximum)
                    {
                        pm.Axes[0].Reset();
                        pm.Axes[0].Maximum = pm.Axes[0].Maximum + 300;
                    }
                    plot1.InvalidatePlot(true);
                    //Values2.Add(new ObservableValue((double)dataSensor.d.Sensor_suhu[0]));
                    //roastTime++;

                });
            }

            if (e.Topic == "slider")
            {
                DataSlider dat = Newtonsoft.Json.JsonConvert.DeserializeObject<DataSlider>(msg);
                Control_Suhu.BeginInvoke((MethodInvoker)delegate ()
                {
                    Control_Suhu.Value = (decimal)dat.d.sv;
                    Control_AF.Value = (decimal)dat.d.af[0];
                    Control_Burner.Value = (decimal)dat.d.br[0];
                    Control_Drum.Value = (decimal)dat.d.ds[0];
                    
                });
            }

            if (e.Topic == "maint")
            {
                DataMaintenance dat = Newtonsoft.Json.JsonConvert.DeserializeObject<DataMaintenance>(msg);
                lbl_chute.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbl_chute.Text = dat.d.ch.ToString();
                    lbl_chaff.Text = dat.d.co.ToString();
                    lbl_cooling.Text = dat.d.col.ToString();
                    lbl_bearing.Text = dat.d.be.ToString();
                    pb_chute.Value = dat.d.datch;
                    pb_chaff.Value = dat.d.datco;
                    pb_cooling.Value = dat.d.datun;
                    pb_bearing.Value = dat.d.datbe;

                });
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.Disconnect();
                userid = 0;
                lbl_user.Text = "----";
                Properties.Settings.Default.user = false;
                Properties.Settings.Default.Save();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double x = (double)numericUpDown1.Value;
            double y = (double)numericUpDown2.Value;

            
            var Event = new PolygonAnnotation();

            Event.Layer = AnnotationLayer.BelowAxes;
            Event.StrokeThickness = 0;

            Event.Fill = OxyColor.FromAColor(50, OxyColors.Green);
            Event.LineStyle = LineStyle.Automatic;


            Event.Points.Add(new DataPoint(0, x));
            Event.Points.Add(new DataPoint(3000, x));

            Event.Points.Add(new DataPoint(3000, y));
            Event.Points.Add(new DataPoint(0, y));

            pm.Annotations[0] = Event;

            plot1.InvalidatePlot(true);
            //cartesianChart2.AxisY[0].Sections[1].Value = x;
            //cartesianChart2.AxisY[0].Sections[1].SectionWidth = y;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)numericUpDown3.Value;
            int y = (int)numericUpDown4.Value;

            var Event = new PolygonAnnotation();

            Event.Layer = AnnotationLayer.BelowAxes;
            Event.StrokeThickness = 0;
            Event.Fill = OxyColor.FromAColor(50,OxyColors.Red);
            Event.LineStyle = LineStyle.Automatic;


            Event.Points.Add(new DataPoint(0, x));
            Event.Points.Add(new DataPoint(3000, x));

            Event.Points.Add(new DataPoint(3000, y));
            Event.Points.Add(new DataPoint(0, y));

            pm.Annotations[1] = Event;

            plot1.InvalidatePlot(true);
            //cartesianChart2.AxisY[0].Sections[2].Value = x;
            //cartesianChart2.AxisY[0].Sections[2].SectionWidth = y;
        }
        


        private void button14_Click(object sender, EventArgs e)
        {
            new DialogDataBean().ShowDialog();
            PopulateBean();
        }

        private void PopulateProfile()
        {
            lv_profile.Items.Clear();
            string query = "Select * from Profile";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["profile"].ToString());
                    listitem.Name = dr["Id"].ToString();
                    listitem.SubItems.Add(dr["date"].ToString().Split(' ')[0]);
                    listitem.SubItems.Add(dr["data"].ToString());
                    lv_profile.Items.Add(listitem);

                }
            }

        }

        private void PopulateHistory()
        {
            lv_history.Items.Clear();
            string query = "Select * from History";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["date"].ToString().Split(' ')[0]);
                    listitem.Name = dr["Id"].ToString();
                    listitem.SubItems.Add(dr["username"].ToString());
                    listitem.SubItems.Add(dr["profile"].ToString());
                    lv_history.Items.Add(listitem);

                }
            }

        }

        private void getEvent(int id)
        {
            string query = "Select * from Events where profileId=@id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["time"].ToString());
                    listitem.SubItems.Add(dr["temperature"].ToString());
                    listitem.SubItems.Add(dr["event"].ToString());
                    lv_events.Items.Add(listitem);
                }
            }
        }

        private void PopulateEvent(int id)
        {
            lv_events.Items.Clear();

            string query = "Select * from Events where profileId=@id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["time"].ToString());
                    listitem.SubItems.Add(dr["temperature"].ToString());
                    listitem.SubItems.Add(dr["event"].ToString());
                    lv_events.Items.Add(listitem);

                }
            }

        }
        private void PopulateBean()
        {
            lv_beandata.Items.Clear();
            string query = "Select * from Bean";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["bean_name"].ToString());
                    listitem.Name = dr["Id"].ToString();
                    listitem.SubItems.Add(dr["bean_type"].ToString());
                    listitem.SubItems.Add(dr["input_date"].ToString().Split(' ')[0]);
                    listitem.SubItems.Add(dr["country"].ToString());
                    listitem.SubItems.Add(dr["region"].ToString());
                    listitem.SubItems.Add(dr["process"].ToString());
                    listitem.SubItems.Add(dr["screen_size"].ToString());
                    listitem.SubItems.Add(dr["moisture"].ToString());
                    listitem.SubItems.Add(dr["vendor"].ToString());
                    lv_beandata.Items.Add(listitem);

                }
            }

        }

        private void PopulateUser()
        {
            lv_users.Items.Clear();
            string query = "Select * from Users";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["username"].ToString());
                    listitem.Name = dr["Id"].ToString();
                    listitem.SubItems.Add(dr["date"].ToString().Split(' ')[0]);
                    lv_users.Items.Add(listitem);

                }
            }

        }

        private void DeleteProfile()
        {
            lv_beandata.Items.Clear();
            string query = "DELETE from Profile where Id=@id";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", Int32.Parse(lv_beandata.FocusedItem.Name));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }

        }


        private void DeleteUser(int id)
        {
            lv_users.Items.Clear();
            string query = "DELETE from Users where Id=@id";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }

        }
        private void DeleteBean(int id)
        {
            lv_beandata.Items.Clear();
            string query = "DELETE from Bean where Id=@id";
            //string query = "Select Profile.Id,Bean.bean_name,weight,weight_lost,user,date from Profile INNER JOIN Bean ON Profile.beanId=Bean.Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@id", id);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                }
            }
            catch (Exception e)
            {
                if (e.HResult == -2146232060)
                    MessageBox.Show("There's a roast profile that use this data");
            }

        }
        private void AddRoastData(int id,string roastdata)
        {
            string query = "UPDATE Profile SET data=@data WHERE id=@id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@data", roastdata);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }

        private void AddEventData(int id, string eventname,string time,double temp)
        {
            string query = "INSERT INTO Events (profileId,event,time,temperature) VALUES (@id,@event,@time,@temp)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@event", eventname);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@temp", temp);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }


        private void AddUser(string user, string pass)
        {
            string query = "INSERT INTO Users (username,password,date) VALUES (@user,@pass,@date)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd"));
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }

        private void RecordtoHistory(string user, string profile)
        {
            string query = "INSERT INTO History (date,username,profile) VALUES (@date,@user,@profile)";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@profile", profile);
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd").Split(' ')[0]);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
            PopulateHistory();
        }

        private void DeleteEventData(int id)
        {
            string query = "DELETE FROM Events WHERE profileId=@id";
            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            }
        }

        private void LoadProfile(string dataroast)
        {
            historyseries.Points.Clear();
            string rorstring = "";
            for (int i = pm.Annotations.Count-1; i > 1; i--)
                pm.Annotations.RemoveAt(i);
            int cnt = 0;
            dataroast = Regex.Match(dataroast, @"([\d]+[,.]{0,1})+").Value;
            int prevtemp = 0;
            rordata.Add(0);
            foreach(string tmp in dataroast.Split(','))
            {
                if (tmp != "")
                {
                    historyseries.Points.Add(new DataPoint(cnt, Int32.Parse(tmp)));
                    if (cnt > 0)
                    {
                        try
                        {
                            rordata.Add((Int32.Parse(tmp)-prevtemp )/ 0.0166);

                            //rorstring += (Int32.Parse(tmp) - prevtemp / (1 / 60)) + ",";
                        }
                        catch(Exception e)
                        {
                            rordata.Add(0);
                           // rorstring += 0 + ",,";

                        }
                    }

                    //rorstring += (Int32.Parse(tmp) - prevtemp)+",";
                    prevtemp = Int32.Parse(tmp);
                    double sum = 0;
                    if (rordata.Count > 44)
                    {
                        foreach (double x in rordata)
                        {
                            sum += x;                           
                        }
                        double rorvalue = sum / 45;
                        
                        rorhistoryseries.Points.Add(new DataPoint(cnt, rorvalue));
                        rordata.RemoveAt(0);
                    }
                    cnt++;
                }
            }
            rordata.Clear();
            pm.Axes[0].Maximum = cnt;
            cnt = 0;
            //MessageBox.Show(lv_events.Items.Count + "");
            foreach (ListViewItem item in lv_events.Items)
            {
                int i =((cnt%2==0)?1:-1);
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(TimeSpan.Parse("00:" + item.SubItems[0].Text).TotalSeconds, Int32.Parse(item.SubItems[1].Text) + 25*(i)),
                    EndPoint = new DataPoint(TimeSpan.Parse("00:" + item.SubItems[0].Text).TotalSeconds, Int32.Parse(item.SubItems[1].Text)),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColor.FromArgb(255, 178, 100, 57),
                    Text = item.SubItems[2].Text,
                    TextColor = OxyColor.FromArgb(255, 178, 100, 57)
                });
                //eventLables[cnt].Text = item.SubItems[2].Text+": " + item.SubItems[0].Text;
                cnt++;
            }
            plot1.InvalidatePlot(true);
            tabControl1.SelectedTab = tabPage8;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateProfile();
            PopulateBean();
            PopulateUser();
            PopulateHistory();
            foreach (ColumnHeader column in lv_beandata.Columns)
            {

                column.Width = (int)lv_beandata.Size.Width / 9;
                column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
        }


        private void lv_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lv_profile.FocusedItem != null))
            {
                PopulateEvent(Int32.Parse(lv_profile.FocusedItem.Name));
            }
            else
                lv_events.Items.Clear();
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            if ((lv_profile.FocusedItem != null && lv_profile.FocusedItem.Name != "0"))
            {
                new DialogProfile(Int32.Parse(lv_profile.FocusedItem.Name)).ShowDialog();
                PopulateProfile();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if ((lv_beandata.FocusedItem != null && lv_beandata.FocusedItem.Name != "0"))
            {
                new DialogDataBean(Int32.Parse(lv_beandata.FocusedItem.Name)).ShowDialog();
                PopulateBean();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ((lv_beandata.FocusedItem != null && lv_beandata.FocusedItem.Name != "0"))
            {
                DeleteBean(Int32.Parse(lv_beandata.FocusedItem.Name));
                PopulateBean();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lv_profile.FocusedItem != null&&mqttClient!=null&&mqttClient.IsConnected)
            {                 
                    selectedProfileId = Int32.Parse(lv_profile.FocusedItem.Name);              
                    roasting = true;
                    ResetGraph();
                if (lv_events.Items.Count == 0)
                {
                    ProfileAsReferance par = new ProfileAsReferance();
                    if (DialogResult.OK == par.ShowDialog())
                    {
                        ListViewItem lvt = lv_profile.FocusedItem;
                        timer1.Start();
                        lv_profile.FocusedItem = lv_profile.Items[par.selectedProfile];
                        PopulateEvent(Int32.Parse(lv_profile.FocusedItem.Name));
                        tabControl1.SelectedTab = tabPage8;
                        LoadProfile(lv_profile.FocusedItem.SubItems[2].Text);
                        lv_profile.FocusedItem = lvt;
                        PopulateEvent(Int32.Parse(lv_profile.FocusedItem.Name));
                        
                    }
                }
                else
                {
                    timer1.Start();
                    tabControl1.SelectedTab = tabPage8;
                    LoadProfile(lv_profile.FocusedItem.SubItems[2].Text);
                }
                
            }
        }

        private void lbl_charge_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >= 2)
            {
                startDev = true;
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime, currentTemp - 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "Charge",
                    TextColor = OxyColors.White
                });
                lbl_charge.Text = "Charge: " + lbl_dev_time.Text;
                lbl_charge.BackColor = Color.FromArgb(178, 100, 57);
                recordedEventCount++;
            }
        }

        private void lbl_dryend_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >= 3)
            {
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime, currentTemp + 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "Dry End",
                    TextColor = OxyColors.White
                });
                lbl_dryend.Text = "Dry End: " + lbl_dev_time.Text;
                lbl_dryend.BackColor = Color.FromArgb(178, 100, 57);
                recordedEventCount++;

            }

        }

        private void lbl_fcstart_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >= 4)
            {
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime, currentTemp - 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "FC start",
                    TextColor = OxyColors.White
                });
                lbl_fcstart.Text = "FC start: " + lbl_dev_time.Text;
                recordedEventCount++;
                lbl_fcstart.BackColor = Color.FromArgb(178, 100, 57);
            }
        }

        private void lbl_fcend_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >=5)
            {
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime , currentTemp + 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "FC End",
                    TextColor = OxyColors.White
                });
                lbl_fcend.Text = "FC end: " + lbl_dev_time.Text;
                recordedEventCount++;
                lbl_fcend.BackColor = Color.FromArgb(178, 100, 57);
            }
        }

        private void lbl_drop_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >=6)
            {
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime , currentTemp - 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "Drop",
                    TextColor = OxyColors.White
                });
                recordedEventCount++;
                lbl_drop.Text = "Drop: " + lbl_dev_time.Text;
                lbl_drop.BackColor = Color.FromArgb(178, 100, 57);
            }
        }


        private void lbl_coolend_Click(object sender, EventArgs e)
        {
            if (pm.Annotations.Count >=7)
            {
                pm.Annotations.Add(new ArrowAnnotation
                {
                    StartPoint = new DataPoint(roastTime, currentTemp + 25),
                    EndPoint = new DataPoint(roastTime, currentTemp),
                    HeadWidth = 1,
                    HeadLength = 1,
                    Color = OxyColors.White,
                    Text = "Cool End",
                    TextColor = OxyColors.White
                });
                recordedEventCount++;
                lbl_coolend.Text = "Cool End: " + lbl_dev_time.Text;
                lbl_coolend.BackColor = Color.FromArgb(178, 100, 57);

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (lv_profile.FocusedItem != null)
            {
                
                    tabControl1.SelectedTab = tabPage8;
                    LoadProfile(lv_profile.FocusedItem.SubItems[2].Text);
                
            }
        }

        private void btn_stopRoast_Click(object sender, EventArgs e)
        {
            if (roasting)
            {
                DialogResult dr = new RoastStopDialog().ShowDialog();
                if (dr == DialogResult.OK)
                {
                    DeleteEventData(selectedProfileId);
                    string dataroast = "";
                    foreach (DataPoint dp in lineseries.Points)
                    {
                        dataroast += dp.Y + ",";
                    }
                    //dataroast.Substring(0, dataroast.Length - 3);

                    AddRoastData(selectedProfileId, dataroast);
                    timer1.Stop();

                    int cnt = 0;
                    for(int i= pm.Annotations.Count-recordedEventCount; i<pm.Annotations.Count&&cnt<= recordedEventCount; i++)
                    {
                        ArrowAnnotation ann = (ArrowAnnotation)pm.Annotations[i];
                        MessageBox.Show(eventLables[cnt].Text);
                        string[] str = eventLables[cnt].Text.Split(new string[] { ": " }, StringSplitOptions.None);
                        AddEventData(selectedProfileId, str[0], str[1], ann.EndPoint.Y);
                        cnt++;
                    }
                    
                    ResetGraph();
                    roasting = false;
                    RecordtoHistory(lbl_user.Text, lv_profile.FocusedItem.SubItems[0].Text);
                }
                
            }
        }
        private void ResetGraph()
        {
            roastTime = 0;
            DevTime = 0;
            lineseries.Points.Clear();
            rorseries.Points.Clear();
            historyseries.Points.Clear();
            for (int i = pm.Annotations.Count - 1; i > 1; i--)
                pm.Annotations.RemoveAt(i);
            rorseries.Points.Clear();
            foreach (Label lbl in eventLables)
            {
                lbl.BackColor = Color.FromArgb(40, 40, 42);
                lbl.Text = lbl.Text.Split(':')[0] + ": 00:00";
            }
            lbl_roast_timer.Text = "00:00";
            lbl_dev_time.Text = "00:00";
            recordedEventCount=0;

            plot1.InvalidatePlot(true);
        }

        int userid;

        

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            if (tb_AUpass.Text == tb_AUconfirm.Text)
            {
                AddUser(tb_AUuser.Text, tb_AUpass.Text);
                PopulateUser();
            }
            else
                MessageBox.Show("Password don't match");
        }

        private void btn_deluser_Click(object sender, EventArgs e)
        {
            if ((lv_users.FocusedItem != null && lv_users.FocusedItem.Name != "0"))
            {
                DeleteUser(Int32.Parse(lv_users.FocusedItem.Name));
                PopulateUser();
            }
        }
        

        private void lbl_user_TextChanged(object sender, EventArgs e)
        {
            if (lbl_user.Text == "----")
            {
                panel_Control.Visible = false;
                Option_Main.Visible = false;
                tabControl1.SelectedTab = tabPage6;
            }
            else
            {
                Option_Main.Visible = true;
                tabControl1.SelectedTab = tabPage7;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage8)
            {
                panel_Control.Visible = true;

            }
            else
            {
                panel_Control.Visible = false;

            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.user)
            {
                tabControl1.SelectedTab = tabPage11;
            }
            else
            {
                tabControl1.SelectedTab = tabPage6;

            }
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            userid = 0;
            lbl_user.Text = "----";
            Properties.Settings.Default.user = false;
            Properties.Settings.Default.Save();
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            string[] toggle = { "false", "false", "false", "false" };
            if (checkBox1.Checked)
                toggle[0] = "true";
            if (checkBox2.Checked)
                toggle[1] = "true";
            if (checkBox3.Checked)
                toggle[2] = "true";
            if (checkBox4.Checked)
                toggle[3] = "true";
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.Publish("suhu", Encoding.UTF8.GetBytes("{\"d\":{\"airflow\":" + (int)(Control_AF.Value/100*255) + ",\"button\":" + toggle[0] + ",\"button_burner\":" + toggle[1] + ",\"button_drum\":" + toggle[2] + ",\"button_lamp\":" + toggle[3] + ",\"burner\":" + (int)(Control_Burner.Value / 100 * 255) + ",\"drum\":" + (int)(Control_Drum.Value / 100 * 255) + ",\"suhukon\":" + Control_Suhu.Value +"}}"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
        }

        private void updateControl()
        {
            string[] toggle = { "false", "false", "false", "false" };
            if (checkBox1.Checked)
                toggle[0] = "true";
            if (checkBox2.Checked)
                toggle[1] = "true";
            if (checkBox3.Checked)
                toggle[2] = "true";
            if (checkBox4.Checked)
                toggle[3] = "true";
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.Publish("suhu", Encoding.UTF8.GetBytes("{\"d\":{\"airflow\":" + (int)(Control_AF.Value / 100 * 255) + ",\"button\":" + toggle[0] + ",\"button_burner\":" + toggle[1] + ",\"button_drum\":" + toggle[2] + ",\"button_lamp\":" + toggle[3] + ",\"burner\":" + (int)(Control_Burner.Value / 100 * 255) + ",\"drum\":" + (int)(Control_Drum.Value / 100 * 255) + ",\"suhukon\":" + Control_Suhu.Value + "}}"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
        }

        private void Control_ValueChanged(object sender, MouseEventArgs e)
        {
            updateControl();
        }

        private void Control_ValueChanged(object sender, KeyEventArgs e)
        {
            updateControl();

        }

        private void LoginFormPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login(sender, e);
            }
        }

        private void Login(object sender, EventArgs e)
        {
            string query = "Select * from Users WHERE username=@user AND password=@pw";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@user", tb_username.Text);
                command.Parameters.AddWithValue("@pw", tb_password.Text);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        userid = Int32.Parse(dr["id"].ToString());
                        lbl_user.Text = dr["username"].ToString();
                        Properties.Settings.Default.user = true;
                        Properties.Settings.Default.Save();
                        lbl_loggedUser.Text = dr["username"].ToString();
                    }
                }
                else
                    MessageBox.Show("Wrong Username or Password");
            }
        }

        private void RemovePlaceHolder(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Equals("USERNAME"))
            {
                tb.Text = "";
            }
        }
    }
}
