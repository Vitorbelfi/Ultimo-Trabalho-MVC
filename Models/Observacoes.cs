using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoApi.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacaoId")]
        [Display(Name = "Código da Observação")]
        public int Id { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Descrição sobre a Observação")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Local de Observação")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Código do Usuário")]
        public DateTime ObservacaoData { get; set; }

        [ForeignKey("AnimalId")]
        [Display(Name = "Cód Do Animal")]
        public int AnimalId { get; set; }
        public Animais? Animais { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Cod Do Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
