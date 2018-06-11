using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;

namespace LicenseManagement
{
    public partial class Form1 : Form
    {
        public string api = "http://120.72.107.61:9780/Licence/";
        //public string api = "http://localhost:1234/NFCDashboard-server/";
        public Form1()
        {
            InitializeComponent();
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api);
            HttpResponseMessage response = clint.GetAsync("app/keysingle/getAll").Result;
            Object key_single = response.Content.ReadAsAsync<Object>().Result;
            List<KeySingle> list = JsonConvert.DeserializeObject<List<KeySingle>>(key_single.ToString());
            dtgKey.DataSource = convertJsonToDataTable(list);
            pannelGen.Hide();
            panelReset.Hide();
            panelAdjourn.Hide();
        }

        DataTable convertJsonToDataTable(List<KeySingle> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("key_single", typeof(string));
            dt.Columns.Add("ex_main", typeof(string));
            dt.Columns.Add("ex_cpu", typeof(string));
            dt.Columns.Add("start_date", typeof(DateTime));
            dt.Columns.Add("end_date", typeof(DateTime));
            dt.Columns.Add("key_log", typeof(int));
            dt.Columns.Add("key_left", typeof(int));
            dt.Columns.Add("status_key", typeof(string));

            foreach(KeySingle key in list)
            {
                TimeSpan time = new TimeSpan();
                if(key.end_date == null)
                {
                    dt.Rows.Add(key.id, key.key_single, key.ex_main, key.ex_cpu, key.start_date, key.end_date, key.key_log, 0, key.status_key);
                }
                else
                {
                    time = (TimeSpan)(key.end_date - DateTime.Now);
                    dt.Rows.Add(key.id, key.key_single, key.ex_main, key.ex_cpu, key.start_date, key.end_date, key.key_log,(int) time.TotalDays, key.status_key);
                }
                
            }
            return dt;
        }

        private void dtgKey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKey.Text = dtgKey.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dtgKey.Rows[e.RowIndex].Cells[2].Value == null)
            {
                txtMain.Text = "";
            }
            else
            {
                txtMain.Text = dtgKey.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            if (dtgKey.Rows[e.RowIndex].Cells[3].Value == null)
            {
                txtCPU.Text = "";
            }
            else
            {
                txtCPU.Text = dtgKey.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

            if (dtgKey.Rows[e.RowIndex].Cells[4].Value.ToString() == "")
            {
                dtStart.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                dtStart.Text = DateTime.Parse(dtgKey.Rows[e.RowIndex].Cells[4].Value.ToString()).ToString();
            }

            if (dtgKey.Rows[e.RowIndex].Cells[5].Value.ToString() == "")
            {
                dtEnd.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                dtEnd.Text = DateTime.Parse(dtgKey.Rows[e.RowIndex].Cells[5].Value.ToString()).ToString();
            }

            if (dtgKey.Rows[e.RowIndex].Cells[6].Value == null)
            {
                txtExTime.Text = "";
            }
            else
            {
                txtExTime.Text = dtgKey.Rows[e.RowIndex].Cells[6].Value.ToString();
            }

            cbStatus.Text = dtgKey.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api);
            HttpResponseMessage response = clint.GetAsync("app/keysingle/getAll").Result;
            Object key_single = response.Content.ReadAsAsync<Object>().Result;
            List<KeySingle> list = JsonConvert.DeserializeObject<List<KeySingle>>(key_single.ToString());
            dtgKey.DataSource = convertJsonToDataTable(list);
        }

        private void btnGetKeyActived_Click(object sender, EventArgs e)
        {
            HttpClient clint = new HttpClient();
            clint.BaseAddress = new Uri(api);
            HttpResponseMessage response = clint.GetAsync("app/keysingle/getFilterKeyActive").Result;
            Object key_single = response.Content.ReadAsAsync<Object>().Result;
            List<KeySingle> list = JsonConvert.DeserializeObject<List<KeySingle>>(key_single.ToString());
            dtgKey.DataSource = convertJsonToDataTable(list);
        }

        void SearchKey(string keysingle)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(api);
                var result = client.PostAsync(string.Format("app/keysingle/searchKey?key_single={0}", keysingle), null).Result;
                var resultContent = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(resultContent);
                KeySingle key = JsonConvert.DeserializeObject<KeySingle>(resultContent);
                DataTable dt = new DataTable();
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("key_single", typeof(string));
                dt.Columns.Add("ex_main", typeof(string));
                dt.Columns.Add("ex_cpu", typeof(string));
                dt.Columns.Add("start_date", typeof(DateTime));
                dt.Columns.Add("end_date", typeof(DateTime));
                dt.Columns.Add("key_log", typeof(int));
                dt.Columns.Add("key_left", typeof(int));
                dt.Columns.Add("status_key", typeof(string));

                // Here we add five DataRows.
                TimeSpan time = new TimeSpan();
                if (key.end_date == null)
                {
                    dt.Rows.Add(key.id, key.key_single, key.ex_main, key.ex_cpu, key.start_date, key.end_date, key.key_log, 0, key.status_key);
                }
                else
                {
                    time = (TimeSpan)(key.end_date - DateTime.Now);
                    dt.Rows.Add(key.id, key.key_single, key.ex_main, key.ex_cpu, key.start_date, key.end_date, key.key_log, (int)time.TotalDays, key.status_key);
                }
                dtgKey.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SearchKey(txtKey.Text);
            }
            catch
            {

            }
        }

        private void btnGenKey_Click(object sender, EventArgs e)
        {
            panelReset.Hide();
            panelAdjourn.Hide();
            panelKey.Hide();
            pannelGen.Show();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(api);
                var result = client.PostAsync(string.Format("app/keysingle/genKeyByNum?num={0}", int.Parse(txtQuantity.Text)), null).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                if (bool.Parse(resultContent) == true)
                {
                    btnGetAll_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi !");
                }
                pannelGen.Hide();
                panelKey.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            panelReset.Show();
            panelAdjourn.Hide();
            panelKey.Hide();
            pannelGen.Hide();
        }

        private void txtKeyReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchKey(txtKeyReset.Text);
            }
        }

        private void btnResetKey_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(api);
                var result = client.PostAsync(string.Format("app/keysingle/resetKey?key_single=" + txtKeyReset.Text), null).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                if (bool.Parse(resultContent) == true)
                {
                    SearchKey(txtKeyReset.Text);
                }
                else
                {
                    MessageBox.Show("Có lỗi !");
                }
                panelReset.Hide();
                panelKey.Show();
            }
        }

        private void txtKeyReset_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchKey(txtKeyReset.Text);
            }
            catch
            {

            }
        }

        private void btnAdjourn_Click(object sender, EventArgs e)
        {
            panelAdjourn.Show();
            panelReset.Hide();
            panelKey.Hide();
            pannelGen.Hide();
        }

        private void txtKeyAdjourn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchKey(txtKeyAdjourn.Text);
            }
            catch
            {

            }
        }

        private void btnPnAdjourn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(api);
                var result = client.PostAsync(string.Format("app/keysingle/adjourn?key_single=" + txtKeyAdjourn.Text + "&num=" + int.Parse(txtNumDate.Text)), null).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                if (bool.Parse(resultContent) == true)
                {
                    SearchKey(txtKeyAdjourn.Text);
                }
                else
                {
                    MessageBox.Show("Có lỗi !");
                }
                panelAdjourn.Hide();
                panelKey.Show();
            }
        }
    }
}
