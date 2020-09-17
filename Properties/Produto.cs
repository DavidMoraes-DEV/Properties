using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;//Atributos privativos
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string Nome // As propriedades são definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos.
        {
            get { return _nome; } //
            set
            {
                if (value != null && value.Length > 1) //Value utiliza o parâmetro que será utilizado na operação da propriedade sem a necessidade de declarar uma variável para receber o parâmetro de entrada da operação
                {
                    _nome = value;
                }
            }
        }
        public double Preco //Propriedade para retornar o valor de _preco
        {
            get { return _preco; }
        }
        public int Quantidade //Propriedade para retornar o valor de _quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}