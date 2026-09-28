using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHMApp.Models;

public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PatientId { get; set; }

    [Required(ErrorMessage = "Patient Name is required.")]
    [StringLength(35, MinimumLength = 4, ErrorMessage = "Patient Name must be between 4 and 35 characters.")]
    public string PatientName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Contact No is required.")]
    [StringLength(35, ErrorMessage = "Contact No cannot exceed 35 characters.")]
    [RegularExpression(@"^[0-9+()\- ]{7,35}$", ErrorMessage = "Contact No is not in a valid format.")]
    public string ContactNo { get; set; } = string.Empty;

    public List<Appointment> Appointments { get; set; } = new();
}
