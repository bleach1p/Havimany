using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havimany.PADRAO
{
    public partial class SmallForm : Form
    {
        public SmallForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:
                    TECNOLOGIA.EditorSQL editor = new TECNOLOGIA.EditorSQL();
                    editor.ShowDialog();
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripPrincipal.Show(Cursor.Position);
            }

        }
        
        public void ClickedItem(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Editor SQL")
            {
                TECNOLOGIA.EditorSQL editor = new TECNOLOGIA.EditorSQL();
                editor.ShowDialog();
            }
        }
    }
}
