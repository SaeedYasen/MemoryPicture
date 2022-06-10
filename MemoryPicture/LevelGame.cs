using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryPicture
{
    public partial class LevelGame : Form
    {

        int level;
        public LevelGame(int lvl)
        {
            level = lvl;
            IflEVEL();
            InitializeComponent();
        }

        private void IflEVEL()
        {
            levelll.Enabled = false;
        }

        private void LevelGame_Load(object sender, EventArgs e)
        {

        }
    }
}
