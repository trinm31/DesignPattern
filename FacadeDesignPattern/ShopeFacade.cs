namespace FacadeDesignPattern
{
    public class ShopeFacade
    {
        private static ShopeFacade _Instance;

        private AccountService _accountService;
        private PaymentService _paymentService;
        private ShippingService _shippingService;
        private EmailService _emailService;
        private SMSService _smsService;

        private ShopeFacade()
        {
            _accountService = new AccountService();
            _paymentService = new PaymentService();
            _shippingService = new ShippingService();
            _emailService = new EmailService();
            _smsService = new SMSService();
        }

        public static ShopeFacade GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new ShopeFacade();
            }

            return _Instance;
        }

        public void BuyProductByCashWithFreeShipping(string email)
        {
            _accountService.GetAccount(email);
            _paymentService.PaymentByCash();
            _shippingService.FreeShipping();
            _emailService.SendMail(email);
        }

        public void BuyProductByPaypalWithStandardShipping(string sms, string email)
        {
            _accountService.GetAccount(email);
            _paymentService.PaymentByPaypal();
            _shippingService.StandardShipping();
            _smsService.SendSms(sms);
        }
    }
}