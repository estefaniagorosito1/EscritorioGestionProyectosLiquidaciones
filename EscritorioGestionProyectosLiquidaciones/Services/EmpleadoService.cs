using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class EmpleadoService
    {

        public List<Empleado> Find()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Empleado.ToList();
            }
        }

        public Empleado FindEmpleado(int IdEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Empleado.Find(IdEmpleado);
            }
        }

        public Empleado FindEmpleadoDni(long dni)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Empleado.Where(e => e.DniEmpleado == dni).FirstOrDefault();
            }
        }

        public void Guardar(Empleado empleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                if (empleado.Idempleado != 0)
                {
                    dbContext.Update(empleado);
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.Empleado.Add(empleado);
                    dbContext.SaveChanges();
                }

            }
        }

        public void Eliminar(int IdEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var empleado = dbContext.Empleado.Find(IdEmpleado);

                // Borro perfiles
                var perfiles = dbContext.PerfilEmpleado.Where(pe => pe.Idempleado == empleado.Idempleado).ToList();

                foreach (var item in perfiles)
                {
                    dbContext.PerfilEmpleado.Remove(item);
                }

                // Borro usuario
                var usuario = dbContext.Usuario.Where(us => us.Idempleado == empleado.Idempleado).First();
                dbContext.Usuario.Remove(usuario);

                dbContext.Empleado.Remove(empleado);
                dbContext.SaveChanges();
            }
        }
    }
}
