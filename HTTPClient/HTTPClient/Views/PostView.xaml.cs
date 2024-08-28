namespace HTTPClient.View;
using HTTPClient.ViewModel;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		BindingContext = new PostViewModels();
	}
}