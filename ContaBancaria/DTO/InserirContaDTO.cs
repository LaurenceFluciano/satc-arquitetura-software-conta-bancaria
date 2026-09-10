namespace Apresentacao.DTO
{
    public class InserirContaDTO
    {
        public string Titular { get; set; }
        public string NumeroConta { get; set; }

        public Entidade.ContaBancaria.EnumTipoConta TipoConta { get; set; }

    }
}
