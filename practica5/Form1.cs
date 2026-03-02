using practica5.FolderforModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();

        List<Bikes> Motorbikes = DB.Bikes.ToList();
        int AccNumber = 0;

        private void Loading()
        {
            userControlName1.Fill(Motorbikes[AccNumber]);
            userControlName2.Fill(Motorbikes[AccNumber + 1]);

        }
        private void Loading(bool Incr)
        {
            if (Incr == true && Motorbikes.Count > AccNumber + 2)
                AccNumber++;
            else if (Incr == false && 0 <= AccNumber - 1)
                AccNumber--;
            else
                return;

            Loading();
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            Loading();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Loading(false);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Loading(true);
        }
    }
}
