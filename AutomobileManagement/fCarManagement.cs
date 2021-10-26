using AutomobileManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileManagement
{
    public partial class fCarManagement : Form
    {
        DBContext myDB = new DBContext();

        public fCarManagement()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            fAddCar fAdd = new fAddCar();
            fAdd.ShowDialog();
            reload();
        }

        void reload()
        {
            var cars = myDB.Cars.ToList();
            dgvCar.DataSource = cars;
        }

        private void fCarManagement_Load(object sender, EventArgs e)
        {
            reload();
            dgvCar.ReadOnly = true;
        }

        private void dgvCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int CarID = Int32.Parse(dgvCar.CurrentRow.Cells[0].Value.ToString());
            fUpdateCar fUpdate = new fUpdateCar(CarID);
            fUpdate.ShowDialog();
            reload();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int CarID = Int32.Parse(dgvCar.SelectedRows[0].Cells[0].Value.ToString());
            var car = (from c in myDB.Cars
                     where c.CarId == CarID
                     select c).FirstOrDefault();
            myDB.Cars.Remove(car);
            myDB.SaveChanges();
            reload();
        }
    }
}
