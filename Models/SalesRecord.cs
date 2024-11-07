namespace BroxPOSBackend.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public decimal Expenses { get; set; }
        public decimal OpeningAmount { get; set; }
        public decimal ClosingAmount { get; set; }
    }
}
