using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AssetManagement
{
    public partial class AddAssetForm : Form
    {
        DataGridView grid;

        public AddAssetForm(DataGridView dataGrid)
        {
            grid = dataGrid;

            InitializeComponent();

            assetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Load Asset Template into Grid
            DataGridViewColumn columnA = new DataGridViewColumn();
            columnA.Name = "Category";
            columnA.ReadOnly = true;
            columnA.CellTemplate = dataGrid.Rows[0].Cells[0];
            DataGridViewColumn columnB = new DataGridViewColumn();
            columnB.Name = "Value";
            columnB.CellTemplate = new DataGridViewTextBoxCell();

            assetGrid.AutoGenerateColumns = false;
            assetGrid.AllowUserToAddRows = false;
            assetGrid.Columns.Add(columnA);
            assetGrid.Columns.Add(columnB);
            foreach(DataGridViewColumn column in dataGrid.Columns)
            {
                assetGrid.Rows.Add(column.HeaderText,"");
            }

            int height = dataGrid.ColumnHeadersHeight;
            foreach(DataGridViewRow row in assetGrid.Rows)
            {
                height += row.Height; 
            }
            height += addAssetButton.Height+this.Height - ClientRectangle.Height;
            this.Height = height;
            this.Refresh();

            //Send Button DataGrid
            addAssetButton.Click += (sender,e)=>AddAssetButton_Click(sender,e,dataGrid);
        }

        private void AddAssetButton_Click(object sender, EventArgs e,DataGridView dataGrid)
        {
            string barCode = "";
            foreach (DataGridViewRow row in assetGrid.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Bar Code")
                {
                    barCode = row.Cells[1].Value.ToString();
                }
            }

            if (barCode != ""&&barCode.Length==7)
            {
                if (DataGridViewMethods.findUniqueValue(dataGrid, "BarCode", barCode) == new Point(-1, -1))
                {
                    DataGridViewRow newRow = DataGridViewMethods.CreateBlankRow(dataGrid);
                    foreach(DataGridViewRow row in assetGrid.Rows)
                    {
                        foreach(DataGridViewColumn column in dataGrid.Columns)
                        {
                            if(column.HeaderText==row.Cells[0].Value.ToString())
                            {
                                if(row.Cells[1].Value.ToString().Contains("$")==true)
                                {
                                    row.Cells[1].Value = row.Cells[1].Value.ToString().Replace('$', ' ');
                                }

                                newRow.Cells[column.Index].Value = row.Cells[1].Value;
                            }
                        }
                    }

                    dataGrid.Rows.Add(newRow);
                }

                else
                {
                    MessageBox.Show("Please enter a Unique Bar Code");
                }

            }
            else
            {
                MessageBox.Show("Please Enter a Valid Bar Code");
            }

            this.Close();
        }


    }
}
