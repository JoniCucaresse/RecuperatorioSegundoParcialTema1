using RecuperatorioSegundoParcialTema1.Entidades;

namespace RecuperatorioSegundoParcialTema1.Datos
{ 


    public class RepositorioDeHexagonos

    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Hexagonos.txt";
        private List<Hexagono> hexagonos;
        public RepositorioDeHexagonos()
        {
            hexagonos = new List<Hexagono>();
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            if (File.Exists(_archivo))
            {
                using (var lector = new StreamReader(_archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        var lineaLeida = lector.ReadLine();
                        var hexagono = ConstruirHexagono(lineaLeida);
                        hexagonos.Add(hexagono);
                    }
                }

            }
        }
        public List<Hexagono> GetLista() => hexagonos;
        private Hexagono ConstruirHexagono(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            var ladoHexagono = int.Parse(campos[0]);
            var rellenoHexagono = (Relleno)int.Parse(campos[1]);
            return new Hexagono
            {
                Lado = ladoHexagono,
                Relleno = rellenoHexagono
            };
        }

        public void Agregar(Hexagono hexagono)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstuirLinea(hexagono);
                escritor.WriteLine(lineaEscribir);
            }
        }

        private string ConstuirLinea(Hexagono hexagono)
        {
            return $"{hexagono.Lado}|{hexagono.Relleno.GetHashCode()}";
        }

        public void Borrar(Hexagono hexagono) { }

    }

}
