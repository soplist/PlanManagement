using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    public class Plan
    {
        private DateTime _time;
        private string _content;

        public DateTime time
        {
            set { _time = value; }
            get { return _time; }
        }

        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
    }
}
