using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1_T1_EST
{
    class lista_prod
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        
        public double f_nac { get; set; }
        public lista_prod siguiente { get; set; }

        public lista_prod(int codigo, string nombre, double precio, int cantidad, double f_nac)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.f_nac = f_nac;
            siguiente = null;
        }

        public override string ToString()
        {
            string prod = "Código: " + codigo.ToString() +
                          Environment.NewLine + "Nombre: " + nombre +
                          Environment.NewLine + "Precio: $ " + precio.ToString() +
                          Environment.NewLine + "Cantidad: " + cantidad.ToString() + Environment.NewLine;
                          Environment.NewLine + "Fecha de vencimiento: " + f_nac.ToString();

            return prod;
        }
    }
}

