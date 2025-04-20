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

        public int GuardarProveedor(int nit_proveedor, string nombre_proveedor, string direccion_proveedor, string telefono_proveedor)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO proveedor (nit_proveedor,nombre_proveedor,direccion_proveedor,telefono_proveedor) VALUES ('" + nit_proveedor + "','" + nombre_proveedor + "','" + direccion_proveedor + "','" + telefono_proveedor + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<ProveedorEntity> MostrarProveedor()
        {
            List<ProveedorEntity> listaProveedor = new List<ProveedorEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM proveedor";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ProveedorEntity proveedor = new ProveedorEntity
                {
                    Id = reader.GetInt32(0),
                    nit_proveedor = reader.GetInt32(1),
                    nombre_proveedor = reader.GetString(2),
                    direccion_proveedor = reader.GetString(3),
                    telefono_proveedor = reader.GetString(4)
                };
                listaProveedor.Add(proveedor);
            }
            reader.Close();
            return listaProveedor;
        }


        public bool ActualizarProveedor(ProveedorEntity proveedorActualizado)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "UPDATE proveedor SET nombre_proveedor = @Nombre, direccion_proveedor = @Direccion, telefono_proveedor = @Telefono WHERE nit_proveedor = @Cedula";

                cmd.Parameters.AddWithValue("@Nombre", proveedorActualizado.nombre_proveedor);
                cmd.Parameters.AddWithValue("@Direccion", proveedorActualizado.direccion_proveedor);
                cmd.Parameters.AddWithValue("@Telefono", proveedorActualizado.telefono_proveedor);
                cmd.Parameters.AddWithValue("@Cedula", proveedorActualizado.nit_proveedor);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el proveedor: " + ex.Message);
                return false;
            }
        }

        public bool EliminarProveedor(int nit_proveedor)
        {
            try
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "DELETE FROM proveedor WHERE nit_proveedor = @Cedula";

                cmd.Parameters.AddWithValue("@Cedula", nit_proveedor);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el proveedor: " + ex.Message);
                return false;
            }
        }
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

        // FACTURA CLIENTE
        // ========================

        public List<FacturaClienteEntity> MostrarFacturasCliente()
        {
            List<FacturaClienteEntity> lista = new();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura_cliente";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new FacturaClienteEntity
                {
                    cod_factura_cliente = reader.GetInt32(0),
                    FKid_cliente = reader.GetInt32(1),
                    FKid_empleado = reader.GetInt32(2),
                    fecha_fac_cliente = reader.GetDateTime(3)
                });
            }
            reader.Close();
            return lista;
        }

        public bool ActualizarFacturaCliente(FacturaClienteEntity factura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE factura_cliente SET FKid_cliente = @Cliente, FKid_empleado = @Empleado, fecha_fac_cliente = @Fecha WHERE cod_factura_cliente = @Cod";
            cmd.Parameters.AddWithValue("@Cliente", factura.FKid_cliente);
            cmd.Parameters.AddWithValue("@Empleado", factura.FKid_empleado);
            cmd.Parameters.AddWithValue("@Fecha", factura.fecha_fac_cliente);
            cmd.Parameters.AddWithValue("@Cod", factura.cod_factura_cliente);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool EliminarFacturaCliente(int codFactura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM factura_cliente WHERE cod_factura_cliente = @Cod";
            cmd.Parameters.AddWithValue("@Cod", codFactura);
            return cmd.ExecuteNonQuery() > 0;
        }

        // =========================
        // DETALLE FACTURA CLIENTE
        // =========================

        public List<DetalleFacturaClienteEntity> MostrarDetalleFacCliente()
        {
            List<DetalleFacturaClienteEntity> lista = new();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM detalle_fac_cliente";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new DetalleFacturaClienteEntity
                {
                    cod_detalle_fac_cliente = reader.GetInt32(0),
                    cantidad = reader.GetInt32(1),
                    precio_unitario = reader.GetDecimal(2),
                    precio_total = reader.GetDecimal(3),
                    FKcod_factura_cliente = reader.GetInt32(4),
                    FKcod_producto = reader.GetInt32(5)
                });
            }
            reader.Close();
            return lista;
        }

        public bool ActualizarDetalleFacCliente(DetalleFacturaClienteEntity detalle)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE detalle_fac_cliente SET cantidad = @Cant, precio_unitario = @Unit, precio_total = @Total, FKcod_factura_cliente = @FKFac, FKcod_producto = @FKProd WHERE cod_detalle_fac_cliente = @Cod";
            cmd.Parameters.AddWithValue("@Cant", detalle.cantidad);
            cmd.Parameters.AddWithValue("@Unit", detalle.precio_unitario);
            cmd.Parameters.AddWithValue("@Total", detalle.precio_total);
            cmd.Parameters.AddWithValue("@FKFac", detalle.FKcod_factura_cliente);
            cmd.Parameters.AddWithValue("@FKProd", detalle.FKcod_producto);
            cmd.Parameters.AddWithValue("@Cod", detalle.cod_detalle_fac_cliente);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool EliminarDetalleFacCliente(int codDetalle)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM detalle_fac_cliente WHERE cod_detalle_fac_cliente = @Cod";
            cmd.Parameters.AddWithValue("@Cod", codDetalle);
            return cmd.ExecuteNonQuery() > 0;
        }

        public int GuardarFacturaClienteConDetalles(int FKid_cliente, int FKid_empleado, DateTime fecha, List<DetalleFacturaClienteEntity> detalles)
        {
            // Validaciones iniciales
            if (FKid_cliente <= 0 || FKid_empleado <= 0)
                throw new ArgumentException("IDs de cliente o empleado inválidos");

            if (detalles == null || detalles.Count == 0)
                throw new ArgumentException("Debe especificar al menos un detalle de factura");

            using (var connection = GetConnection())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // 1. Guardar la factura cliente
                    int idFactura;
                    using (var cmd = connection.CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = @"INSERT INTO factura_cliente 
                          (FKid_cliente, FKid_empleado, fecha_fac_cliente) 
                          VALUES (@Cliente, @Empleado, @Fecha);
                          SELECT LAST_INSERT_ID();";

                        cmd.Parameters.AddWithValue("@Cliente", FKid_cliente);
                        cmd.Parameters.AddWithValue("@Empleado", FKid_empleado);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);

                        idFactura = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Guardar los detalles asociados
                    foreach (var detalle in detalles)
                    {
                        // Validar detalle
                        if (detalle.cantidad <= 0 || detalle.precio_unitario <= 0)
                            throw new ArgumentException("Cantidad y precio deben ser mayores a cero");

                        detalle.FKcod_factura_cliente = idFactura;
                        detalle.precio_total = detalle.cantidad * detalle.precio_unitario;

                        // Verificar stock antes de actualizar
                        int stockActual = ObtenerStockProducto(connection, transaction, detalle.FKcod_producto);
                        if (stockActual < detalle.cantidad)
                        {
                            throw new InvalidOperationException(
                                $"Stock insuficiente para el producto ID {detalle.FKcod_producto}. " +
                                $"Stock actual: {stockActual}, solicitado: {detalle.cantidad}");
                        }

                        using (var cmd = connection.CreateCommand())
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = @"INSERT INTO detalle_fac_cliente 
                              (cantidad, precio_unitario, precio_total, FKcod_factura_cliente, FKcod_producto) 
                              VALUES (@Cant, @Unit, @Total, @FKFac, @FKProd)";

                            cmd.Parameters.AddWithValue("@Cant", detalle.cantidad);
                            cmd.Parameters.AddWithValue("@Unit", detalle.precio_unitario);
                            cmd.Parameters.AddWithValue("@Total", detalle.precio_total);
                            cmd.Parameters.AddWithValue("@FKFac", detalle.FKcod_factura_cliente);
                            cmd.Parameters.AddWithValue("@FKProd", detalle.FKcod_producto);

                            cmd.ExecuteNonQuery();
                        }

                        // Actualizar stock
                        using (var cmd = connection.CreateCommand())
                        {
                            cmd.Transaction = transaction;
                            cmd.CommandText = "UPDATE productos SET stock = stock - @Cant WHERE cod_productos = @Cod";
                            cmd.Parameters.AddWithValue("@Cant", detalle.cantidad);
                            cmd.Parameters.AddWithValue("@Cod", detalle.FKcod_producto);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return idFactura;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    // Loggear el error adecuadamente
                    throw new Exception("Error al guardar factura de cliente. Ver inner exception para detalles.", ex);
                }
            }
        }

        private int ObtenerStockProducto(MySqlConnection connection, MySqlTransaction transaction, int idProducto)
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.Transaction = transaction;
                cmd.CommandText = "SELECT stock FROM productos WHERE cod_productos = @Id";
                cmd.Parameters.AddWithValue("@Id", idProducto);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // =========================
        // FACTURA PROVEEDOR
        // =========================

        public List<FacturaProveedorEntity> MostrarFacturasProveedor()
        {
            List<FacturaProveedorEntity> lista = new();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura_proveedor";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new FacturaProveedorEntity
                {
                    cod_factura_proveedor = reader.GetInt32(0),
                    FKcod_proveedor = reader.GetInt32(1),
                    fecha_fac_proveedor = reader.GetDateTime(2)
                });
            }
            reader.Close();
            return lista;
        }

        public bool ActualizarFacturaProveedor(FacturaProveedorEntity factura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE factura_proveedor SET FKcod_proveedor = @Proveedor, fecha_fac_proveedor = @Fecha WHERE cod_factura_proveedor = @Cod";
            cmd.Parameters.AddWithValue("@Proveedor", factura.FKcod_proveedor);
            cmd.Parameters.AddWithValue("@Fecha", factura.fecha_fac_proveedor);
            cmd.Parameters.AddWithValue("@Cod", factura.cod_factura_proveedor);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool EliminarFacturaProveedor(int codFactura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM factura_proveedor WHERE cod_factura_proveedor = @Cod";
            cmd.Parameters.AddWithValue("@Cod", codFactura);
            return cmd.ExecuteNonQuery() > 0;
        }

        // =========================
        // DETALLE FACTURA PROVEEDOR
        // =========================

        public List<DetalleFacturaProveedorEntity> MostrarDetalleFacProveedor()
        {
            List<DetalleFacturaProveedorEntity> lista = new();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM detalle_fac_proveedor";
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new DetalleFacturaProveedorEntity
                {
                    cod_detalle_fac_proveedor = reader.GetInt32(0),
                    cantidad = reader.GetInt32(1),
                    precio_unitario = reader.GetDecimal(2),
                    precio_total = reader.GetDecimal(3),
                    FKcod_factura_proveedor = reader.GetInt32(5),
                    FKcod_producto = reader.GetInt32(6)
                });
            }
            reader.Close();
            return lista;
        }

        public bool ActualizarDetalleFacProveedor(DetalleFacturaProveedorEntity detalle)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE detalle_fac_proveedor SET cantidad = @Cant, precio_unitario = @Unit, precio_total = @Total, FKcod_factura_proveedor = @FKFac, FKcod_producto = @FKProd WHERE cod_detalle_fac_proveedor = @Cod";
            cmd.Parameters.AddWithValue("@Cant", detalle.cantidad);
            cmd.Parameters.AddWithValue("@Unit", detalle.precio_unitario);
            cmd.Parameters.AddWithValue("@Total", detalle.precio_total);
            cmd.Parameters.AddWithValue("@FKFac", detalle.FKcod_factura_proveedor);
            cmd.Parameters.AddWithValue("@FKProd", detalle.FKcod_producto);
            cmd.Parameters.AddWithValue("@Cod", detalle.cod_detalle_fac_proveedor);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool EliminarDetalleFacProveedor(int codDetalle)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM detalle_fac_proveedor WHERE cod_detalle_fac_proveedor = @Cod";
            cmd.Parameters.AddWithValue("@Cod", codDetalle);
            return cmd.ExecuteNonQuery() > 0;
        }

        // Método para guardar factura con transacción
        public int GuardarFacturaProveedorConDetalles(int FKcod_proveedor, DateTime fecha, List<DetalleFacturaProveedorEntity> detalles)
        {
            using (var transaction = GetConnection().BeginTransaction())
            {
                try
                {
                    // 1. Guardar factura
                    MySqlCommand cmd = GetConnection().CreateCommand();
                    cmd.Transaction = transaction;
                    cmd.CommandText = "INSERT INTO factura_proveedor (FKcod_proveedor, fecha_fac_proveedor) VALUES (@Proveedor, @Fecha); SELECT LAST_INSERT_ID();";
                    cmd.Parameters.AddWithValue("@Proveedor", FKcod_proveedor);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    int idFactura = Convert.ToInt32(cmd.ExecuteScalar());

                    // 2. Guardar detalles
                    foreach (var detalle in detalles)
                    {
                        detalle.FKcod_factura_proveedor = idFactura;
                        detalle.precio_total = detalle.cantidad * detalle.precio_unitario; // Cálculo automático

                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO detalle_fac_proveedor (cantidad, precio_unitario, precio_total, FKcod_factura_proveedor, FKcod_producto) " +
                                         "VALUES (@Cant, @Unit, @Total, @FKFac, @FKProd)";
                        cmd.Parameters.AddWithValue("@Cant", detalle.cantidad);
                        cmd.Parameters.AddWithValue("@Unit", detalle.precio_unitario);
                        cmd.Parameters.AddWithValue("@Total", detalle.precio_total);
                        cmd.Parameters.AddWithValue("@FKFac", detalle.FKcod_factura_proveedor);
                        cmd.Parameters.AddWithValue("@FKProd", detalle.FKcod_producto);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return idFactura;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Error en transacción: " + ex.Message);
                    return -1;
                }
            }
        }

    }
}
