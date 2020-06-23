namespace Aula23
{
    public class Cartao
    {
        public int Codigo { get; set; }
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public string Vencimento { get; set; }
        public string CVV { get; set; }

        public Cartao()
        {

        }

        public Cartao(int _codigo, string _titular, int _numero, string _bandeira, string _vencmento, string _cvv){
            this.Codigo = _codigo;
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencmento;
            this.CVV = _cvv;
        }

    }
}