using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class CategoriaRepositorio
    {
        public List<Categorias> ObtenerTodo()
        {

            using (var conexion = DataBase.GetSqlConnection())
            {
                String selectAll = "";
                selectAll = selectAll + "SELECT [CategoryID] " + "\n";
                selectAll = selectAll + "      ,[CategoryName] " + "\n";
                selectAll = selectAll + "      ,[Description] " + "\n";
                selectAll = selectAll + "  FROM [dbo].[Categories]";        

                var categ = conexion.Query<Categorias>(selectAll).ToList();
                return categ;
            }


        }
        public Categorias ObtenerID(int id) 
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectID = "";
                SelectID = SelectID + "SELECT [CategoryID] " + "\n";
                SelectID = SelectID + "      ,[CategoryName] " + "\n";
                SelectID = SelectID + "      ,[Description] " + "\n";
                SelectID = SelectID + "      ,[Picture] " + "\n";
                SelectID = SelectID + "  FROM [dbo].[Categories] " + "\n";
                SelectID = SelectID + "  WHERE CategoryID = @CategoryID";

                var Category = conexion.QueryFirstOrDefault<Categorias>(SelectID, new { CategoryID = id });
                return Category;
            }
        }


        public int insertarCateg(Categorias categorias) 
        {
            using (var conexion = DataBase.GetSqlConnection()) 
            {
                string insertar = @"
                INSERT INTO [dbo].[Categories] 
                ([CategoryName], [Description]) 
                VALUES (@CategoryName, @Description)";



                var insertadas = conexion.Execute(insertar, new
                {
                    CategoryID = categorias.CategoryID,
                    CategoryName = categorias.CategoryName,
                    Description = categorias.Description
                });

                return insertadas;
                   
            }
        }

        public int UpdateCategory(Categorias categorias)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String update = @"
                    UPDATE [dbo].[Categories]
                    SET [CategoryName] = @CategoryName,
                    [Description] = @Description
                    WHERE [CategoryID] = @CategoryID";

                var actualizadas = conexion.Execute(update, new
                {
                    CategoryID = categorias.CategoryID,
                    CategoryName = categorias.CategoryName,
                    Description = categorias.Description
                });

                
                return actualizadas;
            }
        }


        public int DeleteCategory(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String delete = "";
                delete = delete + "DELETE FROM [dbo].[Categories] " + "\n";
                delete = delete + "      WHERE CategoryID = @CategoryID";



                var eliminadas = conexion.Execute(delete, new { CategoriaID = id });
                return eliminadas;
            }


        }

    }
}
