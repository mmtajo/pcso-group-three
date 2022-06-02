using pcso_group_three.ViewModel;

namespace pcso_group_three.View;


public partial class OrganizationPage : ContentPage
{
	public OrganizationPage(OrganizationViewModel organizationViewModel)
	{
		InitializeComponent();
		BindingContext = organizationViewModel;
	}
}