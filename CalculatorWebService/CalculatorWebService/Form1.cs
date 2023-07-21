using CalculatorService;
using System.ServiceModel;

namespace CalculatorWebService
{
    public partial class Form1 : Form
    {
        private CalculatorSoapClient client;
        public Form1()
        {
            InitializeComponent();
            InitiateClient();
        }

        private void InitiateClient()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            client = new CalculatorSoapClient(binding, endpoint);
        }

        private async void ctrlAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ctrlNum1.Text) || string.IsNullOrEmpty(ctrlNum2.Text))
                {
                    ctrlOutput.Text = "Please provide both numbers.";
                    CleanFields();
                    return;
                }
                int num1 = int.Parse(ctrlNum1.Text);
                int num2 = int.Parse(ctrlNum2.Text);
                int sum = await client.AddAsync(num1, num2);
                ctrlOutput.Text = sum.ToString();
                CleanFields();
            }
            catch (Exception ex)
            {
                ctrlOutput.Text = String.Format("Please provide integer numbers only (32 bits).", ex); // {0}
            }
        }

        private void CleanFields()
        {
            ctrlNum1.Text.Remove(0);
            ctrlNum2.Text.Remove(0);
        }
    }
}