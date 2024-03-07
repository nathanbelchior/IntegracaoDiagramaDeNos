using static IntegracaoDiagramaDeNos.ViewModel.HomeViewModel;
using static System.Formats.Asn1.AsnWriter;

namespace IntegracaoDiagramaDeNos.ViewModel
{
    public class HomeViewModel
    {
        public List<Investigado> investigados { get; set; }
        public class Investigado
        {
            public int Id { get; set; }
            public string? label { get; set; }
            public string? color { get; set; }
            public int? origem { get; set; }
            public int? destino { get; set; }
        }
        public HomeViewModel()
        {
            investigados = new();
        }

        public void teste()
        {
            var t = new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var item in t)
            {
                var investigado = new Investigado();

                investigado.Id = item;
                switch (item)
                {
                    case 1:
                        investigado.label = "Fabricio";
                        investigado.color = "SaddleBrown";
                        investigado.origem = item;
                        investigado.destino = 2;
                        break;
                    case 2:
                        investigado.label = "Felipe";
                        investigado.color = "DarkGreen";
                        investigado.origem = item;
                        investigado.destino = 3;
                        break;
                    case 3:
                        investigado.label = "Guilherme Henrique";
                        investigado.color = "DarkCyan";
                        investigado.origem = item;
                        investigado.destino = 4;
                        break;
                    case 4:
                        investigado.label = "Nathan";
                        investigado.color = "MidnightBlue";
                        investigado.origem = item;
                        investigado.destino = 5;
                        break;
                    case 5:
                        investigado.label = "Wallace";
                        investigado.color = "SlateBlue";
                        investigado.origem = item;
                        investigado.destino = 1;
                        break;

                    default:
                        break;
                }

                investigados.Add(investigado);
            }
        }
    }
}
