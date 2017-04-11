using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    public class PlanClassControlInitParameter
    {
        private string _title;
        private string _startTime;
        private string _endTime;
        private Color _color;

        public PlanClassControlInitParameter(string _title, string _startTime, string _endTime, Color _color)
        {
            this._title = _title;
            this._startTime = _startTime;
            this._endTime = _endTime;
            this._color = _color;
        }

        public string title
        {
            set { _title = value; }
            get { return _title; }
        }

        public string startTime
        {
            set { _startTime = value; }
            get { return _startTime; }
        }

        public string endTime
        {
            set { _endTime = value; }
            get { return _endTime; }
        }

        public Color color
        {
            set { _color = value; }
            get { return _color; }
        }
    }
}
