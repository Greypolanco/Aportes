using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TiposAportes 
{ 
    [Key] 
    public int TipoAporteId { get; set; } 
    public string Descripcion { get; set; }  = string.Empty;
    public float Meta { get; set; }  
    public float Logrado { get; set; } 
}