using SalaoT2.Dominio;

namespace SalaoT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var meusClientes = IncluirMeusClientes();

            meusClientes.AlterarUmCliente(1, "Diego", "199999999");
            meusClientes.ExcluirUmCliente(2);

        }

        static MinhaBaseClientes IncluirMeusClientes()
        {
            Cliente c1 = new Cliente();
            c1.Incluir(1, "Thamirys", "999999999", "12345678901");

            Cliente c2 = new Cliente();
            c2.Incluir(2, "Thaise", "999999998", "12345678902");

            MinhaBaseClientes mc = new MinhaBaseClientes();
            mc.Incluir(c1);
            mc.Incluir(c2);

            var c3 = new Cliente();
            c3.Incluir(3, "Maria", "999999997", "12345678903");

            var c4 = new Cliente();
            c4.Incluir(4, "Joana", "999999996", "12345678904");

            mc.IncluirLista(c3, c4);

            return mc;
        }
    }
}
