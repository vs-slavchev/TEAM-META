﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using CommonClasses;

namespace CampEntranceApp
{
    public partial class Form1 : MaterialForm
    {

        private DBConnection connection;
        private StatusPanelController statusController;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = SkinColors.GetDefaultColor();

            connection = new DBConnection();
            statusController = new StatusPanelController(connection);

            statusController.RetrieveQRData = retrieveQRdata;
            statusController.SearchLastName = tbSearchLastname;
            statusController.SearchByLastNameButton = searchByLastName;
            statusController.Email = lbEmail;
            statusController.PhoneNumber = lbPhoneNumber;
            statusController.Money = lbMoney;
            statusController.HasEntered = lbHasEntered;
            statusController.HasLeft = lbHasLeft;
            statusController.MoneySpentOnFood = lbMoneySpentFood;
            statusController.TotalMoney = lbMoneyTransferred;
            statusController.Visitors = liVisitors;
            statusController.ClearResult = clearResult;
        }

        private void liVisitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusController.VisitorsListBoxSelectedIndexChanged();
        }

        private void retrieveQRdata_Click(object sender, EventArgs e)
        {
            Person visitor;
            visitor = statusController.SelectUserFromQRReaderCode();
            lb_camp.Text = visitor.Camp;
        }

        private void searchByLastName_Click(object sender, EventArgs e)
        {
            statusController.SearchByLastNameButtonClick();
        }

        private void clearResult_Click(object sender, EventArgs e)
        {
            statusController.ClearResultsButtonClick();
            lb_camp.Text = "-";
        }
    }
}
