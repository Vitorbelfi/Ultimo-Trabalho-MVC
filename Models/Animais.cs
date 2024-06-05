using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoApi.Models
{
    [Table("Animais")]
    public class Animais
    {
        [Column("AnimalId")]
        [Display(Name = "Cod Animal")]
        public int Id { get; set; } 

        [Column("AnimalNome")]
        [Display(Name = "Nome do Animal")]
        public string AnimalNome { get; set; } = string.Empty;

        [Column("AnimalRaca")]
        [Display(Name = "Raça do Animal")]
        public string AnimalRaca{ get; set; } = string.Empty;

        [Column("AnimalTipo")]
        [Display(Name = "Tipo do animal")]
        public string AnimalTipo { get; set; } = string.Empty;

        [Column("AnimalCor")]
        [Display(Name = "Cor do Animal")]
        public string AnimalCor { get; set; } = string.Empty;

        [Column("AnimalSexo")]
        [Display(Name = "Sexo do Animal")]
        public string AnimalSexo { get; set; } = string.Empty;

        [Column("AnimalFoto")]
        [Display(Name = "Link da foto do animal")]
        public string AnimalFoto{ get; set; } = string.Empty;

        [Column("AnimalDtDesaparecimento")]
        [Display(Name = "Data de desaparecimento do animal")]
        public DateTime AnimalDtDesaparecimento { get; set; }

        [Column("AnimalDtEncontro")]
        [Display(Name = "Data de encontro do animal!")]
        public DateTime? AnimalDtEncontro { get; set; } 

        [Column("AnimalStatus")]
        [Display(Name = "Stats do animal!")]
        public byte AnimalStatus { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Cod Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }


    }
}
