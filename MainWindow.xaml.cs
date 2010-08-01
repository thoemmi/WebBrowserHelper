namespace WebBrowserHelperDemo {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();

            var model = new MainWindowViewModel {
                MyHtml = @"
<html>
  <body>
    Demonstrating setting the <em>WebBrowser</em>'s content via binding.
  </body>
</html>"
            };

            DataContext = model;
        }
    }
}