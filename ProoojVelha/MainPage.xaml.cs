namespace ProoojVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;

            bnt.IsEnabled = false;

            if(vez == "X")
            {
                bnt.Text = "X";
                vez = "O";
            }
            else
            {
                bnt.Text = "O";
                vez = "X";
            }

            /*verificar se o X ganhow na primeira linha*/
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("GANHOOOOOOOOOOU!!!!!🔥🔥🔥", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("EEEITAAAAAAA!!!🗣️🗣️🗣️", "O rendondinho ganhou", "OK");
                Zerar();
            }
        }// Fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
        }
    }
}
