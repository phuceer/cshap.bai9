using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshap.bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long DungLuongRAM = 0;
            lblname.Text = Environment.MachineName.ToString();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
            ("SELECT * FROM Win32_Computersystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                DungLuongRAM = long.Parse(obj["TotalPhysicalMemory"].ToString());
                DungLuongRAM = DungLuongRAM / (1024 * 1024); 
            }
            lblram.Text = DungLuongRAM.ToString() + " GB";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
