using WinFormsApp1.Interfaces;

namespace WinFormsApp1 {
    public partial class Form1 : Form {

        private readonly ICustomerService _customerService;
        public Form1(ICustomerService customerService) {
            _customerService = customerService;
            _customerService.Test();
            InitializeComponent();
        }
    }
}
