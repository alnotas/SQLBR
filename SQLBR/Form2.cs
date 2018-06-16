using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SQLBR
{
   public partial class Form2 : Form
   {
      private string DBServer { get; set; }
      private string DBUser { get; set; }
      private string DBPassword { get; set; }
      private string DBCatalog { get; set; }
      private bool DBIntergrated { get; set; }
      private string _FullBackupPath;
      public string FullBackupPath
      {
         get
         {
            string tmp = @textBox1.Text + @"\" + textBox2.Text;
            while(@tmp.IndexOf(@"\\") >= 0)
               tmp = tmp.Replace(@"\\", @"\");
            tmp = tmp.Replace(@"\\", @"\");

            return tmp;
         }
         set { _FullBackupPath = FullBackupPath; }
      }
      public Form2(string inServer, string inUser, string inPassword, string inCatalog, bool inIntergrated)
      {
         InitializeComponent();
         DBServer = inServer;
         DBUser = inUser;
         DBPassword = inPassword;
         DBCatalog = inCatalog;
         DBIntergrated = inIntergrated;
         if(inIntergrated)
            cnDB.ConnectionString = "Data Source=" + DBServer + ";" +
                                    "Initial Catalog=" + DBCatalog + ";" +
                                    "Integrated Security=true";
         else
            cnDB.ConnectionString = "Data Source=" + DBServer + ";" +
                                    "Initial Catalog=" + DBCatalog + ";" +
                                    "User id=" + DBUser + ";" +
                                    "Password=" + DBPassword + ";";
         try
         {
            cnDB.Open();
            if(cnDB.State == System.Data.ConnectionState.Open)
               FillTreeList();
         }
         catch(Exception e)
         {
            MessageBox.Show(e.Message);
            this.Close();
         }

      }

      private void FillTreeList()
      {
         tv.Nodes.Clear();
         SqlCommand qryListDrives = new SqlCommand();
         SqlCommand qryListFiles = new SqlCommand();
         qryListDrives.Connection = cnDB;
         qryListFiles.Connection = cnDB;
         qryListDrives.CommandText = @"exec master.dbo.xp_availablemedia 2";
         DataSet dsDrives = new DataSet();
         SqlDataAdapter daDrives = new SqlDataAdapter(qryListDrives);
         daDrives.Fill(dsDrives);

         DataSet dsFiles = new DataSet();
         SqlDataAdapter daFiles = new SqlDataAdapter(qryListFiles);
         foreach(DataRow drDrive in dsDrives.Tables[0].Rows)
         {
            TreeNode tnDrive = tv.Nodes.Add(drDrive["name"].ToString());
            tnDrive.ImageIndex = 0;
            tnDrive.Tag = 0;
            qryListFiles.CommandText = @"EXECUTE master.dbo.xp_dirtree N'" + tnDrive.Text + "', 1, 1";
            dsFiles.Clear();
            daFiles.Fill(dsFiles);
            foreach(DataRow dr in dsFiles.Tables[0].Rows)
            {
               if(dr["file"].ToString() == "0")
               {
                  TreeNode tmpTreeSubNode = @tnDrive.Nodes.Add(dr["subdirectory"].ToString());
                  tmpTreeSubNode.ImageIndex = 1;
                  tmpTreeSubNode.SelectedImageIndex = 3;
                  tmpTreeSubNode.Tag = 1;
               }
            }
            foreach(DataRow dr in dsFiles.Tables[0].Rows)
            {
               if(dr["file"].ToString() == "1")
               {
                  TreeNode tmpTreeSubNode = @tnDrive.Nodes.Add(dr["subdirectory"].ToString());
                  tmpTreeSubNode.ImageIndex = 2;
                  tmpTreeSubNode.SelectedImageIndex = 4;
                  tmpTreeSubNode.Tag = 2;
               }
            }
         }
      }

      private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
      {
         textBox1.Clear();
         textBox2.Clear();
         string fp = @e.Node.FullPath;
         fp = fp.Replace(@"\\", @"\");
         if((int)e.Node.Tag == 0)
            textBox1.Text = @e.Node.Text;
         if((int)e.Node.Tag == 2)
         {
            textBox1.Text = @Path.GetDirectoryName(fp);
            textBox2.Text = @e.Node.Text;
         }
         if((int)e.Node.Tag != 1)
            return;
         textBox1.Text = fp;
         if((tv.HitTest(e.Location).Location == TreeViewHitTestLocations.PlusMinus) || (e.Node.Nodes.Count > 0))
            return;
         if(e.Node.IsExpanded)
         {
            e.Node.Collapse();
            return;
         }
         SqlCommand qryListFiles = new SqlCommand();
         qryListFiles.Connection = cnDB;
         DataSet dsFiles = new DataSet();
         SqlDataAdapter daFiles = new SqlDataAdapter(qryListFiles);

         qryListFiles.CommandText = @"EXECUTE master.dbo.xp_dirtree N'" + e.Node.FullPath + "', 1, 1";
         dsFiles.Clear();
         daFiles.Fill(dsFiles);
         foreach(DataRow dr in dsFiles.Tables[0].Rows)
         {
            if(dr["file"].ToString() == "0")
            {
               TreeNode tmpTreeSubNode = @e.Node.Nodes.Add(dr["subdirectory"].ToString());
               tmpTreeSubNode.ImageIndex = 1;
               tmpTreeSubNode.SelectedImageIndex = 3;
               tmpTreeSubNode.Tag = 1;
            }
         }
         foreach(DataRow dr in dsFiles.Tables[0].Rows)
         {
            if(dr["file"].ToString() == "1")
            {
               TreeNode tmpTreeSubNode = @e.Node.Nodes.Add(dr["subdirectory"].ToString());
               tmpTreeSubNode.ImageIndex = 2;
               tmpTreeSubNode.SelectedImageIndex = 4;
               tmpTreeSubNode.Tag = 2;
            }
         }
         e.Node.Expand();

      }
   }
}
