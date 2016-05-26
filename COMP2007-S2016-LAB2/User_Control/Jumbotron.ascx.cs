﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_S2016_LAB2.User_Control
{
    [ParseChildren(false)]
    [PersistChildren(true)]
    public partial class Jumbotron : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            JumbotronH1.InnerText = "Welcome to my Website";
        }
    }
}