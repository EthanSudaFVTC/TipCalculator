namespace TipCalculator;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator";
    }

    private void Fifteen_OnClicked(object sender, EventArgs e)
    {
        double dblBill, dblTip;
        Double.TryParse(txtBill.Text, out dblBill);
        dblTip = dblBill * 1.15;
        txtTip.Text = (dblTip).ToString();
    }

    private void Twenty_OnClicked(object sender, EventArgs e)
    {
        double dblBill, dblTip;
        Double.TryParse(txtBill.Text, out dblBill);
        dblTip = dblBill * 1.20;
        txtTip.Text = (dblTip).ToString();
    }

    private void TwentyFive_OnClicked(object sender, EventArgs e)
    {
        double dblBill, dblTip;
        Double.TryParse(txtBill.Text, out dblBill);
        dblTip = dblBill * 1.25;
        txtTip.Text = (dblTip).ToString(); 
    }
}