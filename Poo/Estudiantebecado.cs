using System;
using System.Collections.Generic;
using System.Text;

namespace Poo
{
    public class Estudiantebecado
    {
        public string TipoBeca { get; set; }

        //Constructor con parámetros
        public Estudiantebecado(string nombre, int edad, string carrera, string tipoBeca) : base(nombre, edad, carrera)
        {
            TipoBeca = tipoBeca;
        }

        //Polifismo: redefinimos MostrarInfo
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante Becado: {this.GetNombre()}, Edad: {Edad}, Carrera: {this.GetCarrera}, Beca: {this.TipoBeca}");
        }

        //Polifismo: redefinimos otra vez

        public override decimal CalcularPago()
        {
            decimal pagoBase = base.CalcularPago();
            {
                decimal pagoBase = base.CalcularPag0()
                    return pagoBaseBase * 0.5m; //paga la mitad por ser becado
            }
            
        }
    }
}
