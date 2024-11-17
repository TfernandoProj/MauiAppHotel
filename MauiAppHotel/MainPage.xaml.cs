﻿using MauiAppHotel.Views; // Certifique-se de importar o namespace correto

namespace MauiAppHotel;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void NavigateToSobre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
