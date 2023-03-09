using System.ComponentModel.DataAnnotations;

namespace RazorPagesBill.Models;

public class Bill 
{
     public int Id {get; set;}

    [Required]
    public string? BillName {get; set;}

    [Required]
    public string? BillType {get; set;}

    [Required]
    public string? StateName {get; set;}

    [Required]
    [MaxLength(1000)]
    public string? Description {get; set;}
    public bool IsLaw {get; set;}
}