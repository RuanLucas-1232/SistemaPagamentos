namespace SistemaDePagamentos
{
    public abstract class Pessoa
    {   public string nome { get; set; }
        public int idade { get; set; }
        public bool endereco { get; set; }
        public void PagarImposto(float Salario)
        {

        }
        
    }
}