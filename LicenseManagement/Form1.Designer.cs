namespace LicenseManagement
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
            this.panelKey = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.txtExTime = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdjourn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGetKeyActived = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.pannelGen = new System.Windows.Forms.Panel();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelReset = new System.Windows.Forms.Panel();
            this.btnResetKey = new System.Windows.Forms.Button();
            this.txtKeyReset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAdjourn = new System.Windows.Forms.Panel();
            this.btnPnAdjourn = new System.Windows.Forms.Button();
            this.txtNumDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeyAdjourn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgKey = new System.Windows.Forms.DataGridView();
            this.panelKey.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pannelGen.SuspendLayout();
            this.panelReset.SuspendLayout();
            this.panelAdjourn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKey)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKey
            // 
            this.panelKey.Controls.Add(this.cbStatus);
            this.panelKey.Controls.Add(this.dtEnd);
            this.panelKey.Controls.Add(this.dtStart);
            this.panelKey.Controls.Add(this.label4);
            this.panelKey.Controls.Add(this.label6);
            this.panelKey.Controls.Add(this.label3);
            this.panelKey.Controls.Add(this.label5);
            this.panelKey.Controls.Add(this.label7);
            this.panelKey.Controls.Add(this.label2);
            this.panelKey.Controls.Add(this.txtMain);
            this.panelKey.Controls.Add(this.txtExTime);
            this.panelKey.Controls.Add(this.txtCPU);
            this.panelKey.Controls.Add(this.txtKey);
            this.panelKey.Controls.Add(this.label1);
            this.panelKey.Location = new System.Drawing.Point(12, 12);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(504, 124);
            this.panelKey.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "noactive",
            "inactive"});
            this.cbStatus.Location = new System.Drawing.Point(408, 91);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(83, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(72, 93);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(121, 20);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(351, 52);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(140, 20);
            this.dtStart.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Expired Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main:";
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(346, 10);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(145, 20);
            this.txtMain.TabIndex = 1;
            // 
            // txtExTime
            // 
            this.txtExTime.Location = new System.Drawing.Point(289, 93);
            this.txtExTime.Name = "txtExTime";
            this.txtExTime.Size = new System.Drawing.Size(56, 20);
            this.txtExTime.TabIndex = 1;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(48, 52);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(145, 20);
            this.txtCPU.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(48, 10);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(145, 20);
            this.txtKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdjourn);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnGenKey);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnGetKeyActived);
            this.panel2.Controls.Add(this.btnGetAll);
            this.panel2.Location = new System.Drawing.Point(522, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 124);
            this.panel2.TabIndex = 1;
            // 
            // btnAdjourn
            // 
            this.btnAdjourn.Location = new System.Drawing.Point(94, 89);
            this.btnAdjourn.Name = "btnAdjourn";
            this.btnAdjourn.Size = new System.Drawing.Size(75, 23);
            this.btnAdjourn.TabIndex = 0;
            this.btnAdjourn.Text = "Adjourn";
            this.btnAdjourn.UseVisualStyleBackColor = true;
            this.btnAdjourn.Click += new System.EventHandler(this.btnAdjourn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset Key";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenKey
            // 
            this.btnGenKey.Location = new System.Drawing.Point(94, 49);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(75, 23);
            this.btnGenKey.TabIndex = 0;
            this.btnGenKey.Text = "Gen Key";
            this.btnGenKey.UseVisualStyleBackColor = true;
            this.btnGenKey.Click += new System.EventHandler(this.btnGenKey_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGetKeyActived
            // 
            this.btnGetKeyActived.Location = new System.Drawing.Point(94, 8);
            this.btnGetKeyActived.Name = "btnGetKeyActived";
            this.btnGetKeyActived.Size = new System.Drawing.Size(75, 23);
            this.btnGetKeyActived.TabIndex = 0;
            this.btnGetKeyActived.Text = "Key Actived";
            this.btnGetKeyActived.UseVisualStyleBackColor = true;
            this.btnGetKeyActived.Click += new System.EventHandler(this.btnGetKeyActived_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(3, 8);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // pannelGen
            // 
            this.pannelGen.Controls.Add(this.btnGen);
            this.pannelGen.Controls.Add(this.txtQuantity);
            this.pannelGen.Controls.Add(this.label8);
            this.pannelGen.Location = new System.Drawing.Point(12, 12);
            this.pannelGen.Name = "pannelGen";
            this.pannelGen.Size = new System.Drawing.Size(504, 124);
            this.pannelGen.TabIndex = 3;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(290, 49);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(94, 26);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(123, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(126, 26);
            this.txtQuantity.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantity:";
            // 
            // panelReset
            // 
            this.panelReset.Controls.Add(this.btnResetKey);
            this.panelReset.Controls.Add(this.txtKeyReset);
            this.panelReset.Controls.Add(this.label9);
            this.panelReset.Location = new System.Drawing.Point(12, 12);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(507, 124);
            this.panelReset.TabIndex = 3;
            // 
            // btnResetKey
            // 
            this.btnResetKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetKey.Location = new System.Drawing.Point(304, 47);
            this.btnResetKey.Name = "btnResetKey";
            this.btnResetKey.Size = new System.Drawing.Size(94, 26);
            this.btnResetKey.TabIndex = 2;
            this.btnResetKey.Text = "Reset";
            this.btnResetKey.UseVisualStyleBackColor = true;
            this.btnResetKey.Click += new System.EventHandler(this.btnResetKey_Click);
            // 
            // txtKeyReset
            // 
            this.txtKeyReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyReset.Location = new System.Drawing.Point(99, 47);
            this.txtKeyReset.Name = "txtKeyReset";
            this.txtKeyReset.Size = new System.Drawing.Size(182, 26);
            this.txtKeyReset.TabIndex = 1;
            this.txtKeyReset.TextChanged += new System.EventHandler(this.txtKeyReset_TextChanged);
            this.txtKeyReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyReset_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Key:";
            // 
            // panelAdjourn
            // 
            this.panelAdjourn.Controls.Add(this.btnPnAdjourn);
            this.panelAdjourn.Controls.Add(this.txtNumDate);
            this.panelAdjourn.Controls.Add(this.label11);
            this.panelAdjourn.Controls.Add(this.txtKeyAdjourn);
            this.panelAdjourn.Controls.Add(this.label10);
            this.panelAdjourn.Location = new System.Drawing.Point(12, 12);
            this.panelAdjourn.Name = "panelAdjourn";
            this.panelAdjourn.Size = new System.Drawing.Size(507, 124);
            this.panelAdjourn.TabIndex = 4;
            // 
            // btnPnAdjourn
            // 
            this.btnPnAdjourn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPnAdjourn.Location = new System.Drawing.Point(313, 31);
            this.btnPnAdjourn.Name = "btnPnAdjourn";
            this.btnPnAdjourn.Size = new System.Drawing.Size(89, 62);
            this.btnPnAdjourn.TabIndex = 2;
            this.btnPnAdjourn.Text = "Adjourn";
            this.btnPnAdjourn.UseVisualStyleBackColor = true;
            this.btnPnAdjourn.Click += new System.EventHandler(this.btnPnAdjourn_Click);
            // 
            // txtNumDate
            // 
            this.txtNumDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDate.Location = new System.Drawing.Point(196, 71);
            this.txtNumDate.Name = "txtNumDate";
            this.txtNumDate.Size = new System.Drawing.Size(106, 22);
            this.txtNumDate.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity Date: ";
            // 
            // txtKeyAdjourn
            // 
            this.txtKeyAdjourn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyAdjourn.Location = new System.Drawing.Point(137, 31);
            this.txtKeyAdjourn.Name = "txtKeyAdjourn";
            this.txtKeyAdjourn.Size = new System.Drawing.Size(165, 22);
            this.txtKeyAdjourn.TabIndex = 1;
            this.txtKeyAdjourn.TextChanged += new System.EventHandler(this.txtKeyAdjourn_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Key: ";
            // 
            // dtgKey
            // 
            this.dtgKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKey.Location = new System.Drawing.Point(12, 142);
            this.dtgKey.Name = "dtgKey";
            this.dtgKey.Size = new System.Drawing.Size(810, 296);
            this.dtgKey.TabIndex = 2;
            this.dtgKey.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKey_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.panelAdjourn);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.pannelGen);
            this.Controls.Add(this.dtgKey);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelKey);
            this.Name = "Form1";
            this.Text = "License Management";
            this.panelKey.ResumeLayout(false);
            this.panelKey.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pannelGen.ResumeLayout(false);
            this.pannelGen.PerformLayout();
            this.panelReset.ResumeLayout(false);
            this.panelReset.PerformLayout();
            this.panelAdjourn.ResumeLayout(false);
            this.panelAdjourn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.TextBox txtExTime;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetKeyActived;
        private System.Windows.Forms.Button btnAdjourn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pannelGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Button btnResetKey;
        private System.Windows.Forms.TextBox txtKeyReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAdjourn;
        private System.Windows.Forms.TextBox txtNumDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeyAdjourn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPnAdjourn;
        private System.Windows.Forms.DataGridView dtgKey;
    }
}

