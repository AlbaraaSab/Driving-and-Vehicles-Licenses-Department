namespace DVLD.Users.Controls
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIsActive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblUserID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Info";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(525, 35);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(22, 13);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(350, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(22, 13);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName : ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(153, 35);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(22, 13);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID : ";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(6, 3);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(717, 273);
            this.ctrlPersonCard1.TabIndex = 3;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(736, 370);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label1;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
    }
}
