using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Abdoulch_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //This should only run once when the page is initially loaded in the browser
                lblFruits.Items.Add("Strawberry");
            }
        }

        protected void lblFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this code runs when the user selects a new item from the lbllFruits List Box
            // Copy the currently selected item from the list box into our label
            lblChosenFruit.Text = lblFruits.SelectedValue;
        }
        // I need an event that will run when the user, 
        // In their browser select a frit from the list box
        // "event-driven" programming.
        // Our event is the user selected an item from the list box

    }
}