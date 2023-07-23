using CalculatorService;
using System.ServiceModel;
using System.Xml.Linq;

namespace CalculatorWebService
{
    public partial class Form1 : Form
    {
        private CalculatorSoapClient client;
        public Form1()
        {
            InitializeComponent();
            InitiateClient();

            ctrlAdd.Click += ctrlButton_Click;
            ctrlSubtract.Click += ctrlButton_Click;
            ctrlMultiply.Click += ctrlButton_Click;
            ctrlDivide.Click += ctrlButton_Click;  
        }

        private void InitiateClient()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://www.dneonline.com/calculator.asmx");
            client = new CalculatorSoapClient(binding, endpoint);
        }

        private async void ctrlButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                if (!FieldsHasValues())
                {
                    ShowOutputResult("Please provide both numbers.");
                    CleanFields();
                    return;
                }
                InputValues inputValues = AssignInputValues();

                int sum = await ExecuteClientOperationAsync(button.Name, inputValues);
                ShowOutputResult(sum.ToString());
                CleanFields();
            }
            catch (Exception)
            {
                ShowOutputResult("Please provide integer numbers only (32 bits).");
            }
        }

        private async Task<int> ExecuteClientOperationAsync(string name, InputValues inputValues)
        {
            int sum;
            switch (name)
            {
                case "ctrlAdd":
                    sum = await client.AddAsync(inputValues.Num1, inputValues.Num2);
                    break;
                case "ctrlSubtract":
                    sum = await client.SubtractAsync(inputValues.Num1, inputValues.Num2);
                    break;
                case "ctrlMultiply":
                    sum = await client.MultiplyAsync(inputValues.Num1, inputValues.Num2);
                    break;
                case "ctrlDivide":
                    sum = await client.DivideAsync(inputValues.Num1, inputValues.Num2);
                    break;
                default:
                    sum = 0;
                    break;
            }

            return sum;
        }

        private InputValues AssignInputValues()
        {
            InputValues inputValues = new InputValues()
            {
                Num1 = int.Parse(ctrlNum1.Text),
                Num2 = int.Parse(ctrlNum2.Text)
            };
            return inputValues;
        }

        private void CleanFields()
        {
            ctrlNum1.Text.Remove(0);
            ctrlNum2.Text.Remove(0);
        }

        private bool FieldsHasValues()
        {
            return !string.IsNullOrEmpty(ctrlNum1.Text) && !string.IsNullOrEmpty(ctrlNum2.Text);
        }

        private void ShowOutputResult(string showOutputResult)
        {
            ctrlOutput.Text = showOutputResult;
        }
    }

    public class InputValues
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public InputValues()
        {

        }
    }
}