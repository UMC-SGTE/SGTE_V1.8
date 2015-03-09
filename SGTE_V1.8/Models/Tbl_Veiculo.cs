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
    
    public partial class Tbl_Veiculo
    {
        public Tbl_Veiculo()
        {
            this.Tbl_Aluno = new HashSet<Tbl_Aluno>();
            this.Tbl_Motorista = new HashSet<Tbl_Motorista>();
            this.Tbl_Veiculo1 = new HashSet<Tbl_Veiculo>();
            this.Tbl_Viagem = new HashSet<Tbl_Viagem>();
        }
    
        public int ID { get; set; }
        public int Cod_Veiculo { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Renavam { get; set; }
        public string Cidade { get; set; }
        public string Licenca { get; set; }
        public string Chassi { get; set; }
        public string Ano_Fabricacao { get; set; }
        public int Num_Lugares { get; set; }
        public int Lugares_Vagos { get; set; }
        public string UF { get; set; }
        public Nullable<int> Ativo { get; set; }
        public string Status { get; set; }
        public Nullable<int> Escola_ID { get; set; }
        public Nullable<int> Motorista_ID { get; set; }
    
        public virtual ICollection<Tbl_Aluno> Tbl_Aluno { get; set; }
        public virtual Tbl_Escola Tbl_Escola { get; set; }
        public virtual ICollection<Tbl_Motorista> Tbl_Motorista { get; set; }
        public virtual ICollection<Tbl_Veiculo> Tbl_Veiculo1 { get; set; }
        public virtual Tbl_Veiculo Tbl_Veiculo2 { get; set; }
        public virtual ICollection<Tbl_Viagem> Tbl_Viagem { get; set; }
    }
}
