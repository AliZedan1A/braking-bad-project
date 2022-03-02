using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;

namespace braking_bad_project
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combobox();
            pnltct.Location = pnlEND.Location;
            PnlCharacters.Location = pnlEND.Location;
            tct.Text = "Hello, I'm Ali Zedan, this application was programmed to test my abilities in dealing with the API Via C#The idea of ​​the application is to take all the episodes and characters of the series Breaking BadAnd display it in data in the form";
            starthome();
            pnltct.Visible = true;
        }

        private void btnsearchEND_Click(object sender, EventArgs e)
        {
            
                if (textsearchEND.Text == String.Empty)
                {
                    MessageBox.Show("no input");
                }
                else
                {

                    searchEndByID();
                }
            
            
        }
        private async void searchEndByID()
        {
            dataGridView1.Rows.Clear();
            int id = int.Parse(textsearchEND.Text);
            string api = $"https://www.breakingbadapi.com/api/episodes/{id}";

            var repo = await client.GetStringAsync(api);
            List<episodeG>? jsonali = JsonConvert.DeserializeObject<List<episodeG>>(repo);
            foreach (episodeG items in jsonali)
            {

                title.Text = items.title;
                ID.Text = items.episode_id.ToString();
                air_date.Text = items.air_date;
                season.Text = items.season;

                series.Text = items.series;


                var charctersview = items.characters; // المصفوفة التي تحمل الشخصيات
                foreach (string characters in charctersview)
                {
                    dataGridView1.Rows.Add(characters);
                }

            }
        }

        private void searchEND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void textsearchEND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("cant copy or past in this text box");
            }
        }

        private void pnlEND_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnltct.Visible = false;

            if (PnlCharacters.Visible ==true)
            {
                PnlCharacters.Visible = false;
                if (pnlEND.Visible == false)
                {
                    pnlEND.Visible = true;
                   

                }
                else
                {
                    pnlEND.Visible = false;
                }
            }
            else
            {
                if (pnlEND.Visible == false)
                {
                    pnlEND.Visible = true;

                }
                else
                {
                    pnlEND.Visible = false;
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void formsize()
        {
            this.Size = new Size(1294, 752);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width)/2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            formsize();

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            formsize();
        }
        private async void combobox()
        {
            string api = $"https://www.breakingbadapi.com/api/characters";

            var repo = await client.GetStringAsync(api);
            List<Root>? jsonali = JsonConvert.DeserializeObject<List<Root>>(repo);
            foreach (Root character in jsonali)
            {
                comboBox1.Items.Add(character.name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnltct.Visible = false;

            if (pnlEND.Visible == true)
            {
                pnlEND.Visible = false;
                if (PnlCharacters.Visible == false)
                {
                    PnlCharacters.Visible = true;

                }
                else
                {
                    PnlCharacters.Visible = false;
                }
            }
            else
            {
                if (PnlCharacters.Visible == false)
                {
                    PnlCharacters.Visible = true;

                }
                else
                {
                    PnlCharacters.Visible = false;
                }
            }
           
        }
        private async void searchCharcterByName()
        {
            pictureBox1.Visible = true;
            if (dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;

            }
            else
            {
                //nothing
            }

            string name = comboBox1.Text;
            string api = $"https://www.breakingbadapi.com/api/characters?name={name}";

            var repo = await client.GetStringAsync(api);
            List<Root>? jsonali = JsonConvert.DeserializeObject<List<Root>>(repo);
            foreach (Root character in jsonali)
            {
                lblName.Text = character.name;
                lblBirthday.Text = character.birthday;
                lblStatus.Text = character.status;
                lblNickName.Text = character.nickname;
                idlbl.Text = character.char_id.ToString();

                WebRequest request =  WebRequest.Create(character.img);
                using (var response = await request.GetResponseAsync())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(str);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("no input");
            }
            else
            {

                searchCharcterByName();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlEND.Visible = false;
            PnlCharacters.Visible = false;
            pnltct.Visible = true;

        }
        private async void starthome()
        {
            dataGridView2.Rows.Clear();
            string api = $"https://www.breakingbadapi.com/api/episodes";

            var repo = await client.GetStringAsync(api);
            List<episodeG>? jsonali = JsonConvert.DeserializeObject<List<episodeG>>(repo);
            foreach (episodeG items in jsonali)
            {
                var charctersview = items.episode_id.ToString(); // المصفوفة التي تحمل الشخصيات
                List<string> listDate = new List<string>();
                listDate.Add(charctersview);
                listDate.Add(items.title);


                dataGridView2.Rows.Add(listDate[0]);
                dataGridView2.Rows.Add(listDate[1]);
              
               



            }

        }
    }

    //object json class : 
    public class episodeG
    {
        public int episode_id { get; set; }
        public string? title { get; set; }
        public string? season { get; set; }
        public string? air_date { get; set; }
        public List<string>? characters { get; set; }
        public string? episode { get; set; }
        public string? series { get; set; }
    }
    public class Root
    {
        public int char_id { get; set; }
        public string? name { get; set; }
        public string? birthday { get; set; }
        public List<string>? occupation { get; set; }
        public string? img { get; set; }
        public string? status { get; set; }
        public string? nickname { get; set; }
        public List<int>? appearance { get; set; }
        public string? portrayed { get; set; }
        public string? category { get; set; }
        public List<object>? better_call_saul_appearance { get; set; }
    }

}