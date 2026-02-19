using System.ComponentModel.DataAnnotations;

namespace desafio_paises.Models;

public class Pais
{
    [Key]
    public int Id { get; set; }
    
    [Required (ErrorMessage = "O campo Nome é obrigatório!!!")] //validaçao de campo antes de salvar
    [StringLength(100)]
    public string Nome { get; set; }
    
    [Required (ErrorMessage = "O campo População é obrigatório!!!")]
    public long Populacao  { get; set; }
    
    [Required (ErrorMessage = "O campo Código do País (DDI) é obrigatório!!!")]
    public int Ddi { get; set; }
    
    [Required (ErrorMessage = "O Campo área total é obrigatório!!!")]
    public double AreaTotal  { get; set; }
    
    [Required (ErrorMessage = "O campo Sigla é obrigatório!!!")]
    public string Sigla { get; set; }
    
    [Required (ErrorMessage = "O campo idioma é obrigatório!!!")]
    public string Idioma { get; set; }
    [Required (ErrorMessage = "O campo Continente é obrigatório!!!")]
    public string Continente { get; set; }
    public bool PaisOnu { get; set; }
    
    [Display(Name = "Data de Fundação")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "O Campo de data de fundação é obrigatório!")]
    public DateTime Fundacao { get; set; }
}