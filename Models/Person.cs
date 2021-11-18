namespace DockerMySql.Models;

public class Person
{
    public int Id { get; set; }
    [StringLength(60)]
    [Display(Name = "Vorname")]
    public string FirstName { get; set; }
    [StringLength(60)]
    [Display(Name = "Nachname")]
    public string LastName { get; set; }
    [StringLength(3)]
    [Display(Name = "Alter")]
    public int Age { get; set; }
    public Location Location { get; set; }
}
