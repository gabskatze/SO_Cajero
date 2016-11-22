using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_Proyecto
{
    public partial class Form2 : Form
    {
        private String reporteC1 = "";
        private String reporteC2 = "";
        private String reporteC3 = "";

        public Form2()
        {
            InitializeComponent();
        }

        public void SetTextCaja1(string text)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetTextCaja1(text);
                }));
            }
            else
            {
                reporteC1 = reporteC1 + text + "\n";
                this.caja1.Text = reporteC1;
            }
        }


        public void SetTextCaja2(string text)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetTextCaja2(text);
                }));
            }
            else
            {
                reporteC2 = reporteC2 + text + "\n";
                this.caja2.Text = reporteC2;
            }
        }


        public void SetTextCaja3(string text)
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    SetTextCaja3(text);
                }));
            }
            else
            {
                reporteC3 = reporteC3 + text + "\n";
                this.caja3.Text = reporteC3;
            }
        }



    }
}
