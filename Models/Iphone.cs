namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" --------Ok
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" --------Ok
        public override void InstalarAplicativo(string nomeApp)
        {
            throw new NotImplementedException();
        }
    }
}