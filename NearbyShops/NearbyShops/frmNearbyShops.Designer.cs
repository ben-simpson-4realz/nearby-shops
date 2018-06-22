namespace NearbyShops {
    partial class FrmNearbyShops {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chkSingle = new System.Windows.Forms.CheckBox();
            this.lblSingle = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.lblLng = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnRunCalculation = new System.Windows.Forms.Button();
            this.lblFindShopsHeading = new System.Windows.Forms.Label();
            this.rdoFind = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoUpdate = new System.Windows.Forms.RadioButton();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.gbFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSingle
            // 
            this.chkSingle.AutoSize = true;
            this.chkSingle.Location = new System.Drawing.Point(15, 218);
            this.chkSingle.Name = "chkSingle";
            this.chkSingle.Size = new System.Drawing.Size(133, 17);
            this.chkSingle.TabIndex = 15;
            this.chkSingle.Text = "Yes, only show closest";
            this.chkSingle.UseVisualStyleBackColor = true;
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Location = new System.Drawing.Point(12, 202);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(65, 13);
            this.lblSingle.TabIndex = 14;
            this.lblSingle.Text = "Closest Only";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 163);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(91, 13);
            this.lblRadius.TabIndex = 10;
            this.lblRadius.Text = "Radius (in meters)";
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(15, 179);
            this.numRadius.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(133, 20);
            this.numRadius.TabIndex = 11;
            this.numRadius.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(15, 140);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(133, 20);
            this.txtLng.TabIndex = 7;
            this.txtLng.Text = "-75.7230555";
            // 
            // lblLng
            // 
            this.lblLng.AutoSize = true;
            this.lblLng.Location = new System.Drawing.Point(12, 124);
            this.lblLng.Name = "lblLng";
            this.lblLng.Size = new System.Drawing.Size(54, 13);
            this.lblLng.TabIndex = 6;
            this.lblLng.Text = "Longitude";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(15, 101);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(133, 20);
            this.txtLat.TabIndex = 5;
            this.txtLat.Text = "45.3776091";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(12, 85);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(45, 13);
            this.lblLat.TabIndex = 4;
            this.lblLat.Text = "Latitude";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(15, 61);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(133, 21);
            this.cboCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(154, 61);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(632, 203);
            this.dgvResults.TabIndex = 22;
            this.dgvResults.Visible = false;
            this.dgvResults.SelectionChanged += new System.EventHandler(this.dgvResults_SelectionChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(156, 34);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 22;
            this.lblResults.Text = "Results";
            // 
            // btnRunCalculation
            // 
            this.btnRunCalculation.Location = new System.Drawing.Point(15, 241);
            this.btnRunCalculation.Name = "btnRunCalculation";
            this.btnRunCalculation.Size = new System.Drawing.Size(133, 23);
            this.btnRunCalculation.TabIndex = 16;
            this.btnRunCalculation.Text = "Find";
            this.btnRunCalculation.UseVisualStyleBackColor = true;
            this.btnRunCalculation.Click += new System.EventHandler(this.btnRunCalculation_Click);
            // 
            // lblFindShopsHeading
            // 
            this.lblFindShopsHeading.AutoSize = true;
            this.lblFindShopsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindShopsHeading.Location = new System.Drawing.Point(11, 9);
            this.lblFindShopsHeading.Name = "lblFindShopsHeading";
            this.lblFindShopsHeading.Size = new System.Drawing.Size(117, 20);
            this.lblFindShopsHeading.TabIndex = 0;
            this.lblFindShopsHeading.Text = "Manage Shops";
            // 
            // rdoFind
            // 
            this.rdoFind.AutoSize = true;
            this.rdoFind.Checked = true;
            this.rdoFind.Location = new System.Drawing.Point(6, 19);
            this.rdoFind.Name = "rdoFind";
            this.rdoFind.Size = new System.Drawing.Size(45, 17);
            this.rdoFind.TabIndex = 18;
            this.rdoFind.TabStop = true;
            this.rdoFind.Text = "Find";
            this.rdoFind.UseVisualStyleBackColor = true;
            this.rdoFind.CheckedChanged += new System.EventHandler(this.rdoFind_CheckedChanged);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(57, 19);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(44, 17);
            this.rdoAdd.TabIndex = 19;
            this.rdoAdd.Text = "Add";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.rdoAdd_CheckedChanged);
            // 
            // rdoUpdate
            // 
            this.rdoUpdate.AutoSize = true;
            this.rdoUpdate.Enabled = false;
            this.rdoUpdate.Location = new System.Drawing.Point(107, 19);
            this.rdoUpdate.Name = "rdoUpdate";
            this.rdoUpdate.Size = new System.Drawing.Size(60, 17);
            this.rdoUpdate.TabIndex = 20;
            this.rdoUpdate.Text = "Update";
            this.rdoUpdate.UseVisualStyleBackColor = true;
            this.rdoUpdate.CheckedChanged += new System.EventHandler(this.rdoUpdate_CheckedChanged);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Enabled = false;
            this.rdoDelete.Location = new System.Drawing.Point(173, 19);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(56, 17);
            this.rdoDelete.TabIndex = 21;
            this.rdoDelete.Text = "Delete";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.CheckedChanged += new System.EventHandler(this.rdoDelete_CheckedChanged);
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.rdoFind);
            this.gbFunction.Controls.Add(this.rdoDelete);
            this.gbFunction.Controls.Add(this.rdoAdd);
            this.gbFunction.Controls.Add(this.rdoUpdate);
            this.gbFunction.Location = new System.Drawing.Point(154, 9);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Size = new System.Drawing.Size(232, 46);
            this.gbFunction.TabIndex = 17;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Function";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(15, 62);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(133, 20);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 218);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(133, 20);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 163);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            this.lblLocation.Visible = false;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(15, 179);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(133, 20);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Visible = false;
            // 
            // FrmNearbyShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.gbFunction);
            this.Controls.Add(this.lblFindShopsHeading);
            this.Controls.Add(this.btnRunCalculation);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.chkSingle);
            this.Controls.Add(this.lblSingle);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.numRadius);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.lblLng);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Name = "FrmNearbyShops";
            this.Text = "Find Nearby Shops";
            this.Load += new System.EventHandler(this.FrmNearbyShops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.gbFunction.ResumeLayout(false);
            this.gbFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSingle;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown numRadius;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Label lblLng;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnRunCalculation;
        private System.Windows.Forms.Label lblFindShopsHeading;
        private System.Windows.Forms.RadioButton rdoFind;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoUpdate;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
    }
}

