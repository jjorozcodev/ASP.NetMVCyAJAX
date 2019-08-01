using System;
using System.Collections.Generic;

namespace AjaxCRUDaspNetMVC.Models
{
    public static class GestorDatos
    {
        private static List<LenguajeProgramacion> listaLengProg = new List<LenguajeProgramacion>();
        private static Random random = new Random();

        static GestorDatos()
        {
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Visual Basic .Net",
                Tipado = "Dinámico",
                Aparicion = 2001,
                Extension = ".vb",
                Creador = "Microsoft"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Python",
                Tipado = "Fuerte",
                Aparicion = 1991,
                Extension = ".py",
                Creador = "Guido Van Rossum"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Java",
                Tipado = "Fuerte",
                Aparicion = 1996,
                Extension = ".java",
                Creador = "James Gosling"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "C Sharp",
                Tipado = "Dinámico",
                Aparicion = 2000,
                Extension = ".cs",
                Creador = "Microsoft"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Javascript",
                Tipado = "Débil",
                Aparicion = 1995,
                Extension = ".py",
                Creador = "Brendan Eich"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Perl",
                Tipado = "Dinámico",
                Aparicion = 1987,
                Extension = ".pl",
                Creador = "Larry Wall"
            });
            listaLengProg.Add(new LenguajeProgramacion()
            {
                Id = random.Next(1, 100),
                Nombre = "Ruby",
                Tipado = "Fuerte",
                Aparicion = 1995,
                Extension = ".rb",
                Creador = "Yukihiro Matsumoto"
            });
        }

        public static List<LenguajeProgramacion> ObtenerLista()
        {
            return listaLengProg;
        }

        public static void AgregarElemento(LenguajeProgramacion lengProg)
        {
            lengProg.Id = random.Next(1, 100);
            listaLengProg.Add(lengProg);
        }

        public static void EditarElemento(LenguajeProgramacion lenguaje)
        {
            LenguajeProgramacion lp = listaLengProg.Find(l => l.Id == lenguaje.Id);
            lp.Creador = lenguaje.Creador;
            lp.Aparicion = lenguaje.Aparicion;
            lp.Nombre = lenguaje.Nombre;
            lp.Tipado = lenguaje.Tipado;
            lp.Extension = lenguaje.Extension;
        }

        public static void BorrarElemento(int id)
        {
            LenguajeProgramacion lp = listaLengProg.Find(l => l.Id == id);
            listaLengProg.Remove(lp);
        }

    }
}