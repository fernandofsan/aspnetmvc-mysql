using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMySQL.Models
{
    [Table("tblCliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nro. Matrícula:")]
        [Required(ErrorMessage = "obrigatório.")]
        public int matricula { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Matrícula:")]
        public string dmatricula { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Nascido:")]
        public string nascido { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [MaxLength(14)]
        [Display(Name = "CPF:")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(70)]
        [Display(Name = "Nome Aluno:")]
        public string nome { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "R.G.:")]
        public string rg { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Exped:")]
        public string Exped { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(9)]
        [Display(Name = "Sexo:")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "Telef. Celular:")]
        public string tcel { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(14)]
        [Display(Name = "Telefone Fixo:")]
        public string tfixo { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(60)]
        [Display(Name = "Endereço:")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "Bairro:")]
        public string bairro { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(20)]
        [Display(Name = "Cidade:")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(2)]
        [Display(Name = "Estado:")]
        public string estado { get; set; }

        public string statuscli { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(20)]
        [Display(Name = "instagran:")]
        public string instagran { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(25)]
        [Display(Name = "facebook:")]
        public string facebook { get; set; }

        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}", ErrorMessage = "e-mail inválido")]
        [StringLength(25)]
        [Display(Name = "e-mail:")]
        public string email { get; set; }

        public string foto { get; set; }

        public string biometria { get; set; }

        public string rfacial { get; set; }

        public int colaboradorID { get; set; }
        [ForeignKey("colaboradorID")]
        public virtual Colaborador Colaborador { get; set; }

    }
}