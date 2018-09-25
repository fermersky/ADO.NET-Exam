using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Exam
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Blue700, TextShade.WHITE);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
