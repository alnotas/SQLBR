using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace SQLBR
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }
      private void Form1_Load(object sender, EventArgs e)
      {
         Thread th = new Thread(new ThreadStart(FillServers));
         th.IsBackground = true;
         th.Start();
      }
      private void FillServers()
      {
         this.Invoke((MethodInvoker)delegate
         {
            comboBox1.Enabled = false;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Please wait...");
            comboBox1.SelectedIndex = 0;
            Application.DoEvents();
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for(int i = 0; i < servers.Rows.Count; i++)
            {
               if((servers.Rows[i]["InstanceName"] as string) != null)
                  comboBox1.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
               else
                  comboBox1.Items.Add(servers.Rows[i]["ServerName"]);
            }
            comboBox1.Items.RemoveAt(0);
            comboBox1.Sorted = true;
            if(comboBox1.Items.Count > 0)
            {
               comboBox1.SelectedIndex = 0;
               comboBox1.Enabled = true;
            }
         });
      }

      public List<string> GetDatabaseList()
      {
         List<string> list = new List<string>();
         // Open connection to the database
         string conString;
         if(cbIntergrated.Checked)
            conString = "server=" + comboBox1.Text + ";Integrated Security=true";
         else
            conString = "server=" + comboBox1.Text + ";uid=" + textBox1.Text + ";pwd=" + textBox2.Text;
         using(SqlConnection con = new SqlConnection(conString))
         {
            try
            {
               con.Open();
               // Set up a command with the given query and associate
               // this with the current connection.
               using(SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
               {
                  using(IDataReader dr = cmd.ExecuteReader())
                  {
                     while(dr.Read())
                     {
                        list.Add(dr[0].ToString());
                     }
                  }
               }

            }
            catch(Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
         }
         return list;
      }
      private void comboBox2_DropDown(object sender, EventArgs e)
      {
         comboBox2.Items.Clear();
         foreach(string s in GetDatabaseList())
         {
            comboBox2.Items.Add(s);
         }
      }

      private void cbIntergrated_Click(object sender, EventArgs e)
      {
         textBox1.Enabled = !cbIntergrated.Checked;
         textBox2.Enabled = !cbIntergrated.Checked;
      }

      private void comboBox1_TextChanged(object sender, EventArgs e)
      {
         comboBox2.Items.Clear();
         comboBox2.Text = "";
      }
      private void AddMemo(string inMemo)
      {
         memoEdit1.Text += DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + "\r\n";
         memoEdit1.Text += inMemo + "\r\n";
         Application.DoEvents();

      }

      private void DoBackup()
      {
         string bkfile = "";
         Form2 f = new Form2(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text, cbIntergrated.Checked);
         if(f != null)
         {
            if(f.ShowDialog() == DialogResult.OK)
               bkfile = f.FullBackupPath;
            else
               return;
         }
         else
            return;
         if(bkfile == "")
            return;
         SqlConnection con = new SqlConnection();
         SqlCommand sqlcmd = new SqlCommand();
         SqlDataAdapter da = new SqlDataAdapter();
         DataTable dt = new DataTable();

         if(cbIntergrated.Checked)
            con.ConnectionString = "Data Source=" + comboBox1.Text + ";" +
                                    "Initial Catalog=" + comboBox2.Text + ";" +
                                    "Integrated Security=true";
         else
            con.ConnectionString = "Data Source=" + comboBox1.Text + ";" +
                                    "Initial Catalog=" + comboBox2.Text + ";" +
                                    "User id=" + textBox1.Text + ";" +
                                    "Password=" + textBox2.Text + ";";
         try
         {
            con.Open();
            string tSQL = @"backup database " + comboBox2.Text + " to disk='" + bkfile + "' with init";
            AddMemo(tSQL);
            sqlcmd = new SqlCommand(tSQL, con);
            sqlcmd.CommandTimeout = 0;
            sqlcmd.ExecuteNonQuery();
            Application.DoEvents();
            con.Close();
            Application.DoEvents();
            AddMemo("Success");
         }
         catch(Exception ex)
         {
            AddMemo("!!! Error - " + ex.Message);
            MessageBox.Show(ex.Message);
         }
      }
      private void DoRestore()
      {
         string bkfile = "";
         Form2 f = new Form2(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text, cbIntergrated.Checked);
         if(f != null)
         {
            if(f.ShowDialog() == DialogResult.OK)
               bkfile = f.FullBackupPath;
            else
               return;
         }
         else
            return;
         if(bkfile == "")
            return;
         SqlConnection con = new SqlConnection();
         SqlCommand sqlcmd = new SqlCommand();
         SqlDataAdapter da = new SqlDataAdapter();
         DataTable dt = new DataTable();

         if(cbIntergrated.Checked)
            con.ConnectionString = "Data Source=" + comboBox1.Text + ";" +
                                    "Initial Catalog=" + comboBox2.Text + ";" +
                                    "Integrated Security=true";
         else
            con.ConnectionString = "Data Source=" + comboBox1.Text + ";" +
                                    "Initial Catalog=" + comboBox2.Text + ";" +
                                    "User id=" + textBox1.Text + ";" +
                                    "Password=" + textBox2.Text + ";";
         try
         {
            con.Open();
            string tSQL = @"backup database " + comboBox2.Text + " to disk='" + bkfile + "' with init";
            AddMemo(tSQL);
            sqlcmd = new SqlCommand(tSQL, con);
            sqlcmd.CommandTimeout = 0;
            sqlcmd.ExecuteNonQuery();
            Application.DoEvents();
            con.Close();
            Application.DoEvents();
            AddMemo("Success");
         }
         catch(Exception ex)
         {
            AddMemo("!!! Error - " + ex.Message);
            MessageBox.Show(ex.Message);
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if(radioButton1.Checked)
            DoBackup();
         else
            DoRestore();

      }
   }

}
