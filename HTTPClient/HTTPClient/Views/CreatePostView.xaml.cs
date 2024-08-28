namespace HTTPClient.Views;
using HTTPClient.ViewModel;

public partial class CreatePostView : ContentPage
{
	public CreatePostView()
	{
		InitializeComponent();
		BindingContext = new CreatePostViewModel();
	}
}