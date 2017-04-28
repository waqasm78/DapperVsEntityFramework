namespace DapperVsEntityFramework.EntityFramework
{
    partial class QueryEF
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
            this.uiQueryMultipleRecords = new System.Windows.Forms.Button();
            this.uiQuerySingleRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiQueryMultipleRecords
            // 
            this.uiQueryMultipleRecords.Location = new System.Drawing.Point(40, 80);
            this.uiQueryMultipleRecords.Name = "uiQueryMultipleRecords";
            this.uiQueryMultipleRecords.Size = new System.Drawing.Size(200, 30);
            this.uiQueryMultipleRecords.TabIndex = 3;
            this.uiQueryMultipleRecords.Text = "Query Multiple Records";
            this.uiQueryMultipleRecords.UseVisualStyleBackColor = true;
            this.uiQueryMultipleRecords.Click += new System.EventHandler(this.QueryMultipleRecords);
            // 
            // uiQuerySingleRecord
            // 
            this.uiQuerySingleRecord.Location = new System.Drawing.Point(40, 20);
            this.uiQuerySingleRecord.Name = "uiQuerySingleRecord";
            this.uiQuerySingleRecord.Size = new System.Drawing.Size(200, 30);
            this.uiQuerySingleRecord.TabIndex = 2;
            this.uiQuerySingleRecord.Text = "Query Single Record";
            this.uiQuerySingleRecord.UseVisualStyleBackColor = true;
            this.uiQuerySingleRecord.Click += new System.EventHandler(this.QuerySingleRecord);
            // 
            // QueryEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiQueryMultipleRecords);
            this.Controls.Add(this.uiQuerySingleRecord);
            this.Name = "QueryEF";
            this.Text = "Entity Framework - Query";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiQueryMultipleRecords;
        private System.Windows.Forms.Button uiQuerySingleRecord;
    }
}