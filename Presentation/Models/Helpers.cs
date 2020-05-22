using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation
{
    public static class Helpers
    {
        public static IList<string> YesNoQuestion()
        {
            var list = new List<string>();
            list.Add("Si");
            list.Add("No");
            return list;
        }

        public static IList<string> TimeToHelp()
        {
            var list = new List<string>();
            list.Add("Todos los días (tiempo completo)");
            list.Add("Después de las 5pm");
            list.Add("Sábados y domingos");
            list.Add("2 días a la semana");
            return list;
        }

        public static IList<string> HelpNeeded()
        {
            var list = new List<string>();
            list.Add("No es urgente");
            list.Add("Puedo esperar");
            list.Add("En 6 días me quedaré sin alimento");
            list.Add("Es muy urgente");
            return list;
        }

        public static IList<string> HelpType()
        {
            var list = new List<string>();
            list.Add("Para mi");
            list.Add("Refiero");
            return list;
        }

        public static IList<string> ResidenceType()
        {
            var list = new List<string>();
            list.Add("Propia");
            list.Add("Alquilada");
            list.Add("Vive con familiares");
            list.Add("Cuarto en alquiler");
            list.Add("Ninguna de las anteriores");
            return list;
        }

        public static IList<string> HelpProfession()
        {
            var list = new List<string>();
            list.Add("Independiente");
            list.Add("Asalariado");
            list.Add("Doméstica");
            list.Add("Negocio Propio");
            return list;
        }
    }
}