namespace Aula.Models;

public class Cliente
{
    public string? Nome { get; set; }
    public string? Telefone { get; set; }

    public override string ToString()
    {
        return $"Nome: {this.Nome} , Telefone: {this.Telefone}";
    }
}
