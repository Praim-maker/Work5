using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using practica5.FolderforModel;

namespace practica5.FolderforModel
{
    public partial class UserControlName : UserControl
    {
        public UserControlName()
        {
            InitializeComponent();
        }

        public void Fill(Bikes Motorbike)
        {
            labelIDData.Text = Motorbike.ID.ToString();
            labelModelData.Text = Motorbike.Model;
            labelBrandData.Text = Motorbike.Brand;
            labelPriceData.Text = Motorbike.Price.ToString();
            labelHorsepowerData.Text = Motorbike.Horsepower.ToString();
            labelMileageData.Text = Motorbike.Mileage.ToString();
            pictureBoxMotorbike.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");


        }

        private void UserControlName_Load(object sender, EventArgs e)
        {

        }
    }
}
