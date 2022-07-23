using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Grupo1Animaciones.Modelo;
using Grupo1Animaciones.Conexiones;
namespace Grupo1Animaciones.Datos
{
    public class Dproductos
    {
        public async Task <List<Mproductos>>Mostrarproductos()
        {
            return (await Cconexion.firebase
                .Child("Productos")
                .OnceAsync<Mproductos>()).Select(item => new Mproductos
                {
                    Descripcion = item.Object.Descripcion,
                    Icono = item.Object.Icono,
                    Precio = item.Object.Precio,
                    calificacion = item.Object.calificacion,
                    Idproducto = item.Key
                }).ToList();
        }
        public async Task<List<Mproductos>> MostrarproductosXid(Mproductos parametros)
        {
            return (await Cconexion.firebase
                .Child("Productos")
                .OnceAsync<Mproductos>())
                .Where(a=>a.Key== parametros.Idproducto).Select(item => new Mproductos
                {
                    Descripcion = item.Object.Descripcion,
                    Icono = item.Object.Icono,
                    Precio = item.Object.Precio,
                    calificacion = item.Object.calificacion,
                    Idproducto = item.Key
                }).ToList();
        }
    }
}
