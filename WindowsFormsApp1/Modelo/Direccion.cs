//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direccion
    {
        public int IdDireccion { get; set; }
        public string EstadoC { get; set; }
        public string DelegacionM { get; set; }
        public string Colonia { get; set; }
        public string CalleN { get; set; }
        public int IdUsuraio { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
