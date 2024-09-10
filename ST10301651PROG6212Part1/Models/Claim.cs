namespace ST10301651PROG6212Part1.Models
{
    public class Claim
    {
        public int CLaimID { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
