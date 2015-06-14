﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class CreateEventService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyMasterPage master = Master as MyMasterPage;
        HtmlGenericControl controlFromMaster = master.ContentCSS as HtmlGenericControl;
        controlFromMaster.Style.Add("background-image", "url('Images/bg-01.jpg')");
        controlFromMaster.Style.Add("background-size", "cover");
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddServiceComplete.aspx");
    }
}