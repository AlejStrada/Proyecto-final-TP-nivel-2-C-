using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesoDatos;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Codigo,Nombre,A.Descripcion Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria IdCategoria, A.IdMarca IdMarca, A.Id Id From ARTICULOS A , CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id=A.IdMarca");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                   Articulo aux = new Articulo();

                   if (!(datos.Lector["ImagenUrl"] is DBNull))
                   aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                   
                  aux.Codigo = (string)datos.Lector["Codigo"];
                  aux.Nombre = (string)datos.Lector["Nombre"];
                  aux.Descripcion = (string)datos.Lector["Descripcion"];
                  aux.Precio = (decimal)datos.Lector["Precio"];
                  aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                  aux.IdMarca = (int)datos.Lector["IdMarca"];
                  aux.Marca = new Marca();
                  aux.Marca.Id = (int)datos.Lector["IdMarca"];
                  aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                  aux.Categoria = new Categoria();
                  aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                  aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                  aux.Id = (int)datos.Lector["Id"];

                 lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                datos.cerrarConexion();
            }
        }
        public List<Articulo> filtroPrecios(string rangoPrecios, string filtroPrecios)
        {
            try
            {
                List<Articulo> listaFiltro = new List<Articulo>();
                AccesoDatos datos = new AccesoDatos();
                string consulta = "Select Codigo,Nombre,A.Descripcion Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdCategoria IdCategoria, A.IdMarca IdMarca, A.Id Id From ARTICULOS A , CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id=A.IdMarca and ";
                switch (rangoPrecios)
                {
                    case "Mayor a":
                        consulta += "Precio > " ;
                        break;

                    case "Menor a":
                        consulta += "Precio < " ;
                       break;

                    case "Igual a":
                        consulta += "Precio = " ;
                       break;                                      
                }

                consulta += filtroPrecios;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Id = (int)datos.Lector["Id"];

                    listaFiltro.Add(aux);
                }

                return listaFiltro;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void agregarArticulo(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre,@descripcion, @idMarca, @idCategoria, @urlImagen, @precio)");
                datos.setearParametro("@codigo", nuevoArticulo.Codigo);
                datos.setearParametro("@nombre", nuevoArticulo.Nombre);
                datos.setearParametro("@descripcion", nuevoArticulo.Descripcion);
                datos.setearParametro("@idMarca", nuevoArticulo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@urlImagen", nuevoArticulo.ImagenUrl);
                datos.setearParametro("@precio", nuevoArticulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
         finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificarArticulo(Articulo modificarArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria= @idCategoria, ImagenUrl = @urlImagen, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificarArticulo.Codigo);
                datos.setearParametro("@nombre", modificarArticulo.Nombre);
                datos.setearParametro("@descripcion", modificarArticulo.Descripcion);
                datos.setearParametro("@idMarca", modificarArticulo.Marca.Id);
                datos.setearParametro("@idCategoria", modificarArticulo.Categoria.Id);
                datos.setearParametro("@urlImagen", modificarArticulo.ImagenUrl);
                datos.setearParametro("@precio", modificarArticulo.Precio);
                datos.setearParametro("@id", modificarArticulo.Id);
                datos.ejecutarAccion();
                                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
 
     
     
}


    

