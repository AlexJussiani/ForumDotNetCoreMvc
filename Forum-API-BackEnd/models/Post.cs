namespace Forum_API_BackEnd.Models
{
    public class Post{
    [Key]
    public int Id {get; get;}

    [MaxLength(5000, ErrorMessage="Este campo não pode ter mais do que 5000 caracteres")]
    [MinLength(1, ErrorMessage="Campo Obrigatório")]
    public String Text {get; get;}
    public String Author {get; get;}
    public String Parent {get; get;}

    [Required(ErrorMessage="Este campo não pode ser vazio")]
    public Date Date {get; get;}
    }
}