using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win.forms
{
    public partial class productList : Form
    {
        List<lecturesNseminarsTBL> allLectures;
        public productList()
        {
            InitializeComponent();
        }

        private void productList_Load(object sender, EventArgs e)
        {
            allLectures = DBHelper.allLecturesNseminars;
            allLectures = allLectures.OrderBy(x => x.Id).ToList();
            productsDGV.DataSource = allLectures;
        }
    }
}
