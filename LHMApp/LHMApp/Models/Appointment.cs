using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHMApp.Models;

public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AppointmentId { get; set; }

    [Required(ErrorMessage = "Patient is required.")]
    public int PatientId { get; set; }

    [Required(ErrorMessage = "Appointment Date is required.")]
    [DataType(DataType.DateTime)]
    public DateTime AppointmentDate { get; set; }

    [ForeignKey(nameof(PatientId))]
    public Patient? Patient { get; set; }
}
