namespace RPGCompanionApp.View;

public partial class DiceView : ContentView
{
	public DiceView()
	{
		InitializeComponent();

		BindingContext = new DiceViewModel();
	}
}