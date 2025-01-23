using System.ComponentModel.DataAnnotations;
namespace HuntILFrontEnd.Models;

public class SiteNameModel
{
  [Required]
  public string SiteId {get; set;} 
  [Required]
  public string Site {get; set;} 
  [Required]
  public int Year {get; set;} 
  [Required]
  public string Species {get; set;} 

  [Required]
  public string Season {get; set;}
  [Required]
  public string Subcategory {get; set;} 
  [Required]
  public int HarvestCount {get;set;}

}