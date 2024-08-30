using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.json.Linq;

{

}


namespace WeatherApp
{
    public partial class Form1 :Form
    {
        /// <summary>
        private const string apiKey = "b1b15e88fa797225412429c1c50c122a1\">api.openweathermap.org/data/2.5/forecast?id&appid={API key}";
        private const string baseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            if (!string.IsNullOrEmpty(city))
            {
                string weatherInfo = await GetWeatherAsync(city);
                lblWeatherInfo.Text = weatherInfo;
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome de uma cidade.");
            }
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{baseUrl}?q={city}&appid={apiKey}&units=metric&lang=pt_br";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    string description = data["weather"][0]["description"].ToString();
                    string temp = data["main"]["temp"].ToString();
                    return $"Clima: {description}\nTemperatura: {temp}°C";
                }
                else
                {
                    return "Não foi possível obter as informações do clima.";
                }
                
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}