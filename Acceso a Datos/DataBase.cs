﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class DataBase
    {
        public static string Connection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["NWConnectionString"].ConnectionString;

            }

        }
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(Connection);
            connection.Open();
            return connection;
        }
    }
}
