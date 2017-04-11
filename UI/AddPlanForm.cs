using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;

namespace UI
{
    public partial class AddPlanForm : Form
    {
        private LoadGlobalChineseCharacters loadGlobalChineseCharacters;
        private PlanClassControl _planClassControl;
        private int planIndex;
        //private static string DATE_PATTERN = "yyyy-MM-dd";
        //private static int LENGTH_OF_LINE_PER_DAY = 5;
        private static int POINT_HEIGHT_BASE = 10;
        private static int CENTER_OFFSET = 20;
        private static string DATE_PATTERN = "yyyy-MM-dd";

        public AddPlanForm()
        {
            InitializeComponent();
        }

        public AddPlanForm(int planIndex, PlanClassControl _planClassControl)
        {
            InitializeComponent();
            loadGlobalChineseCharacters = LoadGlobalChineseCharacters.GetInstance();
            this._planClassControl = _planClassControl;
            this.planIndex = planIndex;
            initUI();
            
        }

        private void initUI()
        {
            timeLabel.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["time"];
            planLabel.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["plan"];
            okButton.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["ok"];
            cancelButton.Text = loadGlobalChineseCharacters.GlobalChineseCharactersDict["cancel"];
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!contentTextBox.Text.Equals(""))
            {
                string planDate = dateTimePicker.Text;
                string startPlanDate = _planClassControl.planClassControlInitParameter.startTime;
                string endPlanDate = _planClassControl.planClassControlInitParameter.endTime;

                DateTimeFormatInfo format = new System.Globalization.DateTimeFormatInfo();
                format.ShortDatePattern = DATE_PATTERN;
                DateTime planDateTime = Convert.ToDateTime(planDate, format);
                DateTime startPlanDateTime = Convert.ToDateTime(startPlanDate, format);
                DateTime endPlanDateTime = Convert.ToDateTime(endPlanDate, format);

                int compare1 = DateTime.Compare(planDateTime, endPlanDateTime);
                int compare2 = DateTime.Compare(planDateTime, startPlanDateTime);
                if (compare1 <= 0 && compare2 >= 0)
                {
                    Label planL = new Label();
                    planL.Text = dateTimePicker.Text + ":" + contentTextBox.Text;
                    int lengthOfLine = PlanClassControl.convertDateToLengthOfLine(planDate, _planClassControl.planClassControlInitParameter.endTime);
                    planL.Location = new Point(_planClassControl.pPictureBox.Width / 2 - CENTER_OFFSET, lengthOfLine + POINT_HEIGHT_BASE);
                    planL.ForeColor = NewPlanInitParameterForm.createRandomColor();
                    _planClassControl.pPictureBox.Controls.Add(planL);
                }
                else
                {
                    DialogResult dr1 = MessageBox.Show(loadGlobalChineseCharacters.GlobalChineseCharactersDict["exception2"], loadGlobalChineseCharacters.GlobalChineseCharactersDict["exception"]);
                }

                
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
