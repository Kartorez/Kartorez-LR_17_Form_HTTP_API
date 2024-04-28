
using System.Text.Json;

namespace LR_17_Form_HTTP_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ImageDogi_Click(object sender, EventArgs e)
        {
            await UpdateDogImage();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await UpdateDogImage();

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += async (s, args) => await UpdateDogImage();
            timer.Interval = 60000; //1 хв
            timer.Start();
        }
        private async Task UpdateDogImage()
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://dog.ceo/api/breeds/image/random");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var jsonDocument = JsonDocument.Parse(responseBody);
                var messageElement = jsonDocument.RootElement.GetProperty("message");
                string message = messageElement.GetString();
                ImageDogi.ImageLocation = message;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Виникла помилка під час оновлення зображення: " + ex.Message, "Помилка");
            }
        }



    }
}
