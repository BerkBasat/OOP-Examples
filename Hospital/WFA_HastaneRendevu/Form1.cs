using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Branch> branchList = new List<Branch>();
        List<Appointment> appointmentList = new List<Appointment>();
        private void btnBransEkle_Click(object sender, EventArgs e)
        {

            if (txtBrans.Text != "")
            {
                Branch branch = new Branch();
                branch.Name = txtBrans.Text;
                branch.DoctorList = new List<Doctor>();
                branchList.Add(branch);

                foreach (Branch br in branchList)
                {
                    cmbBrans.DataSource = cmbRandevuBrans.DataSource = branchList.ToList();
                }
            }
            else
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
            }


            txtBrans.Text = "";

        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            if(txtDoktorAd.Text != "")
            {
                Doctor doctor = new Doctor();
                doctor.Name = txtDoktorAd.Text;
                Branch b = (Branch)cmbBrans.SelectedItem;
                b.DoctorList.Add(doctor);

            }
            else
            {
                MessageBox.Show("Bu alan boş bırakılamaz!");
            }

            txtDoktorAd.Text = "";
            cmbBrans.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Geçersiz Randevu Tarihi!");
            }
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            int hour = 9;
            int minute = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Button btn = new Button();
                    btn.Width = 90;
                    btn.Height = 50;
                    btn.Text = String.Format($"{hour}:{minute}0");
                    if (minute == 0)
                    {
                        minute = 3;
                    }
                    else
                    {
                        minute = 0;
                        hour++;
                    }
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult dr = MessageBox.Show("Randevu Oluşturmak İstiyormusunuz?", "Randevu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Appointment appointment = new Appointment();
                btn.Enabled = false;
                btn.BackColor = Color.Red;
                appointmentList.Add(appointment);
            }
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch branch = (Branch)cmbRandevuBrans.SelectedItem;
            cmbRandevuDoktor.DataSource = branch.DoctorList.ToList();
        }
    }
}

