//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto.GestaoProjetos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Projeto = new HashSet<CadProjeto>();
        }

        public int IDCLIENTE { get; set; }
        [Required]
        [Display(Name = "CNPJ:")]
        [StringLength(18, MinimumLength = 14)]
        public string Cnpj { get; set; }
        [Required]
        [Display(Name = "Raz�o-Social:")]
        [StringLength(50)]
        public string RazaoSocial { get; set; }
        [Required]
        [Display(Name = "Telefone:")]

        [StringLength(13, MinimumLength = 9)]
        public string Telefone { get; set; }
        [Required]
        [Display(Name = "Endere�o:")]
        [StringLength(50)]
        public string Endereco { get; set; }
        [Required]
        [Display(Name = "E-Mail:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Ramo de Atividades:")]
        [StringLength(50)]
        public string RamoAtividades { get; set; }
        [Display(Name = "Complemento:")]
        [StringLength(30)]
        public string Complemento { get; set; }
        [Required]
        [Display(Name = "N�mero:")]
        [StringLength(5)]
        public string Numero { get; set; }
        [Required]
        [Display(Name = "CEP:")]
      
        public int Cep { get; set; }
        [Required]
        [Display(Name = "Cidade:")]
        [StringLength(20)]
        public string Cidade { get; set; }
        [Required]
        [Display(Name = "Bairro:")]
        [StringLength(20)]
        public string Bairro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CadProjeto> Projeto { get; set; }
    }
}
