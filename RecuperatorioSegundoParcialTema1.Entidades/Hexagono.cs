using System.Security.Cryptography.X509Certificates;

namespace RecuperatorioSegundoParcialTema1.Entidades
{
    public class Hexagono
    {
        public int Lado { get; set; }
        public Relleno Relleno { get; set; }
        public int GetPerimetro() => 6 * Lado;
        public int GetArea() => ((6 * Lado) * Apotema) / 2;
        public int Apotema => (int)Math.Sqrt(Math.Pow(Lado, 2) - Math.Pow((Lado / 2), 2));


    }
}
