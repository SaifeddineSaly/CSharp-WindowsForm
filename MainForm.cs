using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace MySqlTP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_exitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Btn_insertClick(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database=  tps ;Data Source=localhost;User Id=root;Password=";
        	dbcon.Open();
        	
	     	string queryInsert;
 		 	queryInsert=" INSERT INTO `etudiant` (`id`, `nom`, `phone`, `addresse`, `birthday`) VALUES (NULL, @nom, @phone, @adrs, @birth)";
         	MySqlCommand cmd = new MySqlCommand(queryInsert, dbcon);
         
         	cmd.Parameters.AddWithValue("@nom", txtnom.Text);
         	cmd.Parameters.AddWithValue("@phone", txtphone.Text);
         	cmd.Parameters.AddWithValue("@adrs", txtadrs.Text);
         	cmd.Parameters.AddWithValue("@birth",dateTimePicker1.Value);
			// cmd excecution:         	
         	cmd.ExecuteNonQuery();
         	
	        dbcon.Close();
        	MessageBox.Show("Insertion Complet...");
		}
		void Btn_deleteClick(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database = tps; Data Source = localhost; User Id = root; Password=";    
 		    dbcon.Open();
 		    
			string queryDelete;	
        	queryDelete = "delete from etudiant where id=@id";
 
        	MySqlCommand cmd = new MySqlCommand(queryDelete, dbcon);
        
       	    cmd.Parameters.AddWithValue("@id",int.Parse(txtdel.Text));
         	cmd.ExecuteNonQuery();
         	
         	dbcon.Close();
         	MessageBox.Show("Finish Delete...");
		}
		void Btn_updateClick(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database = tps; Data Source = localhost; User Id = root; Password=";
	        dbcon.Open();
	        
			string queryUpdate;
			queryUpdate = "UPDATE `etudiant` SET `nom` = @nom, `phone` = @phone, `addresse` = @adrs, `birthday` = @birth WHERE `etudiant`.`id` = @id";
        
       		MySqlCommand cmd = new MySqlCommand(queryUpdate,dbcon);
        	cmd.Parameters.AddWithValue("@id",int.Parse(txtupd.Text));
        	cmd.Parameters.AddWithValue("@nom", txtnom.Text);
         	cmd.Parameters.AddWithValue("@phone", txtphone.Text);
         	cmd.Parameters.AddWithValue("@adrs", txtadrs.Text);
         	cmd.Parameters.AddWithValue("@birth",dateTimePicker1.Value);
        	
         	cmd.ExecuteNonQuery();
         	dbcon.Close();
         	MessageBox.Show("Success UPDATE");
		}
		void Btn_gridClick(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database=  tps; Data Source=localhost; User Id=root; Password=";
	        dbcon.Open();
        
			string query;
			query = "select * from etudiant order by id desc";
			
			DataTable dt = new DataTable();
			MySqlDataAdapter adp = new MySqlDataAdapter(query, dbcon);
			adp.Fill(dt);
			dataGridView1.DataSource=dt;
		}
		void Btn_clearClick(object sender, EventArgs e)
		{
			txtid.Clear();
			txtnom.Clear();
			txtphone.Clear();
			txtadrs.Clear();
			txtdel.Clear();
			txtupd.Clear();
			dateTimePicker1.Value=DateTime.Now;
			dataGridView1.DataSource = null;
			listBox1.Items.Clear();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtnom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtadrs.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
//			dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
		int k = 0;
		void Btn_selfromlistClick(object sender, EventArgs e)
		{
			if (k.Equals(0)){
				listBox1.Items.Add("Id   Nom   Phone   Addresse   Birth");
				k = 1;
			}
//			int n = 0;
			string valeur = "";
			for (int rows = 0; rows <dataGridView1.Rows.Count - 1; rows++)
			{
				if (!rows.Equals(dataGridView1.CurrentCell.RowIndex))
					continue;
				for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
				{
//					n++;
					valeur += dataGridView1.Rows[rows].Cells[col].Value.ToString();
					valeur += " ";
				}
				listBox1.Items.Add(valeur);
				valeur = "";
			  }
			/*
			int n = dataGridView1.CurrentCell.RowIndex;
			listBox1.Items.Add(dataGridView1.CurrentCell.RowIndex);
			/*
			string valeur2 = "";
			for (int z = 0; z < dataGridView1.SelectedRows.Count - 1; z++)
			{
				valeur2 += dataGridView1.CurrentCell.RowIndex
			}
			foreach (DataGridViewRow row in dataGridView.SelectedRows) 
		    {
				string value1 = row.Cells[0].Value.ToString();
		        string value2 = row.Cells[1].Value.ToString();
		    }
		    */
			//string val = "Hello World!";
//			string np = "nb of cells is : " + n;
			/*string str = dataGridView1.Rows[0].Cells[0].Value.ToString();
			 str += " " + dataGridView1.Rows[0].Cells[1].Value.ToString();
			 str += " " + dataGridView1.Rows[0].Cells[2].Value.ToString();
			 str += " " + dataGridView1.Rows[0].Cells[3].Value.ToString();
			 str += " " + dataGridView1.Rows[0].Cells[4].Value.ToString();
			 str += "\n" + dataGridView1.Rows[3].Cells[0].Value.ToString();
			 str += " " + dataGridView1.Rows[3].Cells[1].Value.ToString();
			 str += " " + dataGridView1.Rows[3].Cells[2].Value.ToString();
			 str += " " + dataGridView1.Rows[3].Cells[3].Value.ToString();
			 str += " " + dataGridView1.Rows[3].Cells[4].Value.ToString();
			 */
			 // int nbrows = dataGridView1.Rows.Count;
			 // int nbcells = dataGridView1.Rows[0].Cells.Count;
//			listBox1.Items.Clear(); 
			// listBox1.Items.Add(nbrows + " " + nbcells);
//			listBox1.Items.Add(valeur);
//			listBox1.Items.Add("nb of cells is : " + n + "\t" + str);
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
//			listBox1.SelectedItem.ToString();
//			listBox1.se
		}
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database=  tps ;Data Source=localhost;User Id=root;Password=";
        	dbcon.Open();
        	
	     	string queryInsert;
 		 	queryInsert=" INSERT INTO `etudiant` (`id`, `nom`, `phone`, `addresse`, `birthday`) VALUES (NULL, @nom, @phone, @adrs, @birth)";
         	MySqlCommand cmd = new MySqlCommand(queryInsert, dbcon);
         
         	cmd.Parameters.AddWithValue("@nom", txtnom.Text);
         	cmd.Parameters.AddWithValue("@phone", txtphone.Text);
         	cmd.Parameters.AddWithValue("@adrs", txtadrs.Text);
         	cmd.Parameters.AddWithValue("@birth",dateTimePicker1.Value);
			// cmd excecution:         	
         	cmd.ExecuteNonQuery();
         	
	        dbcon.Close();
        	MessageBox.Show("Insertion Complet...");
		}
		void ToolStripMenuItem7Click(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database=  tps; Data Source=localhost; User Id=root; Password=";
	        dbcon.Open();
        
			string query;
			query = "select departement.deptName, etudiant.nom from etudiant, departement where etudiant.depId = departement.depId order by id desc";
			
			DataTable dt = new DataTable();
			MySqlDataAdapter adp = new MySqlDataAdapter(query, dbcon);
			adp.Fill(dt);
			dataGridView1.DataSource=dt;
		}
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database = tps; Data Source = localhost; User Id = root; Password=";
	        dbcon.Open();
	        
			string queryUpdate;
			queryUpdate = "UPDATE `etudiant` SET `nom` = @nom, `phone` = @phone, `addresse` = @adrs, `birthday` = @birth WHERE `etudiant`.`id` = @id";
        
       		MySqlCommand cmd = new MySqlCommand(queryUpdate,dbcon);
        	cmd.Parameters.AddWithValue("@id",int.Parse(txtupd.Text));
        	cmd.Parameters.AddWithValue("@nom", txtnom.Text);
         	cmd.Parameters.AddWithValue("@phone", txtphone.Text);
         	cmd.Parameters.AddWithValue("@adrs", txtadrs.Text);
         	cmd.Parameters.AddWithValue("@birth",dateTimePicker1.Value);
        	
         	cmd.ExecuteNonQuery();
         	dbcon.Close();
         	MessageBox.Show("Success UPDATE");
		}
		void ToolStripMenuItem8Click(object sender, EventArgs e)
		{
			if (k.Equals(0)){
				listBox1.Items.Add("Id   Nom   Phone   Addresse   Birth");
				k = 1;
			}
//			int n = 0;
			string valeur = "";
			for (int rows = 0; rows <dataGridView1.Rows.Count - 1; rows++)
			{
				if (!rows.Equals(dataGridView1.CurrentCell.RowIndex))
					continue;
				for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
				{
//					n++;
					valeur += dataGridView1.Rows[rows].Cells[col].Value.ToString();
					valeur += " ";
				}
				listBox1.Items.Add(valeur);
				valeur = "";
			  }
		}
		void ToolStripMenuItem10Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Button2Click(object sender, EventArgs e)
		{
			MySqlConnection dbcon = new MySqlConnection();
	    	dbcon.ConnectionString="Database=  tps; Data Source=localhost; User Id=root; Password=";
	        dbcon.Open();
        
			string query;
			query = "select * from etudiant order by id desc";
			
			DataTable dt = new DataTable();
			MySqlDataAdapter adp = new MySqlDataAdapter(query, dbcon);
			adp.Fill(dt);
			dataGridView1.DataSource=dt;
		}
		void Bt_searchClick(object sender, EventArgs e)
		{
			MySqlConnection cnx = new MySqlConnection();
			cnx.ConnectionString = "Database=  tps; Data Source=localhost; User Id=root; Password=";
			cnx.Open();
			
			string query;
			query = "select nom from etudiant where nom like '"+txt_seacrh.Text+"%'";
			
			DataTable dt = new DataTable();
			MySqlDataAdapter adp = new MySqlDataAdapter(query, cnx);
			adp.Fill(dt);
			dataGridView1.DataSource = dt;
			
		}
		void Bt_ExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Txt_seacrhTextChanged(object sender, EventArgs e)
		{
			MySqlConnection cnx = new MySqlConnection();
			cnx.ConnectionString = "Database=  tps; Data Source=localhost; User Id=root; Password=";
			cnx.Open();
			
			string query = "", tmpVal = "";
			tmpVal = txt_seacrh.Text;
			query = "select nom from etudiant where nom like '"+txt_seacrh.Text+"%'";
			
			DataTable dt = new DataTable();
			MySqlDataAdapter adp = new MySqlDataAdapter(query, cnx);
			adp.Fill(dt);
			
			ArrayList arl = new ArrayList();
			foreach (DataRow row in dt.Rows) {
				
				arl.Add(row["nom"]);
			}
			string [] arr = arl.ToArray(typeof(string)) as string[];
			
			string newval = arr[0];
			
//			string [] strsplit = newval.Split(tmpVal);
//			txt_seacrh.Text = newval;
			string [] chtostr = new string[newval.Length];
			
			string [] dn = new string[]{tmpVal};
			string [] splttt = newval.Split(dn, StringSplitOptions.None);
//			txt_seacrh.BackColor = Color.LightBlue;
//			txt_seacrh.ForeColor = Color.Black;
			txt_seacrh.Text = tmpVal;
			foreach (var element in splttt) {
				//				listBox1.Items.Add(element);
				txt_seacrh.ForeColor = Color.Red;
				txt_seacrh.Text = element;
			}
			
		}
	}
}
