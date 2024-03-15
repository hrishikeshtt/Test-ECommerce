namespace Test_Ecommerce.Models
{
    public class Payment
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }
        public float ToatalAmount { get; set; }

    }
}
