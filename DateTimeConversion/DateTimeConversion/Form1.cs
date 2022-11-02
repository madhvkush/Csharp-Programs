using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTimeFormatInfo usDtfi = new CultureInfo("en-US", false).DateTimeFormat;
            DateTimeFormatInfo ukDtfi = new CultureInfo("fr-FR", false).DateTimeFormat;

            var cult = System.Globalization.CultureInfo.CurrentCulture;

            string strDate = DateTime.Now.ToString(usDtfi);
            string strDate2 = DateTime.Now.ToString();
            
            label1.Text = strDate;
            string result = Convert.ToDateTime(strDate, usDtfi).ToString(usDtfi);
            label2.Text = result;
        }
    }
}
