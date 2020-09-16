using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Composicion
{
    public class Motor
    {
        public Motor()
        {
            
        }
    }

    public class Rueda
    {
        public Rueda()
        {
            
        }
    }

    public class Vehiculo
    {
        private Motor MotorDeVehiculo;
        public Rueda Ruedas { get; set; }
        public Vehiculo(Rueda Ruedas)
        {
            this.Ruedas = Ruedas; // Agregación 
            MotorDeVehiculo = new Motor();// Composición 
        }      
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rueda Fate = new Rueda();
            Vehiculo Ford = new Vehiculo(Fate);         
        }
    }
}
