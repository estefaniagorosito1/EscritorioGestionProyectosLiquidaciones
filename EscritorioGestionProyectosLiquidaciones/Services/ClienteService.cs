using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    public class ClienteService
    {
        public void Guardar(Cliente cliente)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                if (cliente.Idcliente != 0)
                {
                    dbContext.Update(cliente);
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.Cliente.Add(cliente);
                    dbContext.SaveChanges();
                }
            }
        }

        public List<Cliente> Find()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var clientes = dbContext.Cliente.ToList();
                return clientes;
            }
        }

        public Cliente FindCliente(int idCliente)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Cliente.Find(idCliente);
            }
        }

        public void Eliminar(int idCliente)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var cliente = dbContext.Cliente.Find(idCliente);

                dbContext.Cliente.Remove(cliente);
                dbContext.SaveChanges();
            }
        }
    }
}
