using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar_Domain.Entities
{
    public class Cities
    {
        public Guid Id { get; init; }
        public string NameCity { get; private set; }
        public string StateName { get; private set; }
        public Cities(string nameCity, string stateName)
        {
            Id = Guid.NewGuid();
            NameCity = nameCity;
            StateName = stateName;
        }
    }
}
