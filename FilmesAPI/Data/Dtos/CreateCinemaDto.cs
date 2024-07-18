using System.ComponentModel.DataAnnotations;
namespace FilmesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
}