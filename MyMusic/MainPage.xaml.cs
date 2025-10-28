namespace MyMusic
{
    public partial class MainPage : ContentPage
    {
        List<string> songs = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            songs.Add("Sample song");
            songs.Add("Sample song");
            playlist.ItemsSource = songs;
        }
    }
}
