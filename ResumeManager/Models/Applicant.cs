using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResumeManager.Models
{
    public class Applicant
    {
        [Key]  //define PrimaryKey - ChavePrimária
        public int Id { get; set; }

        [Required]  // define campo obrigatório
        [StringLength(100)] //define o tamanho do input
        public string Name { get; set; }

        public string  Gender { get; set; }

        [Required]
        [Range(18, 60, ErrorMessage ="Idades entre 18 e 60 anos")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [Range(5,40, ErrorMessage ="Experiência entre 5 e 40 anos")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
