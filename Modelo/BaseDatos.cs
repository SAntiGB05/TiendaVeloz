using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        public int GuardarEmpleado(int cedula_empleado, string nombre_empleado, string telefono_empleado, string rol_empleado, int pin_acceso)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO empleado (cedula_empleado,nombre_empleado,telefono_empleado,rol_empleado,pin_acceso) VALUES ('" + cedula_empleado + "','" + nombre_empleado + "','" + telefono_empleado + "','" + rol_empleado + "', '" + pin_acceso + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<EmpleadoEntity> MostrarEmpleado()
        {
            List<EmpleadoEntity> listaEmpleado = new List<EmpleadoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM empleado";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EmpleadoEntity empleado = new EmpleadoEntity
                {
                    Id = reader.GetInt32(0),
                    cedula_empleado = reader.GetInt32(1),
                    nombre_empleado = reader.GetString(2),
                    telefono_empleado = reader.GetString(3),
                    rol_empleado = reader.GetString(4),
                    pin_acceso = reader.GetInt32(5)
                };
                listaEmpleado.Add(empleado);
            }
            reader.Close();
            return listaEmpleado;
        }


        public bool ActualizarEmpleado(EmpleadoEntity empleadoActualizado)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE empleado SET nombre_empleado = @Nombre, telefono_empleado = @Telefono, rol_empleado = @Rol, pin_acceso = @Pin WHERE cedula_empleado = @Cedula";

                cmd.Parameters.AddWithValue("@Nombre", empleadoActualizado.nombre_empleado);
                cmd.Parameters.AddWithValue("@Telefono", empleadoActualizado.telefono_empleado);
                cmd.Parameters.AddWithValue("@Rol", empleadoActualizado.rol_empleado);
                cmd.Parameters.AddWithValue("@Pin", empleadoActualizado.pin_acceso);
                cmd.Parameters.AddWithValue("@Cedula", empleadoActualizado.cedula_empleado);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el empleado: " + ex.Message);
                return false;
            }
        }

        public bool EliminarEmpleado(int cedula_empleado)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "DELETE FROM empleado WHERE cedula_empleado = @Cedula";

                cmd.Parameters.AddWithValue("@Cedula", cedula_empleado);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el empleado: " + ex.Message);
                return false;
            }
        }
        public int GuardarProducto(string nombre_producto, int precio_producto, string descripcion_producto, int stock)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO productos (nombre_producto, precio_producto, descripcion_producto, stock) VALUES (@Nombre, @Precio, @Descripcion, @Stock)";
            
            cmd.Parameters.AddWithValue("@Nombre", nombre_producto);
            cmd.Parameters.AddWithValue("@Precio", precio_producto);
            cmd.Parameters.AddWithValue("@Descripcion", descripcion_producto);
            cmd.Parameters.AddWithValue("@Stock", stock);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas;
        }

        public List<ProductoEntity> MostrarProductos()
        {
            List<ProductoEntity> listaProductos = new List<ProductoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM productos";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ProductoEntity producto = new ProductoEntity
                {
                    cod_productos = reader.GetInt32(0),
                    nombre_producto = reader.GetString(1),
                    precio_producto = reader.GetInt32(2),
                    descripcion_producto = reader.GetString(3),
                    stock = reader.GetInt32(4)
                };
                listaProductos.Add(producto);
            }
            reader.Close();
            return listaProductos;
        }

        public bool ActualizarProducto(ProductoEntity productoActualizado)
        {
            try
            {
                MySqlCommand cmd = GetConnection().CreateCommand();
                cmd.CommandText = "UPDATE productos SET nombre_producto = @Nombre, precio_producto = @Precio, descripcion_producto = @Descripcion, stock = @Stock WHERE cod_productos = @Cod";

                cmd.Parameters.AddWithValue("@Cod", productoActualizado.cod_productos);
                cmd.Parameters.AddWithValue("@Nombre", productoActualizado.nombre_producto);
                cmd.Parameters.AddWithValue("@Precio", productoActualizado.precio_producto);
                cmd.Parameters.AddWithValue("@Descripcion", productoActualizado.descripcion_producto);
                cmd.Parameters.AddWithValue("@Stock", productoActualizado.stock);
                

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el producto: " + ex.Message);
                return false;
            }
        }

        public bool EliminarProducto(int cod_productos)
        {
            try
            {
                MySqlCommand cmd = GetConnection().CreateCommand();
                cmd.CommandText = "DELETE FROM productos WHERE cod_productos = @Cod";

                cmd.Parameters.AddWithValue("@Cod", cod_productos);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                return false;
            }
        }
        public int GuardarCliente(int cedula_nit_cliente, string nombre_cliente, string telefono_cliente)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO cliente (cedula_nit_cliente,nombre_cliente,telefono_cliente) VALUES ('" + cedula_nit_cliente + "','" + nombre_cliente + "','" + telefono_cliente + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<ClienteEntity> MostrarClientes()
        {
            List<ClienteEntity> listaClientes = new List<ClienteEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM cliente";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClienteEntity cliente = new ClienteEntity
                {
                    Id = reader.GetInt32(0),
                    cedula_nit_cliente = reader.GetInt32(1),
                    nombre_cliente = reader.GetString(2),
                    telefono_cliente = reader.GetString(3)
                };
                listaClientes.Add(cliente);
            }
            reader.Close();
            return listaClientes;
        }


        public bool ActualizarCliente(ClienteEntity clienteActualizado)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE cliente SET nombre_cliente = @Nombre, telefono_cliente = @Telefono WHERE cedula_nit_cliente = @Cedula";

                cmd.Parameters.AddWithValue("@Nombre", clienteActualizado.nombre_cliente);
                cmd.Parameters.AddWithValue("@Telefono", clienteActualizado.telefono_cliente);
                cmd.Parameters.AddWithValue("@Cedula", clienteActualizado.cedula_nit_cliente);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true; 
                }

                return false; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el cliente: " + ex.Message);
                return false;
            }
        }

        public bool EliminarCliente(int cedula_nit_cliente)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "DELETE FROM cliente WHERE cedula_nit_cliente = @Cedula";

                cmd.Parameters.AddWithValue("@Cedula", cedula_nit_cliente);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;  
                }

                return false; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                return false;
            }
        }

    }
}
