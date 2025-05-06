namespace MarketDashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAvgPrice = new System.Windows.Forms.Label();
            this.labelTotalVolume = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxTicker = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(601, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelAvgPrice
            // 
            this.labelAvgPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvgPrice.AutoSize = true;
            this.labelAvgPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAvgPrice.Location = new System.Drawing.Point(331, 9);
            this.labelAvgPrice.Name = "labelAvgPrice";
            this.labelAvgPrice.Size = new System.Drawing.Size(153, 25);
            this.labelAvgPrice.TabIndex = 1;
            this.labelAvgPrice.Text = "Average Price:";
            this.labelAvgPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTotalVolume
            // 
            this.labelTotalVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalVolume.AutoSize = true;
            this.labelTotalVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTotalVolume.Location = new System.Drawing.Point(554, 9);
            this.labelTotalVolume.Name = "labelTotalVolume";
            this.labelTotalVolume.Size = new System.Drawing.Size(144, 25);
            this.labelTotalVolume.TabIndex = 2;
            this.labelTotalVolume.Text = "Total Volume:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.buttonRefresh.Location = new System.Drawing.Point(3, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(150, 35);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh Data";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxTicker
            // 
            this.comboBoxTicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.comboBoxTicker.FormattingEnabled = true;
            this.comboBoxTicker.Location = new System.Drawing.Point(15, 22);
            this.comboBoxTicker.Name = "comboBoxTicker";
            this.comboBoxTicker.Size = new System.Drawing.Size(150, 33);
            this.comboBoxTicker.TabIndex = 4;
            this.comboBoxTicker.Text = "Select Ticker";
            this.comboBoxTicker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.labelAvgPrice);
            this.panel1.Controls.Add(this.labelTotalVolume);
            this.panel1.Location = new System.Drawing.Point(12, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 47);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTicker);
            this.Name = "Form1";
            this.Text = "Market Data Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAvgPrice;
        private System.Windows.Forms.Label labelTotalVolume;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxTicker;
        private System.Windows.Forms.Panel panel1;
    }
}

