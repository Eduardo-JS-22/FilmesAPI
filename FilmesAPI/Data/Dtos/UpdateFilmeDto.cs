using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatório.")]
    [Range(45, 600, ErrorMessage = "A duração do filme deve ter entre 45 e 600 minutos.")]
    public int Duracao { get; set; }
}
