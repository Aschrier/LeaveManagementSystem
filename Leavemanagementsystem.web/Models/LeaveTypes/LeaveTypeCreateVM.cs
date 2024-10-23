using System.ComponentModel.DataAnnotations;

namespace Leavemanagementsystem.web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4,150,ErrorMessage="you have violated the length requirements")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1,90)]
        [Display(Name="Number of days")]
        public int NumberOfDays { get; set; }
    }
}
