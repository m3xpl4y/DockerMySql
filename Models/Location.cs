namespace DockerMySql.Models;

public class Location
{
    public int Id { get; set; } 
    [StringLength(100)]
    [Display(Name = "Location")]
    public string LocationName { get; set; }
}
