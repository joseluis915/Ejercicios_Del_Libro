using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ejercicios_Del_Libro.Entidades
{
    public class Poligonos
    {
        private static double lado = 0;
        private static double radio = 0;
        private static double anguloCentral = 0;
        private static double apotema = 0;
        private static double circunferenciaCircunscrita = 0;
        private static double circunferenciaInscrita = 0;
        //——————————————————————————————————————————————————[ EJERCICIO #3 ]——————————————————————————————————————————————————
        public Poligonos(double _lado, double _radio, double _anguloCentral, double _apotema)
        {
            Lado = _lado;
            Radio = _radio;
            AnguloCentral = _anguloCentral;
            Apotema = _apotema;
        }
        //——————————————————————————————[ Sobrecarga ]——————————————————————————————
        public Poligonos(double _lado, double _radio, double _anguloCentral, double _apotema, double _circunferenciaCircunscrita, double _circunferenciaInscrita)
        {
            Lado = _lado;
            Radio = _radio;
            AnguloCentral = _anguloCentral;
            Apotema = _apotema;
            CircunferenciaCircunscrita = _circunferenciaCircunscrita;
            CircunferenciaInscrita = _circunferenciaInscrita;
        }
        //——————————————————————————————————————————————————[ EJERCICIO #4 ]——————————————————————————————————————————————————
        public double Lado
        {
            get
            { return lado; }

            set
            {
                string var = lado.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    lado = 0;

                lado = value;
            }
        }
        //——————————————————————————————[ Radio ]——————————————————————————————
        public double Radio
        {
            get
            { return radio; }

            set
            {
                string var = radio.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    radio = 0;

                radio = value;
            }
        }
        //——————————————————————————————[Angulo Central ]——————————————————————————————
        public double AnguloCentral
        {
            get
            { return anguloCentral; }

            set
            {
                string var = anguloCentral.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    anguloCentral = 0;

                anguloCentral = value;
            }
        }
        //——————————————————————————————[ Apotema ]——————————————————————————————
        public double Apotema
        {
            get
            { return apotema; }

            set
            {
                string var = apotema.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    apotema = 0;

                apotema = value;
            }
        }
        //——————————————————————————————[ Circunferencia Circunscrita]——————————————————————————————
        public double CircunferenciaCircunscrita
        {
            get
            { return circunferenciaCircunscrita; }

            set
            {
                string var = circunferenciaCircunscrita.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    circunferenciaCircunscrita = 0;

                circunferenciaCircunscrita = value;
            }
        }
        //——————————————————————————————[ Circuncunferencia Inscrita ]——————————————————————————————
        public double CircunferenciaInscrita
        {
            get
            { return circunferenciaInscrita; }

            set
            {
                string var = circunferenciaInscrita.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    circunferenciaInscrita = 0;

                circunferenciaInscrita = value;
            }
        }
        //——————————————————————————————————————————————————[ EJERCICIO #5 ]——————————————————————————————————————————————————
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Lados: {lado}\nRadio: {radio}\nAngulo Central {anguloCentral}\nApotema: {apotema}\n" + "Circunferencia Circunscrita: {circunferenciaCircunscrita}\nCircunferencia Inscrita: {circunferenciaInscrita}");

            return (stringBuilder.ToString());
        }
    }
}
//—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————