using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    namespace AnCo
    {
        public class Bo
        {
            public string Id {  get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public Bo(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Trau
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public Trau(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class De
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public De(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }
    }

    namespace AnThit
    {
        public class CaSau
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public CaSau(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Ho
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public Ho(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class SuTu
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Weight { get; set; }

            public SuTu(string id, string name, string weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }
    }
}
