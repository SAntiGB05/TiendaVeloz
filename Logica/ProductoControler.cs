using System;
using System.Collections.Generic;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class ProductoControler
    {
        public string GuardarProducto(string nombre_producto, int precio_producto, string descripcion_producto, int stock)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarProducto(nombre_producto, precio_producto, descripcion_producto, stock);

            if (filasInsertadas > 0)
            {
                resultado = "Producto Guardado";
            }
            else
            {
                resultado = "No se pudo guardar el producto";
            }
            return resultado;
        }

        public List<ProductoEntity> MostrarProductos()
        {
            BaseDatos db = new BaseDatos();
            return db.MostrarProductos();
        }

        public string ActualizarProducto(ProductoEntity productoActualizado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool productoActualizadoExitosamente = db.ActualizarProducto(productoActualizado);

            if (productoActualizadoExitosamente)
            {
                resultado = "Producto Actualizado";
            }
            else
            {
                resultado = "No se pudo actualizar el producto";
            }

            return resultado;
        }

        public string EliminarProducto(int cod_producto)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            bool productoEliminado = db.EliminarProducto(cod_producto);

            if (productoEliminado)
            {
                resultado = "Producto Eliminado";
            }
            else
            {
                resultado = "No se pudo eliminar el producto";
            }

            return resultado;
        }
    }
}
