using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PjtInsertar_Eliminar_EditarYBuscar
{
    class clsDatabase
    {
        public static SqlConnection cnx = new SqlConnection(Properties.Settings.Default.Ruta);

        public static DataSet D;

        public static DataTable Mostrar()
        {

            SqlCommand cmd=new SqlCommand(string.Format("select * from Articulo"),cnx);

            try
            {
                cnx.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                D= new DataSet();
                DA.Fill(D, "Articulo");
                cnx.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { cnx.Close(); }

            return D.Tables["Articulo"];


        }
        public static void Insertar(Articulos A)
        {

            SqlCommand cmd = new SqlCommand(string.Format("insert into Articulo (Nombre, Precio) values ('{0}','{1}')",A.Nombre1,A.Precio1), cnx);
                
            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrado");
                cnx.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { cnx.Close(); }

            


        }
        public static void Eliminar(Articulos A)
        {

            SqlCommand cmd = new SqlCommand(string.Format("Delete from Articulo where idArticulo='{0}'", A.IdArticulo), cnx);
            
            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Eliminado");
                cnx.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { cnx.Close(); }




        }
        public static void Modificar(Articulos A)
        {

            SqlCommand cmd = new SqlCommand(string.Format("Update Articulo set Nombre='{0}', Precio='{1}' where idarticulo='{2}'",A.Nombre1,A.Precio1, A.IdArticulo), cnx);

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modificado");
                cnx.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { cnx.Close(); }




        }
        public static DataTable Buscar(Articulos A)
        {

            SqlCommand cmd = new SqlCommand(string.Format("select * from Articulo where nombre LIKE '%{0}%'",A.Nombre1), cnx);

            try
            {
                cnx.Open();
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
               D = new DataSet();
                DA.Fill(D, "Articulo");
                cnx.Close();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { cnx.Close(); }

            return D.Tables["Articulo"];

        }
    }
}
