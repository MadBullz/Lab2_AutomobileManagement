using AutomobileManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace AutomobileManagement
{
    public partial class fAddCar : Form
    {
        DBContext myCars = new DBContext();

        public fAddCar()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddCar_Load(object sender, EventArgs e)
        {
            var ID = (from car in myCars.Cars
                      orderby car.CarId
                      select car.CarId).Last();
            ID += 1;
            txtID.Text = ID.ToString();
            txtID.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            { 
                CarName = txtName.Text,
                Manufacturer = cbManu.SelectedItem.ToString(),
                Price = decimal.Parse(mtxtPrice.Text),
                ReleasedYear = Int32.Parse(txtYear.Text)
            };
            myCars.Cars.Add(car);
            myCars.SaveChanges();
            this.Close();
        }
    }
}
