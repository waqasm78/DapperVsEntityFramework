namespace DapperVsEntityFramework.Dapper
{
    partial class UpdateDapper
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
            this.uiUpdateMultipleRecords = new System.Windows.Forms.Button();
            this.uiUpdateSingleRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiUpdateMultipleRecords
            // 
            this.uiUpdateMultipleRecords.Location = new System.Drawing.Point(40, 80);
            this.uiUpdateMultipleRecords.Name = "uiUpdateMultipleRecords";
            this.uiUpdateMultipleRecords.Size = new System.Drawing.Size(200, 30);
            this.uiUpdateMultipleRecords.TabIndex = 3;
            this.uiUpdateMultipleRecords.Text = "Update Multiple Records";
            this.uiUpdateMultipleRecords.UseVisualStyleBackColor = true;
            this.uiUpdateMultipleRecords.Click += new System.EventHandler(this.UpdateMultipleRecords);
            // 
            // uiUpdateSingleRecord
            // 
            this.uiUpdateSingleRecord.Location = new System.Drawing.Point(40, 20);
            this.uiUpdateSingleRecord.Name = "uiUpdateSingleRecord";
            this.uiUpdateSingleRecord.Size = new System.Drawing.Size(200, 30);
            this.uiUpdateSingleRecord.TabIndex = 2;
            this.uiUpdateSingleRecord.Text = "Update Single Record";
            this.uiUpdateSingleRecord.UseVisualStyleBackColor = true;
            this.uiUpdateSingleRecord.Click += new System.EventHandler(this.UpdateSingleRecord);
            // 
            // UpdateDapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiUpdateMultipleRecords);
            this.Controls.Add(this.uiUpdateSingleRecord);
            this.Name = "UpdateDapper";
            this.Text = "Dapper - Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiUpdateMultipleRecords;
        private System.Windows.Forms.Button uiUpdateSingleRecord;
    }
}