using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class AporteDetalle 
{ 
    [Key] 
    public int Id { get; set; } 
    public int TipoAporteId { get; set; } 
    public float Valor { get; set; } 
    public Personas Persona { get; set; } 

    [ForeignKey("TipoAporteId")] 
    public TiposAportes TiposAporte { get; set; } 


    public AporteDetalle(int tipoId, float valor, Personas persona, TiposAportes tipo) 
    { 
        Id = 0; 
        TipoAporteId = tipoId; 
        Valor = valor; 
        Persona = persona; 
        TiposAporte = tipo; 

    } 
}