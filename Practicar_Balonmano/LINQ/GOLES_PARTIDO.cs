//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practicar_Balonmano.LINQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class GOLES_PARTIDO
    {
        public int Id_goles_partido { get; set; }
        public int Partido { get; set; }
        public string Jugador { get; set; }
        public int Num_goles { get; set; }
    
        public virtual JUGADORES JUGADORES { get; set; }
        public virtual PARTIDOS PARTIDOS { get; set; }
    }
}
