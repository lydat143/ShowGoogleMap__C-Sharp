namespace googlemap
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBView = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnCoordinate = new System.Windows.Forms.RadioButton();
            this.grbCoordinate = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbCoordinate.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbCoordinate);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnOK);
            this.splitContainer1.Panel1.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBView);
            this.splitContainer1.Size = new System.Drawing.Size(933, 415);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(63, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(255, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // webBView
            // 
            this.webBView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBView.Location = new System.Drawing.Point(0, 0);
            this.webBView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBView.Name = "webBView";
            this.webBView.Size = new System.Drawing.Size(588, 415);
            this.webBView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCoordinate);
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(16, 19);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(63, 17);
            this.rbtnAdd.TabIndex = 4;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Address";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // rbtnCoordinate
            // 
            this.rbtnCoordinate.AutoSize = true;
            this.rbtnCoordinate.Location = new System.Drawing.Point(186, 19);
            this.rbtnCoordinate.Name = "rbtnCoordinate";
            this.rbtnCoordinate.Size = new System.Drawing.Size(76, 17);
            this.rbtnCoordinate.TabIndex = 5;
            this.rbtnCoordinate.TabStop = true;
            this.rbtnCoordinate.Text = "Coordinate";
            this.rbtnCoordinate.UseVisualStyleBackColor = true;
            this.rbtnCoordinate.CheckedChanged += new System.EventHandler(this.rbtnCoordinate_CheckedChanged);
            // 
            // grbCoordinate
            // 
            this.grbCoordinate.Controls.Add(this.txtLong);
            this.grbCoordinate.Controls.Add(this.txtLat);
            this.grbCoordinate.Controls.Add(this.label3);
            this.grbCoordinate.Controls.Add(this.label2);
            this.grbCoordinate.Location = new System.Drawing.Point(12, 100);
            this.grbCoordinate.Name = "grbCoordinate";
            this.grbCoordinate.Size = new System.Drawing.Size(306, 97);
            this.grbCoordinate.TabIndex = 6;
            this.grbCoordinate.TabStop = false;
            this.grbCoordinate.Text = "Coordinate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Long:";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(51, 28);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(239, 20);
            this.txtLat.TabIndex = 7;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(51, 58);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(239, 20);
            this.txtLong.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCoordinate.ResumeLayout(false);
            this.grbCoordinate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBView;
        private System.Windows.Forms.GroupBox grbCoordinate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCoordinate;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

