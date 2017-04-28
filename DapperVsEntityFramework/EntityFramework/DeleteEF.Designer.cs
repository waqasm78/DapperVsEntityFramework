namespace DapperVsEntityFramework.EntityFramework
{
    partial class DeleteEF
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
            this.uiDeleteMultipleRecords = new System.Windows.Forms.Button();
            this.uiDeleteSingleRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiDeleteMultipleRecords
            // 
            this.uiDeleteMultipleRecords.Location = new System.Drawing.Point(40, 80);
            this.uiDeleteMultipleRecords.Name = "uiDeleteMultipleRecords";
            this.uiDeleteMultipleRecords.Size = new System.Drawing.Size(200, 30);
            this.uiDeleteMultipleRecords.TabIndex = 7;
            this.uiDeleteMultipleRecords.Text = "Delete Multiple Records";
            this.uiDeleteMultipleRecords.UseVisualStyleBackColor = true;
            this.uiDeleteMultipleRecords.Click += new System.EventHandler(this.DeleteMultipleRecords);
            // 
            // uiDeleteSingleRecord
            // 
            this.uiDeleteSingleRecord.Location = new System.Drawing.Point(40, 20);
            this.uiDeleteSingleRecord.Name = "uiDeleteSingleRecord";
            this.uiDeleteSingleRecord.Size = new System.Drawing.Size(200, 30);
            this.uiDeleteSingleRecord.TabIndex = 6;
            this.uiDeleteSingleRecord.Text = "Delete Single Record";
            this.uiDeleteSingleRecord.UseVisualStyleBackColor = true;
            this.uiDeleteSingleRecord.Click += new System.EventHandler(this.DeleteSingleRecord);
            // 
            // DeleteEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiDeleteMultipleRecords);
            this.Controls.Add(this.uiDeleteSingleRecord);
            this.Name = "DeleteEF";
            this.Text = "Entity Framework - Delete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiDeleteMultipleRecords;
        private System.Windows.Forms.Button uiDeleteSingleRecord;
    }
}