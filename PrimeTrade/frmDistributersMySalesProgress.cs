﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmDistributersMySalesProgress : MetroForm
    {
        public frmDistributersMySalesProgress(string userid)
        {
            InitializeComponent();
            viewPromotions();
            lbluserid.Text = userid;
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        

        public void viewPromotions()
        {

            connect.Open();

            string query = "SELECT distinct `tb_sales`.`promotionid` FROM `base`.`tb_sales`";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        CmbPromotion.Items.Add(reader.GetString("promotionid"));
                    }
                }
                connect.Close();
            }

        }

        private void CmbPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Open();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`), sum(`tb_sales`.`qty2`),`tb_sales`.`salesdate` FROM `base`.`tb_sales` where `tb_sales`.`distributer` = '" + lbluserid.Text + "' AND `tb_sales`.`promotionid` = '"+CmbPromotion.SelectedItem+"' group by `tb_sales`.`salesdate`";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chartSales.Series["Main Item Qty"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
                chartSales.Series["Attached Item QTY"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)"));
            }

            connect.Close();
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {

        }
    }
}
