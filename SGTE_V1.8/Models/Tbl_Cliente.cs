//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGTE_V1._8.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Cliente
    {
        public Tbl_Cliente()
        {
            this.Tbl_Aluno = new HashSet<Tbl_Aluno>();
            this.Tbl_Login = new HashSet<Tbl_Login>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public System.DateTime Data_Nasc { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Nullable<int> Ativo { get; set; }
    
        public virtual ICollection<Tbl_Aluno> Tbl_Aluno { get; set; }
        public virtual ICollection<Tbl_Login> Tbl_Login { get; set; }
    }
}