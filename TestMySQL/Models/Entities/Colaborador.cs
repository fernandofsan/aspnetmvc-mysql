using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestMySQL.Models
{
    [Table("tblColaborador")]
    public class Colaborador
    {
        #region Pessoais
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Nascimento:")]
        public string colNascimento { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(14)]
        [Display(Name = "CPF:")]
        public string colCPF { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(90)]
        [Display(Name = "Nome:")]
        public string colNome { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "RG:")]
        public string colRG { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Exped:")]
        public string colDataEXPED { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(9)]
        [Display(Name = "Sexo:")]
        public string colSexo { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "Celular:")]
        public string colTCelular { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(14)]
        [Display(Name = "Fixo:")]
        public string colTFixo { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(90)]
        [Display(Name = "Endereço:")]
        public string colEndereco { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(2)]
        [Display(Name = "Estado:")]
        public string colEstado { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(12)]
        [Display(Name = "Bairro:")]
        public string colBairro { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(20)]
        [Display(Name = "Cidade:")]
        public string colCidade { get; set; }
        #endregion

        #region Profissional
        [Required(ErrorMessage = "obrigatório.")]
        [Display(Name = "Nro. Matrícula:")]
        public int colMatricula { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(10)]
        [Display(Name = "Data Matrícula:")]
        public string colDMatricula { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(12)]
        [Display(Name = "Cargo:")]
        public string colCargo { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(12)]
        [Display(Name = "Perfil:")]
        public string colPerfil { get; set; }

        [StringLength(10)]
        [Display(Name = "Nr. CREF:")]
        public string colNrCREF { get; set; }
        #endregion

        #region Login Acessoa ao Sistema
        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(15)]
        [Display(Name = "Usuário:")]
        public string colUsuario { get; set; }

        [Required(ErrorMessage = "obrigatório.")]
        [StringLength(25)]
        [Display(Name = "Senha:")]
        public string colSenha { get; set; }
        #endregion

        #region Período Acesso        
        [StringLength(10)]
        [Display(Name = "Data Acesso:")]
        public string colDtAcesso { get; set; }

        [StringLength(10)]
        [Display(Name = "Horário Acesso:")]
        public string colHoAcesso { get; set; }
        #endregion
    }
}