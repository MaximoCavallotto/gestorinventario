﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

                 
            try
            {
                
                datos.setearConsulta("select A.Id, A.Codigo, M.Descripcion as Marca, Nombre as Modelo, C.Descripcion as Categoria, A.Descripcion, ImagenUrl, Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria and M.Id = A.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Modelo = (string)datos.Lector["Modelo"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.PrecioFormateado = convmoneda((decimal)datos.Lector["Precio"]);
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    
                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {datos.cerrarConexion();}
            return lista;
        }

        public void agregarArticulo (Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo.ToString());
                datos.setearParametro("@Nombre", nuevo.Modelo.ToString());
                datos.setearParametro("@Descripcion", nuevo.Descripcion.ToString());
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen.ToString());
                datos.setearParametro("@Precio", nuevo.Precio.ToString());
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



        public string convmoneda(decimal aux)
        {
         return String.Format(CultureInfo.CreateSpecificCulture("es-AR"), "{0:00.00}", aux);
        }

        public void modificar(Articulo articulo)
        { 
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set  Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagenurl, Precio = @precio where Id=@id");

                
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Modelo);
                datos.setearParametro("@desc", articulo.Descripcion);
                datos.setearParametro("@idmarca", articulo.Marca.Id);
                datos.setearParametro("@idcategoria", articulo.Categoria.Id);
                datos.setearParametro("@imagenurl", articulo.UrlImagen);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);

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
