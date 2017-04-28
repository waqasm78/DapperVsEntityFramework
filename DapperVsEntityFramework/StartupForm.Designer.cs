namespace DapperVsEntityFramework
{
    partial class StartupForm
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
            this.groupDapper = new System.Windows.Forms.GroupBox();
            this.groupEF = new System.Windows.Forms.GroupBox();
            this.uiInsertEF = new System.Windows.Forms.Button();
            this.uiInsertDapper = new System.Windows.Forms.Button();
            this.uiUpdateEF = new System.Windows.Forms.Button();
            this.uiUpdateDapper = new System.Windows.Forms.Button();
            this.uiQueryDapper = new System.Windows.Forms.Button();
            this.uiDeleteDapper = new System.Windows.Forms.Button();
            this.uiQueryEF = new System.Windows.Forms.Button();
            this.uiDeleteEF = new System.Windows.Forms.Button();
            this.groupDapper.SuspendLayout();
            this.groupEF.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDapper
            // 
            this.groupDapper.Controls.Add(this.uiDeleteDapper);
            this.groupDapper.Controls.Add(this.uiQueryDapper);
            this.groupDapper.Controls.Add(this.uiUpdateDapper);
            this.groupDapper.Controls.Add(this.uiInsertDapper);
            this.groupDapper.Location = new System.Drawing.Point(30, 28);
            this.groupDapper.Name = "groupDapper";
            this.groupDapper.Size = new System.Drawing.Size(200, 250);
            this.groupDapper.TabIndex = 0;
            this.groupDapper.TabStop = false;
            this.groupDapper.Text = "Dapper";
            // 
            // groupEF
            // 
            this.groupEF.Controls.Add(this.uiDeleteEF);
            this.groupEF.Controls.Add(this.uiQueryEF);
            this.groupEF.Controls.Add(this.uiUpdateEF);
            this.groupEF.Controls.Add(this.uiInsertEF);
            this.groupEF.Location = new System.Drawing.Point(290, 28);
            this.groupEF.Name = "groupEF";
            this.groupEF.Size = new System.Drawing.Size(200, 250);
            this.groupEF.TabIndex = 1;
            this.groupEF.TabStop = false;
            this.groupEF.Text = "Entity Framework";
            // 
            // uiInsertEF
            // 
            this.uiInsertEF.Location = new System.Drawing.Point(19, 36);
            this.uiInsertEF.Name = "uiInsertEF";
            this.uiInsertEF.Size = new System.Drawing.Size(165, 27);
            this.uiInsertEF.TabIndex = 0;
            this.uiInsertEF.Text = "Insert";
            this.uiInsertEF.UseVisualStyleBackColor = true;
            this.uiInsertEF.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiInsertDapper
            // 
            this.uiInsertDapper.Location = new System.Drawing.Point(16, 36);
            this.uiInsertDapper.Name = "uiInsertDapper";
            this.uiInsertDapper.Size = new System.Drawing.Size(165, 27);
            this.uiInsertDapper.TabIndex = 1;
            this.uiInsertDapper.Text = "Insert";
            this.uiInsertDapper.UseVisualStyleBackColor = true;
            this.uiInsertDapper.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiUpdateEF
            // 
            this.uiUpdateEF.Location = new System.Drawing.Point(19, 91);
            this.uiUpdateEF.Name = "uiUpdateEF";
            this.uiUpdateEF.Size = new System.Drawing.Size(165, 27);
            this.uiUpdateEF.TabIndex = 1;
            this.uiUpdateEF.Text = "Update";
            this.uiUpdateEF.UseVisualStyleBackColor = true;
            this.uiUpdateEF.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiUpdateDapper
            // 
            this.uiUpdateDapper.Location = new System.Drawing.Point(16, 91);
            this.uiUpdateDapper.Name = "uiUpdateDapper";
            this.uiUpdateDapper.Size = new System.Drawing.Size(165, 27);
            this.uiUpdateDapper.TabIndex = 2;
            this.uiUpdateDapper.Text = "Update";
            this.uiUpdateDapper.UseVisualStyleBackColor = true;
            this.uiUpdateDapper.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiQueryDapper
            // 
            this.uiQueryDapper.Location = new System.Drawing.Point(16, 146);
            this.uiQueryDapper.Name = "uiQueryDapper";
            this.uiQueryDapper.Size = new System.Drawing.Size(165, 27);
            this.uiQueryDapper.TabIndex = 3;
            this.uiQueryDapper.Text = "Query";
            this.uiQueryDapper.UseVisualStyleBackColor = true;
            this.uiQueryDapper.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiDeleteDapper
            // 
            this.uiDeleteDapper.Location = new System.Drawing.Point(16, 201);
            this.uiDeleteDapper.Name = "uiDeleteDapper";
            this.uiDeleteDapper.Size = new System.Drawing.Size(165, 27);
            this.uiDeleteDapper.TabIndex = 4;
            this.uiDeleteDapper.Text = "Delete";
            this.uiDeleteDapper.UseVisualStyleBackColor = true;
            this.uiDeleteDapper.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiQueryEF
            // 
            this.uiQueryEF.Location = new System.Drawing.Point(19, 146);
            this.uiQueryEF.Name = "uiQueryEF";
            this.uiQueryEF.Size = new System.Drawing.Size(165, 27);
            this.uiQueryEF.TabIndex = 2;
            this.uiQueryEF.Text = "Query";
            this.uiQueryEF.UseVisualStyleBackColor = true;
            this.uiQueryEF.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // uiDeleteEF
            // 
            this.uiDeleteEF.Location = new System.Drawing.Point(19, 201);
            this.uiDeleteEF.Name = "uiDeleteEF";
            this.uiDeleteEF.Size = new System.Drawing.Size(165, 27);
            this.uiDeleteEF.TabIndex = 3;
            this.uiDeleteEF.Text = "Delete";
            this.uiDeleteEF.UseVisualStyleBackColor = true;
            this.uiDeleteEF.Click += new System.EventHandler(this.ShowExample_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 319);
            this.Controls.Add(this.groupEF);
            this.Controls.Add(this.groupDapper);
            this.Name = "StartupForm";
            this.Text = "Dapper vs Entity Framework";
            this.groupDapper.ResumeLayout(false);
            this.groupEF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDapper;
        private System.Windows.Forms.GroupBox groupEF;
        private System.Windows.Forms.Button uiInsertEF;
        private System.Windows.Forms.Button uiDeleteDapper;
        private System.Windows.Forms.Button uiQueryDapper;
        private System.Windows.Forms.Button uiUpdateDapper;
        private System.Windows.Forms.Button uiInsertDapper;
        private System.Windows.Forms.Button uiDeleteEF;
        private System.Windows.Forms.Button uiQueryEF;
        private System.Windows.Forms.Button uiUpdateEF;
    }
}

