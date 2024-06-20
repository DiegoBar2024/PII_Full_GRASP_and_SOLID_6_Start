using System;

namespace Full_GRASP_And_SOLID
{
    // Creo una clase Singleton
    public class Singleton
    {
        // Creo un atributo privado en donde guardo la instancia Singleton
        private static Singleton instance;

        // Creo el constructor privado de la clase
        private Singleton()
        {
        }

        // Creo el método estático el cual me cree el objeto Singleton
        public static Singleton getInstance()
        {
            // En caso que sea la primera vez que se ejecuta el método, que me cree una nueva instancia
            if (instance == null)
            {
                // Creo una nueva instancia llamando al constructor privado
                Singleton.instance = new Singleton();
            }

            // En otro caso, que me retorne la misma instancia
            return Singleton.instance;
        }
    }
}