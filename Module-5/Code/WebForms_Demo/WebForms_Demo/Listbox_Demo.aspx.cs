using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Demo
{
    public partial class Listbox_Demo : System.Web.UI.Page
    {
        #region Page_Load Event
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion Page_Load Event

        #region btnAdd click Event
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //check for empty textbox
            if (string.IsNullOrEmpty(txtCountryName.Text) || string.IsNullOrEmpty(txtCountryCode.Text))
            {
                lblResult.Text = ("Can not add empty value");
                txtCountryCode.Text = "";
                txtCountryName.Text = "";
            }
            //check for duplicate item in the listbox,if item found do not add to the list again
            //FindByValue is used for find an item from the list using item value
            else if (lbCountry.Items.FindByValue(txtCountryCode.Text.ToString().Trim().ToLower()) != null || lbCountry.Items.FindByText(txtCountryName.Text.ToString().Trim().ToLower()) != null)
            {
                lblResult.Text = ("Item is already available in the list");
                txtCountryCode.Text = "";
                txtCountryName.Text = "";

            }
            //Add Item to the list
            else
            {
                ListItem licountry = new ListItem();
                licountry.Text = txtCountryName.Text.ToString().Trim().ToLower();
                licountry.Value = txtCountryCode.Text.ToString().Trim().ToLower();
                //Add method is used to add item in the list 
                lbCountry.Items.Add(licountry);
                txtCountryCode.Text = "";
                txtCountryName.Text = "";
                lblResult.Text = ("Item Added successfully");
            }
        }
        #endregion btnAdd click Event

        #region btnRemove click Event
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            //Check for Empty textbox
            //IsNullOrEmpty() method is check wether given control have any value or not
            //here, .Text is property to set text to the textbox which is visible to the user's screen
            if (string.IsNullOrEmpty(txtCountryName.Text) || string.IsNullOrEmpty(txtCountryCode.Text))
            {
                lblResult.Text = ("Can not remove empty value");
                txtCountryCode.Text = "";
                txtCountryName.Text = "";
            }
            //check for specified item is available in the list or not
            //if item is available then remove it using Remove() method of listbox
            else if (lbCountry.Items.FindByValue(txtCountryCode.Text.ToString().Trim().ToLower()) != null && lbCountry.Items.FindByText(txtCountryName.Text.ToString().Trim().ToLower()) != null)
            {

                string itemValue = txtCountryCode.Text.ToString().Trim().ToLower();
                string itemText = txtCountryName.Text.ToString().Trim().ToLower();
                ListItem liRemove = new ListItem();
                liRemove.Text = itemText;
                liRemove.Value = itemValue;
                lblResult.Text = "Item Found and remove: " + itemText;
                lbCountry.Items.Remove(liRemove);
                txtCountryCode.Text = "";
                txtCountryName.Text = "";

            }
            //if specified item not found on the list this else part will get excuted
            else
            {
                //print not found item message on lable
                lblResult.Text = "Country Code or Country Name Can not found";
                txtCountryCode.Text = "";
                txtCountryName.Text = "";
            }
        }
        #endregion btnRemove click Event

        #region btnAllShiftRight click Event

        //this method will remove all the items from lbcountry list
        //and add all items of country list into lbmodifiedcountry list 
        protected void btnAllShiftRight_Click(object sender, EventArgs e)
        {
            //clear() method will clear the list completely
            foreach (ListItem limodified in lbCountry.Items)
            {
                ListItem liTransfer = new ListItem();
                liTransfer.Text = limodified.Text;
                liTransfer.Value = limodified.Text;
                lbModifiedCountry.Items.Add(liTransfer);
            }
            lbCountry.Items.Clear();
        }
        #endregion btnAllShiftRight click Event

        #region btnAllShiftLeft click Event
        //this method will remove all the items from lbmodifiedcountry list
        //and add all items of lbmodifiedcountry list into lbcountry list 
        protected void btnAllShiftLeft_Click(object sender, EventArgs e)
        {
            foreach (ListItem limodified in lbModifiedCountry.Items)
            {
                //clear() method will clear the list completely
                ListItem liTransfer = new ListItem();
                liTransfer.Text = limodified.Text;
                liTransfer.Value = limodified.Text;
                lbCountry.Items.Add(liTransfer);
            }
            lbModifiedCountry.Items.Clear();
        }

        #endregion btnAllShiftLeft click Event

        #region btnOneShiftRight click Event
        protected void btnOneShiftRight_Click(object sender, EventArgs e)
        {
            //creating one list named removedItems
            //this list stores the items that are romoved from lbcountry list
            List<ListItem> removedItems = new List<ListItem>();

            //check for any item in the list is selected or not
            //if selectedIndex returns -1 then any item of the list is not selected
            if (lbCountry.SelectedIndex == -1)
            {
                lblResult.Text = "Please select any item";
            }
            else
            {
                //Add selected items in lbModifiedCountry list
                //and add selected item in the removedItems list
                foreach (ListItem item in lbCountry.Items)
                {
                    if (item.Selected)
                    {
                        item.Selected = false;
                        lbModifiedCountry.Items.Add(item);
                        removedItems.Add(item);
                    }
                }

                //Remove the selected items from the list lbCountry
                foreach (ListItem item in removedItems)
                {
                    lbCountry.Items.Remove(item);
                }
            }
        }
        #endregion btnOneShiftRight click Event

        #region btnOneShiftLeft click Event 

        protected void btnOneShiftLeft_Click(object sender, EventArgs e)
        {
            //creating one list named removedItems
            //this list stores the items that are romoved from lbModifiedcountry list
            List<ListItem> removedItems = new List<ListItem>();

            //check for any item in the list is selected or not
            //if selectedIndex returns -1 then any item of the list is not selected
            if (lbModifiedCountry.SelectedIndex == -1)
            {
                lblResult.Text = "Please select any item";
            }
            else
            {
                //Add selected items in lbCountry list
                //and add selected item in the removedItems list
                foreach (ListItem item in lbModifiedCountry.Items)
                {
                    if (item.Selected)
                    {
                        item.Selected = false;
                        lbCountry.Items.Add(item);
                        removedItems.Add(item);
                    }
                }

                //Remove the selected items from the list lbModifiedCountry
                foreach (ListItem item in removedItems)
                {
                    lbModifiedCountry.Items.Remove(item);
                }
            }
        }
        #endregion btnOneShiftLeft click Event
    }
}