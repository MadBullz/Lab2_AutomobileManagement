using AutomobileManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomobileManagement
{
    public partial class fUpdateCar : Form
    {
        DBContext db = new DBContext();
        int CarID;

        public fUpdateCar(int CarID)
        {
            InitializeComponent();
            this.CarID = CarID;
        }

        private void fUpdateCar_Load(object sender, EventArgs e)
        {
            var car = (from c in db.Cars
                      where c.CarId == CarID
                      select c).First();
            txtID.Text = car.CarId.ToString();
            txtName.Text = car.CarName;
            cbManu.SelectedItem = car.Manufacturer;
            mtxtPrice.Text = car.Price.ToString();
            txtYear.Text = car.ReleasedYear.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var car = (from c in db.Cars
                       where c.CarId == CarID
                       select c).First();
            car.CarName = txtName.Text;
            car.Manufacturer = cbManu.SelectedItem.ToString();
            car.Price = decimal.Parse(mtxtPrice.Text);
            car.ReleasedYear = Int32.Parse(txtYear.Text);
            db.SaveChanges();
            this.Close();
        }
    }
}
