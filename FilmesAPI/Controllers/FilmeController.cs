using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        if (filme != null)
        {
            filmes.Add(filme);
            Console.WriteLine($"Titulo: {filme.Titulo}, Genero: {filme.Genero}, Duração: {filme.Duracao} minutos");
        }
    }
}
