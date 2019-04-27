﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Fonts;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using PrimeTrade.connections;

namespace PrimeTrade
{
    public partial class frmManagerDashboard : MetroForm
    {
        public frmManagerDashboard()
        {
            InitializeComponent();
            AutoStartMethod();
        }

        MySqlConnection connect = new MySqlConnection(classConnection.ConnectNow("GoogleCloude"));

        public void AutoStartMethod()
        {
            viewPromotions();
            viewDistributers();
            getStockRage();
            getDistributers();
            getAreaCount();
            getSalesRate();
        }

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
                        cmbpromotion.Items.Add(reader.GetString("promotionid"));
                    }
                }
                connect.Close();
            }

        }

        public void viewDistributers()
        {
            connect.Open();

            string query = "SELECT firstname FROM tbl_user WHERE status = 'On' AND role = 'DISTRIBUTER'";
            using (var command = new MySqlCommand(query, connect))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        cmbdistributer.Items.Add(reader.GetString("firstname"));
                    }
                }
                connect.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            connect.Open();
            salesChart.ResetAutoValues();

            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT sum(`tb_sales`.`qty1`), sum(`tb_sales`.`qty2`),`tb_sales`.`salesdate` FROM `base`.`tb_sales` ,`base`.`tbl_user` where `tb_sales`.`distributer` = `tbl_user`.`idtbl_user` AND `tbl_user`.`firstname` = '"+cmbdistributer.SelectedItem+"' AND `tb_sales`.`promotionid` = '"+cmbpromotion.SelectedItem+"' group by `tb_sales`.`salesdate`";
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                salesChart.Series["Main Item Qty"].Points.AddXY(reader.GetString("salesdate"), reader.GetInt32("sum(`tb_sales`.`qty1`)"));
                salesChart.Series["Attached Item QTY"].Points.AddY(reader.GetInt32("sum(`tb_sales`.`qty2`)"));
            }

            connect.Close();
        }

        private void getStockRage()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_stockr_ange";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileStockRange.Text = item2.ToString();
        }

        private void getDistributers()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_distributer_count";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileDistributer.Text = item2.ToString();
        }

        private void getAreaCount()
        {
            int item2 = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_area_count";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@counts", MySqlDbType.Int32);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@counts"].Value.ToString(), out item2);
            connect.Close();

            tileArea.Text = item2.ToString();
        }

        private void getSalesRate()
        {
            double range = 0;
            int total = 0;
            int count = 0;

            MySqlCommand command = new MySqlCommand();
            connect.Open();
            command.Connection = connect;

            command.CommandText = "get_sales_rate";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@total", MySqlDbType.String);
            command.Parameters["@total"].Direction = ParameterDirection.Output;

            command.Parameters.AddWithValue("@counts", MySqlDbType.String);
            command.Parameters["@counts"].Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();

            int.TryParse(command.Parameters["@total"].Value.ToString(), out total);
            int.TryParse(command.Parameters["@counts"].Value.ToString(), out count);

            connect.Close();

            range = (total / count) / 100;

            tileSalesRate.Text = range.ToString();


        }
    }
}