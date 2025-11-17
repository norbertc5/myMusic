namespace MyMusic
{
    public partial class MainPage : ContentPage
    {
        List<string> songs = new List<string>();
        List<string> likedSongs = new List<string>();
        public Command<string> PlaySongCommand { get; set; }


        public MainPage()
        {
            InitializeComponent();
            songs.Add("s1");
            songs.Add("s2");
            playlist.ItemsSource = songs;
            PlaySongCommand = new Command<string>(OnSongClicked);
            BindingContext = this;

        }

        private void OnSongClicked(string song)
        {
            // TU WIESZ KTÓRA PIOSENKA ZOSTAŁA KLIKNIĘTA
            DisplayAlert("Kliknięto", $"Kliknięto: {song}", "OK");
        }

        private void Like_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Play_Clicked(object sender, EventArgs e)
        {

        }
    }
}
