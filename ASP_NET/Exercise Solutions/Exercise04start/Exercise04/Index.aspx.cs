﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise04
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                Label1.Text = "Hello World, " + "Age:" + TextBox2.Text + ", whose name is " + TextBox1.Text + ".";
                Label2.Text = "";

            }
            else
            {
                Label1.Text = "Information is missing!";
            }
        }
        // JKE 1) Add event handler to button
        // JKE: Write out to first label if element is correctly set
        // JKE: Write out to second element if element is incorrectly set. this text shouldf be red (use CSS)
        //

    }
}