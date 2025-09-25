using System.ComponentModel.DataAnnotations;

public class Person
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;

    public string CompanyName { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Enter a valid phone number (10-15 digits, optional +)")]
    public string PhoneNumber { get; set; } = string.Empty;
}