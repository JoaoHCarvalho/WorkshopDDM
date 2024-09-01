namespace ExemploMAUI;

public partial class Teste1 : ContentPage
{
	string nome;
	public Teste1()
	{
		InitializeComponent();
	}

    private async void NomeAlert_Clicked(object sender, EventArgs e)
    {
		nome = await DisplayPromptAsync("Nome", "Digite o seu nome: ", "Ok");
		await DisplayAlert("Aviso", "Bem vindo "+nome+"!", "Ok");
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}