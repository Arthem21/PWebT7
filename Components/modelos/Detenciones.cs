using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
public class Detenciones{

    [Key] 
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } =0;
    public DateTime? FechaD { get; set; }= DateTime.Now;
    public string Nombre { get; set; }=string.Empty;
    public string Apellido { get; set; }=string.Empty;
    public string Pasaporte { get; set; }=string.Empty;
    public DateTime? FechaN { get; set; }= DateTime.MinValue;
    public double longitud { get; set; }=0;
    public double latitud { get; set; } =0;

    public string coordenadas(){

        return $"{latitud},{longitud}";
    }

}