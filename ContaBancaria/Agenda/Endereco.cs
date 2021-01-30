using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    public class Endereco
    {
        public int IdAddress { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }

        public void Incluir(int idAddrees,string street,string zipCode,string neighborhood,
            string city,string state,string number,string complement)
        {
            IdAddress = idAddrees;
            Street = street;
            ZipCode = zipCode;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Number = number;
            Complement = complement;

        }
    }
}
