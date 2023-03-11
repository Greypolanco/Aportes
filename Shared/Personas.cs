using System.ComponentModel.DataAnnotations;

public class Personas
{
    [Key]
    public int Id { get; set; }
    public string name { get; set; } = string.Empty;

}