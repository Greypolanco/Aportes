using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Aporte 
{ 
    [Key] 
    //AporteId,Fecha,PersonaId,Concepto, Monto 
    public int AporteId { get; set; } 
    public DateTime Fecha { get; set; }  
    public int PersonaId { get; set; } 
    public string Concepto { get; set; }  = string.Empty;
    public float Monto { get; set; } 

    [ForeignKey("AporteId")] 
    public List<AporteDetalle> DetalleAporte { get; set; } = new List<AporteDetalle>(); 
}