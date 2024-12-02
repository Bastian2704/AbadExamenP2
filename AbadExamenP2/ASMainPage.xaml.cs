namespace AbadExamenP2
{
    public partial class MainPage : ContentPage
    {

        int selectedIndex1;
        int selectedIndex2;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            double valor = Double.Parse(numero.Text);
            Label Resultado = new Label();
            Resultado.SetBinding(Label.TextProperty, new Binding("R", source: resultado));

            int pick1 = selectedIndex1;
            int pick2 = selectedIndex2;

            Resultado.Text = valor.ToString("F2");
       
          //  Resultado.Text = "valor.ToString()";
            if (pick1 == 0 && pick2 == 0)
            {
                
            }
        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker1 = (Picker)sender;
            int selectedIndex = picker1.SelectedIndex;

            if (selectedIndex != -1)
            {
               selectedIndex1 = picker1.SelectedIndex;
            }
        }
        void OnPickerSelectedIndexChanged2(object sender, EventArgs e)
        {
            var picker2 = (Picker)sender;
            int selectedIndex = picker2.SelectedIndex;

            if (selectedIndex != -1)
            {
                selectedIndex1 = picker2.SelectedIndex;
            }
        }

    }
}
