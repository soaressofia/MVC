using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models;

public class Cliente
{
    public int Id {get; set;}
    [Required] // campo obrigatório
    [StringLength(100)] // tamanho máximo do texto em caracter
    public string Nome {get; set;} =string.Empty;
    [StringLength(14)]

    public string? CPF {get; set;} // ? = aceita nulo
    [EmailAddress] // identifica que o campo é email
    [StringLength(150)] // tamanho máximo do campo com 150 caracteres
    public string? Email {get; set;}
    [Phone]
    [StringLength(20)]
    public string? Telefone {get; set;}
    [StringLength(200)]
    public string? Endereco {get; set;}
    [StringLength(100)]
    public string? Cidade {get; set;}
    [StringLength(2)]
    public string? UF {get; set;}
    [DataType(DataType.Date)] // identifica que o campo é data e mostra somente a data
    [Display(Name = "Data de nascimento")] // mostra o campo ao usuario
    public DateTime? DataNascimento {get; set;}
    
    public bool Ativo {get; set;} = true;


}
