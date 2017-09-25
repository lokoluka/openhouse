using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alquileres
{
    public partial class main_Lease : Form
    {
        public main_Lease()
        {
            InitializeComponent();
        }

        private void main_Lease_Load(object sender, EventArgs e)
        {
            DB d = new DB();
            Person p = new Person();
            p.FirstName = "Lucas";
            d.Add(p);
        }
    }
}
