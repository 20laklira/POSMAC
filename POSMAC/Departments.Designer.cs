namespace POSMAC
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.depatsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depatcancel = new System.Windows.Forms.Button();
            this.depyGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depyGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // depatsave
            // 
            this.depatsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.depatsave.Font = new System.Drawing.Font("Montserrat Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depatsave.ForeColor = System.Drawing.Color.White;
            this.depatsave.Image = global::POSMAC.Properties.Resources.ic_save_white_24dp_2x1;
            this.depatsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depatsave.Location = new System.Drawing.Point(664, 19);
            this.depatsave.Name = "depatsave";
            this.depatsave.Size = new System.Drawing.Size(163, 55);
            this.depatsave.TabIndex = 1;
            this.depatsave.Text = "Save";
            this.depatsave.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.depatcancel);
            this.groupBox1.Controls.Add(this.depatsave);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(174, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(441, 38);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "ss";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "ss";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // depatcancel
            // 
            this.depatcancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.depatcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.depatcancel.Font = new System.Drawing.Font("Montserrat Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depatcancel.ForeColor = System.Drawing.Color.White;
            this.depatcancel.Image = ((System.Drawing.Image)(resources.GetObject("depatcancel.Image")));
            this.depatcancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depatcancel.Location = new System.Drawing.Point(664, 80);
            this.depatcancel.Name = "depatcancel";
            this.depatcancel.Size = new System.Drawing.Size(163, 55);
            this.depatcancel.TabIndex = 2;
            this.depatcancel.Text = " Cancel";
            this.depatcancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depatcancel.UseVisualStyleBackColor = false;
            // 
            // depyGridView1
            // 
            this.depyGridView1.BackgroundColor = System.Drawing.Color.White;
            this.depyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depyGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.depyGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.depyGridView1.Location = new System.Drawing.Point(20, 247);
            this.depyGridView1.Name = "depyGridView1";
            this.depyGridView1.Size = new System.Drawing.Size(839, 181);
            this.depyGridView1.TabIndex = 3;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(879, 448);
            this.Controls.Add(this.depyGridView1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Categories";
            this.Resizable = false;
            this.Text = "Departments";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depyGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button depatsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button depatcancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView depyGridView1;
    }
}