﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveCoody.entity
{
    public class CoodyConfig
    {
        private List<String[]> headerListviews;

        public List<String[]> HeaderListviews
        {
            get { return headerListviews; }
            set { headerListviews = value; }
        }

        private String timeOut;

        public String TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }

        private String threadNum;

        public String ThreadNum
        {
            get { return threadNum; }
            set { threadNum = value; }
        }

        private List<String[]> expListViews;

        public List<String[]> ExpListViews
        {
            get { return expListViews; }
            set { expListViews = value; }
        }
    }
}
