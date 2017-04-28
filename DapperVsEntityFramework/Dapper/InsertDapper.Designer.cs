namespace DapperVsEntityFramework.Dapper
{
    partial class InsertDapper
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
            this.uiInsertMultipleRecords = new System.Windows.Forms.Button();
            this.uiInsertSingleRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiInsertMultipleRecords
            // 
            this.uiInsertMultipleRecords.Location = new System.Drawing.Point(40, 80);
            this.uiInsertMultipleRecords.Name = "uiInsertMultipleRecords";
            this.uiInsertMultipleRecords.Size = new System.Drawing.Size(200, 30);
            this.uiInsertMultipleRecords.TabIndex = 7;
            this.uiInsertMultipleRecords.Text = "Insert Multiple Records";
            this.uiInsertMultipleRecords.UseVisualStyleBackColor = true;
            this.uiInsertMultipleRecords.Click += new System.EventHandler(this.InsertMultipleRecords);
            // 
            // uiInsertSingleRecord
            // 
            this.uiInsertSingleRecord.Location = new System.Drawing.Point(40, 20);
            this.uiInsertSingleRecord.Name = "uiInsertSingleRecord";
            this.uiInsertSingleRecord.Size = new System.Drawing.Size(200, 30);
            this.uiInsertSingleRecord.TabIndex = 6;
            this.uiInsertSingleRecord.Text = "Insert Single Record";
            this.uiInsertSingleRecord.UseVisualStyleBackColor = true;
            this.uiInsertSingleRecord.Click += new System.EventHandler(this.InsertSingleRecord);
            // 
            // InsertDapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiInsertMultipleRecords);
            this.Controls.Add(this.uiInsertSingleRecord);
            this.Name = "InsertDapper";
            this.Text = "Dapper - Insert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiInsertMultipleRecords;
        private System.Windows.Forms.Button uiInsertSingleRecord;
    }
}