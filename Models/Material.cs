namespace DreamBlazor.Models;

public class Material
{
    public int Id { get; set; }
    public string Titulo { get; set; } = "";
    public string Descricao { get; set; } = "";
    public string Arquivo { get; set; } = "";
    public DateTime DataPublicacao { get; set; }
    public string Disciplina { get; set; } = "";
}