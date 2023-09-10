using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_6sem_temperalista.Models
{
    [Table("Despensa")]
    public class Despensa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemNome { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Qtd { get; set; }
        [Required]
        public int CodBarras { get; set; }
        
        public ICollection<ReceitaUsa> ReceitaUsa { get; set; }

    }
}
