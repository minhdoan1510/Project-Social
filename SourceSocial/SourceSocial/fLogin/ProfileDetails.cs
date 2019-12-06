using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace fLogin
{
    public partial class ProfileDetails : MaterialForm
    {
        public ProfileDetails()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
           skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Cyan500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.Indigo200, MaterialSkin.Accent.DeepOrange100, MaterialSkin.TextShade.BLACK);
           
        }

        private void ProfileDetails_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            
            pictureBox1.Region = new Region(path);
        }
    }
}
