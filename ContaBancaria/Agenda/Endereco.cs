using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
