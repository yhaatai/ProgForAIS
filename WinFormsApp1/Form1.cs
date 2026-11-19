
using Core;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Logic myLogic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            myLogic.RemoveSims(id);
            textName.Clear();
            textAge.Clear();
            textSex.Clear();
            textId.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            int age = int.Parse(textAge.Text);
            string sex = textSex.Text;
            myLogic.AddSims(name, age, sex);
            textName.Clear();
            textAge.Clear();
            textSex.Clear();
            textId.Clear();
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            listSims.Items.Clear();
            foreach (var sim in myLogic.GetSims())
            {
                listSims.Items.Add(sim.ToString());
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textId.Text);
            String Nname = textName.Text;
            int Nage = int.Parse(textAge.Text);
            String Nsex = textSex.Text;
            myLogic.UpdateSim(id, Nname, Nage, Nsex);
            textName.Clear();
            textAge.Clear();
            textSex.Clear();
            textId.Clear();
        }

        private void buttonGetsex_Click(object sender, EventArgs e)
        {
            String sex = textSex.Text;
            listSims.Items.Clear();
            foreach (var sim in myLogic.GetSex(sex))
            {
                listSims.Items.Add(sim.ToString());
            }
        }

        private void buttonGetAdult_Click(object sender, EventArgs e)
        {
            listSims.Items.Clear();
            foreach (var sim in myLogic.GetAdult())
            {
                listSims.Items.Add(sim.ToString());
            }
        }




        // мусор
        private void textId_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
