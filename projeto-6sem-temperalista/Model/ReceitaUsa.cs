using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace projeto_6sem_temperalista.Models
{
    [Table("ReceitaUsa")]
    public class ReceitaUsa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemReceita { get; set; }
        [Required]
        public string ItemQtd { get; set; }
        [Required]
        public Tipo_Item Tipo { get; set; }
        [Required]
        public int DespensaId { get; set; }
        [Required]
        public Despensa Despensa { get; set; }
    }
    public enum Tipo_Item
    {
        Supermercado,
        Feira
    }
}
