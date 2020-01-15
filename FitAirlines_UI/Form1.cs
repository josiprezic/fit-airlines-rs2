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

namespace FitAirlines_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44338");
            HttpResponseMessage response = client.GetAsync("/api/user").Result;

            if (response.IsSuccessStatusCode)
            {
                // List<Object> users = response.Content.ReadAsAsync<List<Object>>().Result;
            
                MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
            else 
            {
                MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
