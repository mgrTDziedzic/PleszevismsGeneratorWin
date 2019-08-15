using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;

namespace PleszevismsGeneratorWin
{
    public partial class Form1 : Form
    {

        Pleszevism pleszevism;
        PleszevismHandler pleszevismHandler;

        public Form1()
        {
            InitializeComponent();

            pleszevismHandler = new PleszevismHandler();

            string PleszevismFile = Path.GetFullPath("Pleszevism.xml");
            if (File.Exists(PleszevismFile))
            {
                pleszevism = pleszevismHandler.LoadFromFile(PleszevismFile);
            }
            else
            {
                MessageBox.Show("Nie odnaleziono bazy pleszewizmów. Wybierz plik ręcznie.");
            }

            UpdateControls();
        }

        private void everydayButton_Click(object sender, EventArgs e)
        {
            everydayTextBox.Text = pleszevism.GenerateSingle();
        }

        private void felietonButton_Click(object sender, EventArgs e)
        {
            felietonTextBox.Text = pleszevism.GeneratePleszeton((int)felietonLength.Value, uniqueCheckBox.Checked);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki pleszewizmów (*.xml)|*.xml";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pleszevism = pleszevismHandler.LoadFromFile(openFileDialog.FileName);
            }

            if (pleszevism == null)
            {
                MessageBox.Show("Nie udało się wczytać bazy pleszewizmów. Upewnij się, że wybrałeś poprawny plik");
            }
            UpdateControls();
        }

        private void UpdateControls()
        {
            if (pleszevism == null)
            {
                everydayButton.Enabled = false;
                felietonButton.Enabled = false;
            }
            else
            {
                everydayButton.Enabled = true;
                felietonButton.Enabled = true;
            }
        }
    }
}
