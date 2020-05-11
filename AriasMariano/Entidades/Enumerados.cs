using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EParentesco
    {
        Madre, 
        Padre, 
        Tia, 
        Tio, 
        Abuela, 
        Abuelo, 
        Otro
    }

    public enum Eturno
    {
        Mañana, 
        Tarde
    }

    public enum EColores
    {
        Naranja=1,
        Rojo, 
        Amarilla, 
        Verde
    }

    public enum ECargo
    {
        Porteria = 100,
        Cocina = 110,
        Secretaria = 140,
        Tesoreria = 240,
        Direccion = 180
    }
}
