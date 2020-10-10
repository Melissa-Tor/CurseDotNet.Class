using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace CurseDotNet.Class2.Features.Clientes
{
    public class Clientes : Entity 
    { 
    public string PrimerNombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Identidad { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    }
}
