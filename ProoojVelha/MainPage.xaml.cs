﻿namespace ProoojVelha
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
            else if(btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("AAAAAAAAAAIIIII!!!!!🤪🤪🤪", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("ELE FEZ DENOVO!!!!😬😬😬", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("EEEITAAAAAAA!!!🗣️🗣️🗣️", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("IIIIIIIIIIIII!!!!🔥🔥🔥", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("RAPAAAAAAAAAAiz!!!😬😬😬", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if(btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("AAAAAAAAAAIIIII!!!!!🤪🤪🤪", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("GANHOOOOOOOOOOU!!!!!🔥🔥🔥", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if(btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("ELE FEZ DENOVO!!!!😬😬😬", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("RAPAAAAAAAAAAiz!!!😬😬😬", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if(btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("EEEITAAAAAAA!!!🗣️🗣️🗣️", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if(btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("RAPAAAAAAAAAAiz!!!😬😬😬", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if(btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("AAAAAAAAAAIIIII!!!!!🤪🤪🤪", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if(btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("GANHOOOOOOOOOOU!!!!!🔥🔥🔥", "O X ganhou, eba", "OK");
                Zerar();
            }
            else if(btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("RAPAAAAAAAAAAiz!!!😬😬😬", "O rendondinho ganhou", "OK");
                Zerar();
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
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
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";



            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        
        }
    }
}
