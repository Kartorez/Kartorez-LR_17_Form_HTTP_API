using System.Net.Http.Json;

record DogApi(string Message, string Status);

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
            timer.Interval = 60000; //1 munyta
            timer.Start();
        }
        private async Task UpdateDogImage()
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://dog.ceo/api/breeds/image/random");
                response.EnsureSuccessStatusCode();
                DogApi dogApiResponse = await response.Content.ReadFromJsonAsync<DogApi>();
                string message = dogApiResponse.Message;
                ImageDogi.ImageLocation = message;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Виникла помилка під час оновлення зображення: " + ex.Message, "Помилка");
            }
        }



    }
}
