using System;

namespace ClassLibrary1
{
    public class Persona
    {
        #region atributos privados
        // El atributo privado es el que se modifica cuando se aplican los constructores.
        // Se llamará al atributo privado cuando sea la misma clase la que vaya a utilizarlo.
        // por ejemplo para el calculo de la edad de alguien se utilizará la propiedad privada 
        //  fecha de naciminto
        private String Nombre;
        private int Edad;
        #endregion
        #region propiedades publicas
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; } 
        }
        #endregion

        #region Constructores
        //Constructor por defecto
        public Persona()
        {

        }
        //Constructor por parámetros
        public Persona(String nombre)
        {
            this.nombre = nombre;
        }
        #endregion




        // Añadir una propiedad nombre con su atributo privado nombre
    }
}
