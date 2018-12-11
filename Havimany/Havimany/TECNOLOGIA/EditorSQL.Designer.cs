namespace Havimany.TECNOLOGIA
{
    partial class EditorSQL
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
            this.textSQL = new System.Windows.Forms.RichTextBox();
            this.gridSQL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // textSQL
            // 
            this.textSQL.Location = new System.Drawing.Point(1, 0);
            this.textSQL.Name = "textSQL";
            this.textSQL.Size = new System.Drawing.Size(923, 147);
            this.textSQL.TabIndex = 0;
            this.textSQL.Text = "";
            this.textSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSQL_KeyDown);
            // 
            // gridSQL
            // 
            this.gridSQL.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSQL.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridSQL.Location = new System.Drawing.Point(12, 153);
            this.gridSQL.Name = "gridSQL";
            this.gridSQL.Size = new System.Drawing.Size(897, 163);
            this.gridSQL.TabIndex = 1;
            this.gridSQL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RClick);
            // 
            // EditorSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 319);
            this.Controls.Add(this.gridSQL);
            this.Controls.Add(this.textSQL);
            this.Name = "EditorSQL";
            this.Text = "EditorSQL";
            ((System.ComponentModel.ISupportInitialize)(this.gridSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textSQL;
        private System.Windows.Forms.DataGridView gridSQL;
    }
}