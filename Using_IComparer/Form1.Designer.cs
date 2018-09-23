namespace Using_IComparer
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbPrice = new System.Windows.Forms.RadioButton();
            this.carListView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHorsepower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSortDecending = new System.Windows.Forms.CheckBox();
            this.rbTopSpeed = new System.Windows.Forms.RadioButton();
            this.rbHorsepower = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHorsepower);
            this.groupBox1.Controls.Add(this.rbTopSpeed);
            this.groupBox1.Controls.Add(this.rbPrice);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.Location = new System.Drawing.Point(17, 20);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(73, 24);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            this.rbName.Click += new System.EventHandler(this.rbName_Click);
            // 
            // rbPrice
            // 
            this.rbPrice.AutoSize = true;
            this.rbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrice.Location = new System.Drawing.Point(134, 20);
            this.rbPrice.Name = "rbPrice";
            this.rbPrice.Size = new System.Drawing.Size(67, 24);
            this.rbPrice.TabIndex = 1;
            this.rbPrice.TabStop = true;
            this.rbPrice.Text = "Price";
            this.rbPrice.UseVisualStyleBackColor = true;
            this.rbPrice.CheckedChanged += new System.EventHandler(this.rbPrice_CheckedChanged);
            this.rbPrice.Click += new System.EventHandler(this.rbPrice_Click);
            // 
            // carListView
            // 
            this.carListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPrice,
            this.colSpeed,
            this.colHorsepower});
            this.carListView.GridLines = true;
            this.carListView.LabelWrap = false;
            this.carListView.Location = new System.Drawing.Point(31, 115);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(746, 301);
            this.carListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.carListView.TabIndex = 2;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 300;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 100;
            // 
            // colSpeed
            // 
            this.colSpeed.Text = "Top Speed";
            this.colSpeed.Width = 100;
            // 
            // colHorsepower
            // 
            this.colHorsepower.Text = "Horsepower";
            this.colHorsepower.Width = 150;
            // 
            // cbSortDecending
            // 
            this.cbSortDecending.AutoSize = true;
            this.cbSortDecending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortDecending.Location = new System.Drawing.Point(636, 50);
            this.cbSortDecending.Name = "cbSortDecending";
            this.cbSortDecending.Size = new System.Drawing.Size(102, 20);
            this.cbSortDecending.TabIndex = 3;
            this.cbSortDecending.Text = "Decending";
            this.cbSortDecending.UseVisualStyleBackColor = true;
            this.cbSortDecending.CheckedChanged += new System.EventHandler(this.cbSortDecending_CheckedChanged);
            // 
            // rbTopSpeed
            // 
            this.rbTopSpeed.AutoSize = true;
            this.rbTopSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTopSpeed.Location = new System.Drawing.Point(246, 20);
            this.rbTopSpeed.Name = "rbTopSpeed";
            this.rbTopSpeed.Size = new System.Drawing.Size(114, 24);
            this.rbTopSpeed.TabIndex = 2;
            this.rbTopSpeed.TabStop = true;
            this.rbTopSpeed.Text = "Top Speed";
            this.rbTopSpeed.UseVisualStyleBackColor = true;
            this.rbTopSpeed.CheckedChanged += new System.EventHandler(this.rbTopSpeed_CheckedChanged);
            this.rbTopSpeed.Click += new System.EventHandler(this.rbTopSpeed_Click);
            // 
            // rbHorsepower
            // 
            this.rbHorsepower.AutoSize = true;
            this.rbHorsepower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHorsepower.Location = new System.Drawing.Point(394, 20);
            this.rbHorsepower.Name = "rbHorsepower";
            this.rbHorsepower.Size = new System.Drawing.Size(123, 24);
            this.rbHorsepower.TabIndex = 3;
            this.rbHorsepower.TabStop = true;
            this.rbHorsepower.Text = "Horsepower";
            this.rbHorsepower.UseVisualStyleBackColor = true;
            this.rbHorsepower.Click += new System.EventHandler(this.rbHorsepower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSortDecending);
            this.Controls.Add(this.carListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrice;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.ListView carListView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colSpeed;
        private System.Windows.Forms.ColumnHeader colHorsepower;
        private System.Windows.Forms.CheckBox cbSortDecending;
        private System.Windows.Forms.RadioButton rbHorsepower;
        private System.Windows.Forms.RadioButton rbTopSpeed;
    }
}

