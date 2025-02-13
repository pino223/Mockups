namespace MOCKUPS
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void GramosSlider_ValueChanged(object sender, EventArgs e)
        {
            int gramos = (int)((Slider)sender).Value;
            GramosLabel.Text = $"Cantidad: {gramos} g";
        }

        private void DispensarComida_Clicked(object sender, EventArgs e)
        {
            int gramos = (int)GramosSlider.Value;
            DisplayAlert("Comida dispensada", $"Se dispensarán {gramos} gramos de comida.", "Cerrar");
        }
    }

}
