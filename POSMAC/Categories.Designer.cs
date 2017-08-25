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
            this.deptgroupBox1 = new System.Windows.Forms.GroupBox();
            this.deptcancel = new System.Windows.Forms.Button();
            this.deslabel2 = new System.Windows.Forms.Label();
            this.deptdesc = new System.Windows.Forms.TextBox();
            this.deptname = new System.Windows.Forms.TextBox();
            this.deslabel1 = new System.Windows.Forms.Label();
            this.depyGridView1 = new System.Windows.Forms.DataGridView();
            this.deptgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depyGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.depatsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.depatsave.Font = new System.Drawing.Font("Montserrat Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depatsave.ForeColor = System.Drawing.Color.White;
            this.depatsave.Image = global::POSMAC.Properties.Resources.ic_save_white_24dp_2x1;
            this.depatsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depatsave.Location = new System.Drawing.Point(664, 19);
            this.depatsave.Name = "button1";
            this.depatsave.Size = new System.Drawing.Size(163, 55);
            this.depatsave.TabIndex = 1;
            this.depatsave.Text = "Save";
            this.depatsave.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.deptgroupBox1.Controls.Add(this.deslabel2);
            this.deptgroupBox1.Controls.Add(this.deptdesc);
            this.deptgroupBox1.Controls.Add(this.deptname);
            this.deptgroupBox1.Controls.Add(this.deslabel1);
            this.deptgroupBox1.Controls.Add(this.deptcancel);
            this.deptgroupBox1.Controls.Add(this.depatsave);
            this.deptgroupBox1.Location = new System.Drawing.Point(23, 63);
            this.deptgroupBox1.Name = "groupBox1";
            this.deptgroupBox1.Size = new System.Drawing.Size(833, 158);
            this.deptgroupBox1.TabIndex = 2;
            this.deptgroupBox1.TabStop = false;
            // 
            // button2
            // 
            this.deptcancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.deptcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deptcancel.Font = new System.Drawing.Font("Montserrat Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptcancel.ForeColor = System.Drawing.Color.White;
            this.deptcancel.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.deptcancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deptcancel.Location = new System.Drawing.Point(664, 80);
            this.deptcancel.Name = "button2";
            this.deptcancel.Size = new System.Drawing.Size(163, 55);
            this.deptcancel.TabIndex = 2;
            this.deptcancel.Text = " Cancel";
            this.deptcancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deptcancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.deslabel2.AutoSize = true;
            this.deslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deslabel2.Location = new System.Drawing.Point(17, 93);
            this.deslabel2.Name = "label2";
            this.deslabel2.Size = new System.Drawing.Size(151, 31);
            this.deslabel2.TabIndex = 9;
            this.deslabel2.Text = "Description";
            // 
            // textBox2
            // 
            this.deptdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptdesc.Location = new System.Drawing.Point(174, 89);
            this.deptdesc.Name = "textBox2";
            this.deptdesc.Size = new System.Drawing.Size(441, 38);
            this.deptdesc.TabIndex = 8;
            this.deptdesc.Text = "ss";
            // 
            // textBox1
            // 
            this.deptname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptname.Location = new System.Drawing.Point(174, 36);
            this.deptname.Name = "textBox1";
            this.deptname.Size = new System.Drawing.Size(441, 38);
            this.deptname.TabIndex = 7;
            this.deptname.Text = "ss";
            // 
            // label1
            // 
            this.deslabel1.AutoSize = true;
            this.deslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deslabel1.Location = new System.Drawing.Point(17, 39);
            this.deslabel1.Name = "label1";
            this.deslabel1.Size = new System.Drawing.Size(86, 31);
            this.deslabel1.TabIndex = 6;
            this.deslabel1.Text = "Name";
            // 
            // dataGridView1
            // 
            this.depyGridView1.BackgroundColor = System.Drawing.Color.White;
            this.depyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depyGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.depyGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.depyGridView1.Location = new System.Drawing.Point(20, 247);
            this.depyGridView1.Name = "dataGridView1";
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
            this.Controls.Add(this.deptgroupBox1);
            this.KeyPreview = true;
            this.Name = "Categories";
            this.Resizable = false;
            this.Text = "Categories";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deptgroupBox1.ResumeLayout(false);
            this.deptgroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depyGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}