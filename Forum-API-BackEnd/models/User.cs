namespace Forum_API_BackEnd.Models
{
  public class User{
      [Key]
      public int Id {get; set;}

      [MaxLength(100, ErrorMessage="Este campo não pode ter mais do que 100 caracteres")]
      [MinLength(1, ErrorMessage="Este campo é obrigatório")]
      public String Name {get; set;}

      [MaxLength(500, ErrorMessage="Este campo não pode ter mais do que 500 caracteres")]
      [MinLength(1, ErrorMessage="Este campo é obrigatório")]
      public String Avatar {get; set;}
      public String StringInscritionDate {get; set;}

      [MaxLength(500, ErrorMessage="Este campo não pode ter mais do que 500 caracteres")]
      [MinLength(1, ErrorMessage="Este campo é obrigatório")]
      public String Email {get; set;}

      [Required(ErrorMessage="Este campo é obrigatório")]
      public String Password {get; set;}
  }
}