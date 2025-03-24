using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ListaDeTarefas.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Titulo {set; get;}
        public String Descricao {set; get;}
        [DefaultValue(false)]
        public bool Concluida {set; get;}

    }
}