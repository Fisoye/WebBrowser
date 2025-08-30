using FinalTest.Models;
using FinalTest.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;

namespace FinalTest.Views
{
    public partial class WebView : Form
    {
        
        string universityWebsite = "https://www.hw.ac.uk/";


        public WebView()
        {
            InitializeComponent();
                      
            ShowFavourites();
            ShowHistory();
            ClearCache();
            CreateCache();
            DiplayUniversityWebsite();

        }

        
       



        private int historyId = 0;
        private async void DiplayUniversityWebsite()
        {
            await GetUrl(universityWebsite);
            searchValue.Text = universityWebsite;
        }

        


        private void ClearCache()
        {
            File.WriteAllText("Cache.txt", string.Empty);
        }

        private void CreateCache()
        {
            //File.WriteAllText(path, (universityWebsite + ()));
            using (StreamWriter sw = File.AppendText("Cache.txt"))
            {
                sw.WriteLine(universityWebsite);

            };
        }

   


        private void ShowFavourites()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("URL");


            var repo = new FavouriteController();
            var favourites = repo.GetFavourites("Favourites.txt");

            string[] lines = File.ReadAllLines("Favourites.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {

                    row[j] = values[j].Trim();
                }
                dataTable.Rows.Add(row);
                this.dataGridView3.DataSource = dataTable;
                this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }


        }

        private void ShowHistory()
        {
            

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("URL");

            var repo = new HistoryController();
            var histories = repo.GetHistory("History.txt");

                     
            string[] lines = File.ReadAllLines("History.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataTable.Rows.Add(row);
            }


                this.dataGridView4.DataSource = dataTable;
            this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }





        private async void button1_Click(object sender, EventArgs e)
        {


            var line = File.ReadLines("Cache.txt").ToArray();

            if (line.Length < 2)
            {
                searchValue.Text = universityWebsite;
            }

            else
            {
                searchValue.Text = "";
                searchValue.Text = line[line.Length - 2];

                string url = searchValue.Text;


                int X;
                string Http = "https://";

                url = searchValue.Text;
                X = url.Length;

                if (X == 0)
                {
                    MessageBox.Show("Enter a URL", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    url = searchValue.Text;
                    X = url.Length;


                }


                else
                {
                    bool hasLetter = Regex.IsMatch(url, Http);
                    if (hasLetter)
                    {
                        url = url;
                    }
                    else { url = Http + url; }


                    await GetUrl(url);
                }

            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var line = File.ReadLines("Cache.txt").ToArray();


            searchValue.Text = line[line.Length - 1];
            string url = searchValue.Text;
            int X;
            string Http = "https://";

            url = searchValue.Text;
            X = url.Length;

            if (X == 0)
            {
                MessageBox.Show("Enter a URL", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

                url = searchValue.Text;
                X = url.Length;


            }


            else
            {
                bool hasLetter = Regex.IsMatch(url, Http);
                if (hasLetter)
                {
                    url = url;
                }
                else { url = Http + url; }


                await GetUrl(url);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFavourite form = new AddFavourite();

            if (form.ShowDialog() == DialogResult.OK)
            {
                ShowFavourites();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("Cache.txt"))
            {
                sw.WriteLine(searchValue.Text);

            };

            HistoryModel history = new HistoryModel();
            history.Id = this.historyId;
            
            history.Url = this.searchValue.Text;

            var repro = new HistoryController();
                      
            repro.AddHistory("History.txt", history);
            



            string url = "";
            int X;
            string Http = "https://";

            url = searchValue.Text;
            X = url.Length;

            if (X == 0)
            {
                MessageBox.Show("Enter a URL", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

                url = searchValue.Text;
                X = url.Length;


            }


            else
            {
                bool hasLetter = Regex.IsMatch(url, Http);
                if (hasLetter)
                {
                    url = url;
                }
                else { url = Http + url; }


                await GetUrl(url);
            }
        }




        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        private async Task GetUrl(string url)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string appTitle = "";
                using HttpResponseMessage response = await client.GetAsync(url);

                if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("400 Bad Request: The server could not understand the request due to invalid syntax.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("403 Forbidden: You do not have permission to access this resource.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("404 Not Found: The requested resource could not be found.");
                }
                else
                {

                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    richTextBox1.Text = responseBody;
                    var match = Regex.Match(responseBody, @"<title>(.*?)</title>", RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        appTitle = match.Groups[1].Value; // Return the title text
                    }
                    else
                    {
                        appTitle = "No title found";
                    }

                    this.Text = appTitle;


                }

            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
            }

            ShowHistory();





        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddFavourite form = new AddFavourite();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ShowFavourites();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                var val = this.dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int favouriteId = int.Parse(val);

                var repo = new FavouriteController();
                var favourite = repo.GetFavourite("Favourites.txt", favouriteId);

                if (favourite == null) return;

                AddFavourite form = new AddFavourite();

                form.EditUrl(favourite);

                if (form.ShowDialog() == DialogResult.OK)

                {
                    ShowFavourites();
                }

            }

            else
            {
                MessageBox.Show("Select one Favourite.");
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                var val = this.dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int favouriteId = int.Parse(val);

                DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to remove favourite?"
                , "Remove Favourite", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                var repo = new FavouriteController();
                repo.DeleteFavourite(favouriteId);

                ShowFavourites();
            }

            else
            {
                MessageBox.Show("Select one Favourite.");
            }
        }

        public void AddFavouriteListBindingSource(BindingSource favourite)
        {
            throw new NotImplementedException();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            string url = searchValue.Text;

            int X;
            string Http = "https://";

            url = searchValue.Text;
            X = url.Length;

            if (X == 0)
            {
                MessageBox.Show("Enter a URL", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

                url = searchValue.Text;
                X = url.Length;


            }


            else
            {
                bool hasLetter = Regex.IsMatch(url, Http);
                if (hasLetter)
                {
                    url = url;
                }
                else { url = Http + url; }


                await GetUrl(url);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WebView_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string fileName = txtDownload.Text;

            if (File.Exists(fileName))
            {
                richTextBox2.Clear(); // Clear previous results

                try
                {
                    string[] urls = File.ReadAllLines(fileName); // Read all URLs

                    foreach (string url in urls)
                    {
                        if (!string.IsNullOrWhiteSpace(url))
                        {
                            DownloadUrl(url);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("File does not exist. Please enter a valid filename.");
            }
        }


        private void DownloadUrl(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    long bytes = response.ContentLength; // Get the size of the content
                    string result = $"{(int)response.StatusCode} {bytes} {url}"; // Format the result
                    richTextBox2.AppendText(result + Environment.NewLine); // Append to results
                }
            }
            catch (WebException ex)
            {
                // Handle cases where the request fails
                string errorCode = ((HttpWebResponse)ex.Response)?.StatusCode.ToString() ?? "Error";
                string result = $"{errorCode} 0 {url}";
                richTextBox2.AppendText(result + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving URL '{url}': {ex.Message}");
            }
        }

        public void GoToFavourite(FavouriteModel favourite)
        {

            this.searchValue.Text = favourite.Url;

        }

        public void GoToHistory(HistoryModel history)
        {

            this.searchValue.Text = history.Url;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                var val = this.dataGridView3.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int favouriteId = int.Parse(val);

                var repo = new FavouriteController();
                var favourite = repo.GetFavourite("Favourites.txt", favouriteId);

                if (favourite == null) return;


                GoToFavourite(favourite);


                tabControl1.SelectedIndex = 0;
            }

            else
            {
                MessageBox.Show("Select one Favourite.");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 1)
            {
                var val = this.dataGridView4.SelectedRows[0].Cells[0].Value.ToString();

                if (val == null || val.Length == 0) return;

                int historyId = int.Parse(val);



                var repo = new HistoryController();
                var history = repo.SearchHistory("History.txt", historyId);

                if (history == null) return;


                GoToHistory(history);


                tabControl1.SelectedIndex = 0;

            }

            else
            {
                MessageBox.Show("Select one URL.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var repo = new HistoryController();
            repo.ClearHistory("History.txt");
            ShowHistory();
        }
    }
}
