using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models.Entity
{
    [Table("TB_Venda")]
    public class Venda
    {
        [Key]
        public int ID { get; private set; }
        public List<Produto> Produtos { get; private set; }
        public StatusVenda StatusVenda { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Vendedor Vendedor { get; private set; }
    }
}
