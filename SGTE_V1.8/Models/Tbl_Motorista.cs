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
    
    public partial class Tbl_Motorista
    {
        public Tbl_Motorista()
        {
            this.Tbl_Viagem = new HashSet<Tbl_Viagem>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNH { get; set; }
        public Nullable<int> Funcionario_ID { get; set; }
        public Nullable<int> Veiculo_ID { get; set; }
        public Nullable<int> Ativo { get; set; }
    
        public virtual Tbl_Funcionario Tbl_Funcionario { get; set; }
        public virtual Tbl_Veiculo Tbl_Veiculo { get; set; }
        public virtual ICollection<Tbl_Viagem> Tbl_Viagem { get; set; }
    }
}
