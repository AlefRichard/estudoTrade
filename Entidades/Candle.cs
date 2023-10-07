namespace Entidades
{
    public class Candle
    {
        public decimal low
        {
            get { return _low;  }
            set { _low = value; }
        }
        private decimal _low;

        public decimal high { get; set; }
        public decimal open { get; set; }
        public decimal close { get; set; }
        public decimal amount { get; set; }
        public decimal quantity { get; set; }
        public decimal buyTrakerAmount { get; set; }
        public decimal buyTrakerQuantity { get; set; }
        public int tradeCount { get; set; }
        public long ts { get; set; }
        public string wightedAverage { get; set; }
        public string interval { get; set; }
        public long startTime { get; set; }
        public long closeTime { get; set; }

    }
}