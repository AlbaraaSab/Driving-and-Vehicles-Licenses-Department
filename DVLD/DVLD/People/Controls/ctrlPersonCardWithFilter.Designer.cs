namespace DVLD.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindPerson = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD.People.Controls.ctrlPersonCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.btnFindPerson);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Controls.Add(this.cbFilterSelection);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(3, 15);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(503, 72);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.ImageOptions.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.btnAddPerson.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddPerson.Location = new System.Drawing.Point(435, 22);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddPerson.Size = new System.Drawing.Size(47, 34);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.ImageOptions.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btnFindPerson.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindPerson.Location = new System.Drawing.Point(382, 22);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindPerson.Size = new System.Drawing.Size(47, 34);
            this.btnFindPerson.TabIndex = 4;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(230, 32);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(119, 20);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // cbFilterSelection
            // 
            this.cbFilterSelection.FormattingEnabled = true;
            this.cbFilterSelection.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.cbFilterSelection.Location = new System.Drawing.Point(83, 32);
            this.cbFilterSelection.Name = "cbFilterSelection";
            this.cbFilterSelection.Size = new System.Drawing.Size(141, 21);
            this.cbFilterSelection.TabIndex = 1;
            this.cbFilterSelection.SelectedIndexChanged += new System.EventHandler(this.cbFilterSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(4, 88);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(723, 254);
            this.ctrlPersonCard1.TabIndex = 2;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(730, 346);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterSelection;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnFindPerson;
        private DevExpress.XtraEditors.SimpleButton btnAddPerson;
        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
