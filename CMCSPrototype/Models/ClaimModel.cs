namespace CMCSPrototype.Models
{
    public class ClaimModel
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime ClaimDate { get; set; }
        public string Status { get; set; }
    }
}
