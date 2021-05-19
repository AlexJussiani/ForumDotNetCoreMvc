namespace Forum_API_BackEnd.Models
{
    public class Cathegory{
      [Key]
      public int Id {get; set;}
      [MaxLength(100, ErrorMessage = "Este campo não pode ter mais que 100 caractere")]
       [MinLength(1, ErrorMessage="Campo Obrigatório!")]
      public string Name {get; set;}

       [MaxLength(500, ErrorMessage="Este campo não pode ter mais do que 500 caracteres")]
        [MinLength(1, ErrorMessage="Campo Obrigatório!")]
      public string Description {get; set;}
    }
}