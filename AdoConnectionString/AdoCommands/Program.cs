﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoCommands
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ShopNew; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT  [MotorType]  FROM[ShopNew].[dbo].[Cars]  where CarId = '10001'", connection);
            string motorType = (string)cmd.ExecuteScalar();
            Console.WriteLine(motorType);
            Console.ReadLine();
            */
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ShopNew; Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM[ShopNew].[dbo].[Cars]", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + ": " + reader[i]);
                }
                Console.WriteLine(new string('_', 20));
            }
            reader.Close();
            connection.Close();
            Console.ReadLine();

        }
    }
}
