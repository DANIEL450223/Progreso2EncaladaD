using Progreso2EncaladaD.Repository;

namespace Progreso2EncaladaD.Views;

public partial class Chistes : ContentPage
{
	private readonly ChistesRepository _chistesRepository;

	public Chistes() 
	{ 
		InitializeComponent();
		_chistesRepository = new ChistesRepository();
		CargarChiste();
	}

	private async void CargarChiste() 
	{
		try
		{
            var chiste = await _chistesRepository.GetChisteAsync();
            ChisteLabel.Text = chiste;
        }
		catch (Exception ex)
		{
			ChisteLabel.Text = $"Error en la carga del chiste: {ex.Message}";
		}	
	}


	private void OtroChisteClicked(object sender, EventArgs e) 
	{
		CargarChiste();
	}

}