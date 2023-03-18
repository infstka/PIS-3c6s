using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        async void button1_Click(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            var y = textBox2.Text;

           
            var formContent = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("x", x),
            new KeyValuePair<string, string>("y", y)
             });

            HttpClient client = new HttpClient();
         
            //пост запрос в качестве асихронной операции
            var res = await client.PostAsync("https://localhost:44381/handler/Task4", formContent);
            textBox3.Text = await res.Content.ReadAsStringAsync();
        }
    }
}
