using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class Contents
    {
        private int _contentid;

        public int ContentId
        {
            get { return _contentid; }
            set { _contentid = value; }
        }

        private string _ContentName;

        public string ContentName
        {
            get { return _ContentName; }
            set { _ContentName = value; }
        }


    }
}
