namespace AbadExamenP2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Label Resultado = new Label();
            Resultado.SetBinding(Label.TextProperty, new Binding("Resultado", source: resultado));
            int valor = Int32.Parse("45");
            var picker1 = (Picker)sender;
            var picker2 = (Picker)sender;
            int pick1 = picker1.SelectedIndex;
            int pick2 = picker2.SelectedIndex;
            if (pick1 == 0 && pick2 == 0)
            {

            }
        }

    }
}
