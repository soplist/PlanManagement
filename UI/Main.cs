using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;

namespace UI
{
    public partial class Main : Form
    {
        private LoadGlobalChineseCharacters loadGlobalChineseCharacters;
        private Panel _panel;
        public Main()
        {
            InitializeComponent();
            loadGlobalChineseCharacters = LoadGlobalChineseCharacters.GetInstance();
            initUI();
            this._panel = plansPanel;
        }

        private void initUI()
        {
            plansPanel.AutoScroll = true;
            addPlanButton.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["addNewPlan"];
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            NewPlanInitParameterForm newPlanInitParameterForm = new NewPlanInitParameterForm(this);
            newPlanInitParameterForm.Show();
        }

        public Panel panel
        {
            set { _panel = value; }
            get { return _panel; }
        }
    }
}
