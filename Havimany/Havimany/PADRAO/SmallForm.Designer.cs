namespace Havimany.PADRAO
{
    partial class SmallForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editorSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripPrincipal
            // 
            this.contextMenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorSQLToolStripMenuItem});
            this.contextMenuStripPrincipal.Name = "contextMenuStripPrincipal";
            this.contextMenuStripPrincipal.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStripPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ClickedItem);
            // 
            // editorSQLToolStripMenuItem
            // 
            this.editorSQLToolStripMenuItem.Name = "editorSQLToolStripMenuItem";
            this.editorSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorSQLToolStripMenuItem.Text = "Editor SQL";
            // 
            // SmallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 328);
            this.Name = "SmallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmallForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightClick);
            this.contextMenuStripPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem editorSQLToolStripMenuItem;
    }
}