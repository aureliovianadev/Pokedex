using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pokedex.Models;
 
 [Table("Pokemon")]
 public class Pokemon

{
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
       public uint Numero { get; set; }

       [Required(ErrorMessage = "Por favor, informe a Região")]
       public uint RegiaoId { get; set; }
       [ForeignKey("RegiaoId")]
       public Regiao Regiao { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Genêro")]

    public uint GeneroId { get; set; }

    [ForeignKey("GeneroId")]

     public Genero Genero { get; set; }

     [StringLength(30)]
     [Required(ErrorMessage = "Por favor, informe o nome")]

     public string Nome { get; set; }

     [StringLength(1000)]
     public string Descricao { get; set;}
     

}