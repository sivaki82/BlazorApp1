public class RequestRecord
{
    public string RequestNum { get; set; } = string.Empty;
    public string ApplicantName { get; set; } = string.Empty;
    public DateTime DispositionDate { get; set; }
    public string Status { get; set; } = string.Empty; // Example filter
}