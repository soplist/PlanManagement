using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool;
using System.Globalization;

namespace UI
{
    public partial class PlanClassControl : UserControl
    {
        private static string DATE_PATTERN = "yyyy-MM-dd";
        private static int LENGTH_OF_LINE_PER_DAY = 5;
        private static int LINE_WIDTH = 5;
        private static int PICTURE_BOX_HEIGHT_BASE = 50;
        private static int POINT_HEIGHT_BASE = 10;
        private static int TITLE_LABEL_TOP = 5;
        private static int CENTER_OFFSET = 30;
        private int lengthOfLine;
        private Color color;
        private int planIndex;
        private List<Plan> _plans;
        private PictureBox _planPictureBox;
        private PlanClassControlInitParameter _planClassControlInitParameter;

        public PlanClassControl()
        {
            InitializeComponent();
        }

        public PlanClassControl(int planIndex,PlanClassControlInitParameter planClassControlInitParameter)
        {
            InitializeComponent();
            initControl(planClassControlInitParameter);
            this._planClassControlInitParameter = planClassControlInitParameter;
            this.planIndex = planIndex;
            this.plans = new List<Plan>();
            _planPictureBox = planPictureBox;
        }

        private void initControl(PlanClassControlInitParameter planClassControlInitParameter)
        {
            planPanel.AutoScroll = true;
            planPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            lengthOfLine = convertDateToLengthOfLine(planClassControlInitParameter.startTime, planClassControlInitParameter.endTime);
            planPictureBox.Height = PICTURE_BOX_HEIGHT_BASE + lengthOfLine;
            color = planClassControlInitParameter.color;
            drawTimeMainAxis();
            titleLabel.Text = planClassControlInitParameter.title;
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, TITLE_LABEL_TOP);
            titleLabel.ForeColor = NewPlanInitParameterForm.createRandomColor();
        }

        private void drawTimeMainAxis()
        {
            Bitmap bitmap = new Bitmap(this.planPictureBox.Width, this.planPictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            planPictureBox.Image = bitmap;

            Pen pen = new Pen(color, LINE_WIDTH);
            Point startPoint = new Point(planPictureBox.Width / 2 - CENTER_OFFSET, POINT_HEIGHT_BASE);
            Point endPoint = new Point(planPictureBox.Width / 2 - CENTER_OFFSET, POINT_HEIGHT_BASE + lengthOfLine);
            graphics.DrawLine(pen, startPoint, endPoint);
        }

        public static int convertDateToLengthOfLine(string startTimeString, string endTimeString)
        {
            DateTimeFormatInfo format = new System.Globalization.DateTimeFormatInfo();
            format.ShortDatePattern = DATE_PATTERN;

            DateTime startTime = Convert.ToDateTime(startTimeString, format);
            DateTime endTime = Convert.ToDateTime(endTimeString, format);

            int intervalDays = ((TimeSpan)(endTime - startTime)).Days;

            return intervalDays * LENGTH_OF_LINE_PER_DAY;
        }

        public List<Plan> plans
        {
            set { _plans = value; }
            get { return _plans; }
        }

        public PictureBox pPictureBox
        {
            set { _planPictureBox = value; }
            get { return _planPictureBox; }
        }

        public PlanClassControlInitParameter planClassControlInitParameter
        {
            set { _planClassControlInitParameter = value; }
            get { return _planClassControlInitParameter; }
        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            AddPlanForm addPlanForm = new AddPlanForm(planIndex,this);
            addPlanForm.Show();
        }

    }
}
