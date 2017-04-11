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
    public partial class NewPlanInitParameterForm : Form
    {
        private LoadGlobalChineseCharacters loadGlobalChineseCharacters;
        private Main main;

        public NewPlanInitParameterForm(Main main)
        {
            InitializeComponent();
            this.main = main;
            loadGlobalChineseCharacters = LoadGlobalChineseCharacters.GetInstance();
            initUI();
            
        }

        private void initUI()
        {
            planTitleLabel.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["planName"];
            startDatelabel.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["planStartDate"];
            endDateLabel.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["planEndDate"];
            okButton.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["ok"];
            cancelButton.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["cancel"]; 
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "yyyy-MM-dd";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "yyyy-MM-dd";
                
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = planNameTextBox.Text.Trim();
            if (name.Equals(""))
            {
                DialogResult dr1 = MessageBox.Show(loadGlobalChineseCharacters.GlobalChineseCharactersDict["exception1"], loadGlobalChineseCharacters.GlobalChineseCharactersDict["exception"]);
                return;
            }
            else
            {
                string startDate = startDateTimePicker.Text.Trim();
                string endDate = endDateTimePicker.Text.Trim();

                createNewPlanClassControl(name, startDate, endDate);
            }
            
        }

        private void createNewPlanClassControl(string planName,string startDate, string endDate)
        {
            Color color = createRandomColor();
            PlanClassControlInitParameter planClassControlInitParameter = new PlanClassControlInitParameter(planName, startDate, endDate, color);
            PlanClassControl planClassControl = new PlanClassControl(main.panel.Controls.Count+1,planClassControlInitParameter);
            planClassControl.Location = new Point(main.panel.Controls.Count * planClassControl.Width, 0);
            main.panel.Controls.Add(planClassControl);
        }

        public static Color createRandomColor()
        {
            Random randomNum_1 = new Random(Guid.NewGuid().GetHashCode());
            System.Threading.Thread.Sleep(randomNum_1.Next(1));
            int int_Red = randomNum_1.Next(255);

            Random randomNum_2 = new Random((int)DateTime.Now.Ticks);
            int int_Green = randomNum_2.Next(255);

            Random randomNum_3 = new Random(Guid.NewGuid().GetHashCode());

            int int_Blue = randomNum_3.Next(255);
            int_Blue = (int_Red + int_Green > 380) ? int_Red + int_Green - 380 : int_Blue;
            int_Blue = (int_Blue > 255) ? 255 : int_Blue;

            return GetDarkerColor(System.Drawing.Color.FromArgb(int_Red, int_Green, int_Blue));
        }

        public static Color GetDarkerColor(Color color)
        {
            const int max = 255;
            int increase = new Random(Guid.NewGuid().GetHashCode()).Next(30, 255);

            int r = Math.Abs(Math.Min(color.R - increase, max));
            int g = Math.Abs(Math.Min(color.G - increase, max));
            int b = Math.Abs(Math.Min(color.B - increase, max));

            return Color.FromArgb(r, g, b);
        }
    }
}
