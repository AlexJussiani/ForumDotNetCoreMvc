namespace Forum_API_BackEnd.Models
{
    public class Topic{
    [Key]
     public int Id  {get; get;}

     [MaxLength(100, ErrorMessage="Este campo não pode ter mais do que 100 caracteres")]
     [MinLength(1, ErrorMessage="Este campo deve ser preenchido")]
     public String Name  {get; get;}
     public String Description  {get; get;}
    }
}