namespace StrategyPatternHW
{
    partial class TicketForm
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
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.comboChildren = new System.Windows.Forms.ComboBox();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTicketType = new System.Windows.Forms.ComboBox();
            this.txtTicketCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIsVIP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboStudent
            // 
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(34, 55);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(229, 20);
            this.comboStudent.TabIndex = 0;
            // 
            // comboChildren
            // 
            this.comboChildren.FormattingEnabled = true;
            this.comboChildren.Location = new System.Drawing.Point(319, 55);
            this.comboChildren.Name = "comboChildren";
            this.comboChildren.Size = new System.Drawing.Size(247, 20);
            this.comboChildren.TabIndex = 1;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(431, 97);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(135, 49);
            this.btnAddList.TabIndex = 4;
            this.btnAddList.Text = "加入清單";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(34, 180);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.Size = new System.Drawing.Size(532, 118);
            this.txtDetail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "學生票折扣方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(319, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "屁孩票折扣方式";
            // 
            // comboTicketType
            // 
            this.comboTicketType.FormattingEnabled = true;
            this.comboTicketType.Location = new System.Drawing.Point(34, 126);
            this.comboTicketType.Name = "comboTicketType";
            this.comboTicketType.Size = new System.Drawing.Size(152, 20);
            this.comboTicketType.TabIndex = 2;
            // 
            // txtTicketCount
            // 
            this.txtTicketCount.Location = new System.Drawing.Point(295, 98);
            this.txtTicketCount.Name = "txtTicketCount";
            this.txtTicketCount.Size = new System.Drawing.Size(100, 22);
            this.txtTicketCount.TabIndex = 3;
            this.txtTicketCount.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(34, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "票種";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(236, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "張數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(236, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "花旗卡";
            // 
            // chkIsVIP
            // 
            this.chkIsVIP.AutoSize = true;
            this.chkIsVIP.Location = new System.Drawing.Point(295, 129);
            this.chkIsVIP.Name = "chkIsVIP";
            this.chkIsVIP.Size = new System.Drawing.Size(15, 14);
            this.chkIsVIP.TabIndex = 11;
            this.chkIsVIP.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(600, 310);
            this.Controls.Add(this.chkIsVIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.txtTicketCount);
            this.Controls.Add(this.comboTicketType);
            this.Controls.Add(this.comboChildren);
            this.Controls.Add(this.comboStudent);
            this.Name = "TicketForm";
            this.Text = "過期票";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStudent;
        private System.Windows.Forms.ComboBox comboChildren;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTicketType;
        private System.Windows.Forms.TextBox txtTicketCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsVIP;
    }
}