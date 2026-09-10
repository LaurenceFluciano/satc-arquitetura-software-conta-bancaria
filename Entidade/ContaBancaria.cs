using System;
using System.Collections.Generic;
using System.Text;

namespace Entidade
{
    public class ContaBancaria
    {
        public Guid Id { get; set; }
        public string Titular { get; set; }
        public string NumeroConta { get; set; }

        public EnumTipoConta TipoConta { get; set; }

        public enum EnumTipoConta
        {
            ContaCorrente = 0,
            ContaPoupanca = 1
        }
    }
}
