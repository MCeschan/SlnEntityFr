using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        private static DBEscuelaEFContext context = new DBEscuelaEFContext();

        public static List<Alumno> SelectAll() //listar
        {
            return context.Alumnos.ToList();
        }
        public static Alumno SelectWhereById(int id) //traer una
        {
            return context.Alumnos.Find(id);
        }
        public static int Insert(Alumno alumno) //insertar
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();
        }
        public static int Update(Alumno alumno) //insertar
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            alumnoOrigen.Nombre = alumno.Nombre;
            return context.SaveChanges();
        }
        public static int Delete(Alumno alumno) //insertar
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges(); //retornar filas afectadas
            }
            return 0;
        }
    }
}
