namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }
        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            
            int PlaceNumberValue = 0;
            int.TryParse(placeNumber, out PlaceNumberValue);
            PlaceNumber = PlaceNumberValue;

            decimal PrizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out PrizeAmountValue);
            PrizeAmount = PrizeAmountValue;

            double PrizePercentValue = 0;
            double.TryParse(prizePercentage, out PrizePercentValue);
            PrizePercentage = PrizePercentValue;

        }
    }
}
