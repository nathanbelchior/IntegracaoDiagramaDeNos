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
                        break;
                    case 2:
                        investigado.label = "Felipe";
                        investigado.color = "DarkGreen";
                        break;
                    case 3:
                        investigado.label = "Guilherme";
                        investigado.color = "DarkCyan";
                        break;
                    case 4:
                        investigado.label = "Nathan";
                        investigado.color = "MidnightBlue";
                        break;
                    case 5:
                        investigado.label = "Wallace";
                        investigado.color = "SlateBlue";
                        break;

                    default:
                        break;
                }

                investigados.Add(investigado);
            }
        }
    }
}
