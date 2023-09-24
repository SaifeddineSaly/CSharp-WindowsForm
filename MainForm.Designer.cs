/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 7/6/2022
 * Time: 11:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MySqlTP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtnom;
		private System.Windows.Forms.TextBox txtphone;
		private System.Windows.Forms.TextBox txtadrs;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_selfromlist;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox txtupd;
		private System.Windows.Forms.TextBox txtdel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button bt_search;
		private System.Windows.Forms.TextBox txt_seacrh;
		private System.Windows.Forms.Button bt_Exit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtnom = new System.Windows.Forms.TextBox();
			this.txtphone = new System.Windows.Forms.TextBox();
			this.txtadrs = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_selfromlist = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.txtupd = new System.Windows.Forms.TextBox();
			this.txtdel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_exit = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.bt_search = new System.Windows.Forms.Button();
			this.txt_seacrh = new System.Windows.Forms.TextBox();
			this.bt_Exit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(65, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(65, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(65, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "Birthday(y/d/m):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(65, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "Addresse: ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(65, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "Phone: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtnom
			// 
			this.txtnom.Location = new System.Drawing.Point(265, 116);
			this.txtnom.Name = "txtnom";
			this.txtnom.Size = new System.Drawing.Size(200, 32);
			this.txtnom.TabIndex = 6;
			// 
			// txtphone
			// 
			this.txtphone.Location = new System.Drawing.Point(265, 156);
			this.txtphone.Name = "txtphone";
			this.txtphone.Size = new System.Drawing.Size(200, 32);
			this.txtphone.TabIndex = 7;
			// 
			// txtadrs
			// 
			this.txtadrs.Location = new System.Drawing.Point(265, 196);
			this.txtadrs.Name = "txtadrs";
			this.txtadrs.Size = new System.Drawing.Size(200, 32);
			this.txtadrs.TabIndex = 8;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(265, 78);
			this.txtid.Name = "txtid";
			this.txtid.ReadOnly = true;
			this.txtid.Size = new System.Drawing.Size(200, 32);
			this.txtid.TabIndex = 9;
			// 
			// btn_update
			// 
			this.btn_update.BackColor = System.Drawing.Color.DimGray;
			this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_update.ForeColor = System.Drawing.Color.White;
			this.btn_update.Location = new System.Drawing.Point(537, 182);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(186, 46);
			this.btn_update.TabIndex = 11;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = false;
			this.btn_update.Click += new System.EventHandler(this.Btn_updateClick);
			// 
			// btn_selfromlist
			// 
			this.btn_selfromlist.BackColor = System.Drawing.Color.DimGray;
			this.btn_selfromlist.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_selfromlist.ForeColor = System.Drawing.Color.White;
			this.btn_selfromlist.Location = new System.Drawing.Point(537, 234);
			this.btn_selfromlist.Name = "btn_selfromlist";
			this.btn_selfromlist.Size = new System.Drawing.Size(186, 46);
			this.btn_selfromlist.TabIndex = 12;
			this.btn_selfromlist.Text = "Select From List";
			this.btn_selfromlist.UseVisualStyleBackColor = false;
			this.btn_selfromlist.Click += new System.EventHandler(this.Btn_selfromlistClick);
			// 
			// btn_clear
			// 
			this.btn_clear.BackColor = System.Drawing.Color.DimGray;
			this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_clear.ForeColor = System.Drawing.Color.White;
			this.btn_clear.Location = new System.Drawing.Point(537, 286);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(186, 46);
			this.btn_clear.TabIndex = 13;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.Btn_clearClick);
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.Color.DimGray;
			this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_delete.ForeColor = System.Drawing.Color.White;
			this.btn_delete.Location = new System.Drawing.Point(537, 130);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(186, 46);
			this.btn_delete.TabIndex = 14;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.Btn_deleteClick);
			// 
			// txtupd
			// 
			this.txtupd.Location = new System.Drawing.Point(957, 190);
			this.txtupd.Name = "txtupd";
			this.txtupd.Size = new System.Drawing.Size(182, 32);
			this.txtupd.TabIndex = 15;
			// 
			// txtdel
			// 
			this.txtdel.Location = new System.Drawing.Point(957, 144);
			this.txtdel.Name = "txtdel";
			this.txtdel.Size = new System.Drawing.Size(182, 32);
			this.txtdel.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(757, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(169, 46);
			this.label6.TabIndex = 17;
			this.label6.Text = "Id-Etudiant-Del";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(757, 182);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(182, 46);
			this.label7.TabIndex = 18;
			this.label7.Text = "Id-Etudiant-Up";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 24;
			this.listBox1.Location = new System.Drawing.Point(610, 363);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(529, 148);
			this.listBox1.TabIndex = 19;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(41, 363);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(563, 150);
			this.dataGridView1.TabIndex = 20;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(1118, 49);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(33, 35);
			this.btn_exit.TabIndex = 22;
			this.btn_exit.Text = "X";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.Btn_exitClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Gold;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(0, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(1151, 46);
			this.label8.TabIndex = 23;
			this.label8.Text = "Student Data";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(265, 235);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
			this.dateTimePicker1.TabIndex = 24;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
			this.menuStrip1.TabIndex = 25;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem2,
			this.toolStripMenuItem4,
			this.toolStripMenuItem9,
			this.toolStripMenuItem10});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 24);
			this.toolStripMenuItem1.Text = "Data Mang";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem3,
			this.toolStripMenuItem5,
			this.toolStripMenuItem6});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 26);
			this.toolStripMenuItem2.Text = "Data Modification";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 26);
			this.toolStripMenuItem3.Text = "Insert";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 26);
			this.toolStripMenuItem5.Text = "Update";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(133, 26);
			this.toolStripMenuItem6.Text = "Delete";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem7,
			this.toolStripMenuItem8});
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(205, 26);
			this.toolStripMenuItem4.Text = "Data Search";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(185, 26);
			this.toolStripMenuItem7.Text = "List";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(185, 26);
			this.toolStripMenuItem8.Text = "Select From list";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.ToolStripMenuItem8Click);
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(205, 26);
			this.toolStripMenuItem9.Text = "Clear";
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(205, 26);
			this.toolStripMenuItem10.Text = "Close";
			this.toolStripMenuItem10.Click += new System.EventHandler(this.ToolStripMenuItem10Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(537, 78);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 46);
			this.button1.TabIndex = 26;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DimGray;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(41, 296);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(186, 46);
			this.button2.TabIndex = 27;
			this.button2.Text = "List";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// bt_search
			// 
			this.bt_search.Location = new System.Drawing.Point(777, 246);
			this.bt_search.Name = "bt_search";
			this.bt_search.Size = new System.Drawing.Size(135, 34);
			this.bt_search.TabIndex = 28;
			this.bt_search.Text = "Search";
			this.bt_search.UseVisualStyleBackColor = true;
			this.bt_search.Click += new System.EventHandler(this.Bt_searchClick);
			// 
			// txt_seacrh
			// 
			this.txt_seacrh.Location = new System.Drawing.Point(957, 248);
			this.txt_seacrh.Name = "txt_seacrh";
			this.txt_seacrh.Size = new System.Drawing.Size(182, 32);
			this.txt_seacrh.TabIndex = 29;
			this.txt_seacrh.TextChanged += new System.EventHandler(this.Txt_seacrhTextChanged);
			// 
			// bt_Exit
			// 
			this.bt_Exit.Location = new System.Drawing.Point(777, 306);
			this.bt_Exit.Name = "bt_Exit";
			this.bt_Exit.Size = new System.Drawing.Size(135, 36);
			this.bt_Exit.TabIndex = 30;
			this.bt_Exit.Text = "Exit";
			this.bt_Exit.UseVisualStyleBackColor = true;
			this.bt_Exit.Click += new System.EventHandler(this.Bt_ExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1151, 509);
			this.Controls.Add(this.bt_Exit);
			this.Controls.Add(this.txt_seacrh);
			this.Controls.Add(this.bt_search);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtdel);
			this.Controls.Add(this.txtupd);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_selfromlist);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.txtadrs);
			this.Controls.Add(this.txtphone);
			this.Controls.Add(this.txtnom);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "MainForm";
			this.Text = "MySqlTP";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
