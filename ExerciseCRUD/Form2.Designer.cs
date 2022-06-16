
namespace ExerciseCRUD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameAndLibraryDataSet = new ExerciseCRUD.GameAndLibraryDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new ExerciseCRUD.GameAndLibraryDataSetTableAdapters.gamesTableAdapter();
            this.gameidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamegenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameplatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameAndLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtCountry, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtState, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(487, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 221);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCountry.Location = new System.Drawing.Point(141, 184);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(95, 22);
            this.txtCountry.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtState.Location = new System.Drawing.Point(141, 138);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(301, 22);
            this.txtState.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.Location = new System.Drawing.Point(141, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(301, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(141, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 22);
            this.txtName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Platform";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "genre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCode.Location = new System.Drawing.Point(141, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(95, 22);
            this.txtCode.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameidDataGridViewTextBoxColumn,
            this.gamenameDataGridViewTextBoxColumn,
            this.gamegenreDataGridViewTextBoxColumn,
            this.gameplatformDataGridViewTextBoxColumn,
            this.gamepriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.textBox1.Location = new System.Drawing.Point(242, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 57);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "GAMES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExerciseCRUD.Properties.Resources.video_game;
            this.pictureBox1.Location = new System.Drawing.Point(226, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gameAndLibraryDataSet
            // 
            this.gameAndLibraryDataSet.DataSetName = "GameAndLibraryDataSet";
            this.gameAndLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.gameAndLibraryDataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // gameidDataGridViewTextBoxColumn
            // 
            this.gameidDataGridViewTextBoxColumn.DataPropertyName = "game_id";
            this.gameidDataGridViewTextBoxColumn.HeaderText = "game_id";
            this.gameidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameidDataGridViewTextBoxColumn.Name = "gameidDataGridViewTextBoxColumn";
            this.gameidDataGridViewTextBoxColumn.Width = 125;
            // 
            // gamenameDataGridViewTextBoxColumn
            // 
            this.gamenameDataGridViewTextBoxColumn.DataPropertyName = "game_name";
            this.gamenameDataGridViewTextBoxColumn.HeaderText = "game_name";
            this.gamenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gamenameDataGridViewTextBoxColumn.Name = "gamenameDataGridViewTextBoxColumn";
            this.gamenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gamegenreDataGridViewTextBoxColumn
            // 
            this.gamegenreDataGridViewTextBoxColumn.DataPropertyName = "game_genre";
            this.gamegenreDataGridViewTextBoxColumn.HeaderText = "game_genre";
            this.gamegenreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gamegenreDataGridViewTextBoxColumn.Name = "gamegenreDataGridViewTextBoxColumn";
            this.gamegenreDataGridViewTextBoxColumn.Width = 125;
            // 
            // gameplatformDataGridViewTextBoxColumn
            // 
            this.gameplatformDataGridViewTextBoxColumn.DataPropertyName = "game_platform";
            this.gameplatformDataGridViewTextBoxColumn.HeaderText = "game_platform";
            this.gameplatformDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gameplatformDataGridViewTextBoxColumn.Name = "gameplatformDataGridViewTextBoxColumn";
            this.gameplatformDataGridViewTextBoxColumn.Width = 125;
            // 
            // gamepriceDataGridViewTextBoxColumn
            // 
            this.gamepriceDataGridViewTextBoxColumn.DataPropertyName = "game_price";
            this.gamepriceDataGridViewTextBoxColumn.HeaderText = "game_price";
            this.gamepriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gamepriceDataGridViewTextBoxColumn.Name = "gamepriceDataGridViewTextBoxColumn";
            this.gamepriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(37, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 38);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "<<<BACK";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(971, 527);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameAndLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private GameAndLibraryDataSet gameAndLibraryDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GameAndLibraryDataSetTableAdapters.gamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamegenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameplatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
    }
}