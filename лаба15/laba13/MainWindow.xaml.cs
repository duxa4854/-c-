using System.Text;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TotalPairs = 10;
        private readonly List<string> _originalEmojis = new List<string>(){
            "🐭","🐭", "🐗","🐗",
            "🐷","🐷", "🐮","🐮",
            "🦝","🦝", "🦊","🦊",
            "🦒","🦒", "🦁","🦁",
            "🐯","🐯", "🐱","🐱",
            };
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private int _tenthsOfSecondsElapsed;
        private int _matchesFound;
        private readonly Random _random = new Random();
        TextBlock _lastTextBlockClicked;
        private bool _findingMatch = false;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            SetUpGame();
        }
        private void InitializeTimer()
        {
            _timer.Interval = TimeSpan.FromSeconds(.1);
            _timer.Tick += Timer_Tick;
        }
        
            
        private void Timer_Tick(object? sender, EventArgs e)
        {
            _tenthsOfSecondsElapsed++;
            timeTextBlock.Text = $"{_tenthsOfSecondsElapsed / 10F:0.0s}";
            if (_matchesFound == TotalPairs)
            {
                _timer.Stop();
                timeTextBlock.Text += "- Play again?";
            }
        }

        private void AssignRandomEmojis()
        {
            var emojis = new List<string>(_originalEmojis);
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock"){
                    textBlock.Visibility = Visibility.Visible;
                    int index = _random.Next(emojis.Count);
                    string nextEmoji = emojis[index];
                    textBlock.Text = emojis[index];
                    emojis.RemoveAt(index);
                }
            }
        }

        private void SetUpGame() {
            AssignRandomEmojis();
            _timer.Start();
            _tenthsOfSecondsElapsed = 0;
            _matchesFound = 0;
        }
        


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_matchesFound== 10)
            {
                SetUpGame();
            }
            TextBlock textBlock = sender as TextBlock;
            if (_findingMatch == false)  
            {
                textBlock.Visibility = Visibility.Hidden;
                _lastTextBlockClicked = textBlock;
                _findingMatch = true;
            } else if (textBlock.Text == _lastTextBlockClicked.Text){
                _matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                _findingMatch = false;
            } else{
                _lastTextBlockClicked.Visibility = Visibility.Visible;
                _findingMatch = false;
            }
        }
    }

}