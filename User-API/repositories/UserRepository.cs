
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using User_API.database;
using User_API.entities;

namespace User_API.repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly Database db = new Database
        ("Data Source=Machine;Initial Catalog=userdb;User ID=Reykon;Password=GR@217748;Pooling=False");


        public List<User> GetAll()
        {

            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "SELECT * FROM Users";

                try
                {
                    cmd.Connection = db.GetConnection();
                    db.Connect();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            List<User> list = new List<User>();

                            while (dr.Read())
                            {
                                User u = new User();

                                u.Id = dr.GetInt32(dr.GetOrdinal("id"));
                                u.FirstName = dr.GetString(dr.GetOrdinal("first_name"));
                                u.LastName = dr.GetString(dr.GetOrdinal("last_name"));
                                u.Age = dr.GetInt32(dr.GetOrdinal("age"));
                                u.Email = dr.GetString(dr.GetOrdinal("email"));
                                u.Username = dr.GetString(dr.GetOrdinal("user_name"));
                                u.Password = dr.GetString(dr.GetOrdinal("password"));
                                list.Add(u);

                            }
                            return list;
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect();
                }
            }

            return null;
        }

        public User GetById(int id)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Users WHERE id = @id";

                try
                {
                    cmd.Connection = db.GetConnection();
                    cmd.Parameters.AddWithValue("@id", id);
                    db.Connect();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            User u = new User();
                            dr.Read();
                            u.Id = dr.GetInt32(dr.GetOrdinal("id"));
                            u.FirstName = dr.GetString(dr.GetOrdinal("first_name"));
                            u.LastName = dr.GetString(dr.GetOrdinal("last_name"));
                            u.Age = dr.GetInt32(dr.GetOrdinal("age"));
                            u.Email = dr.GetString(dr.GetOrdinal("email"));
                            u.Username = dr.GetString(dr.GetOrdinal("user_name"));
                            u.Password = dr.GetString(dr.GetOrdinal("password"));
                            db.Disconnect();
                            return u;
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect();
                }
            }

            return null;
        }


        public void Insert(User u)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Users (first_name, last_name, age, email, user_name, password)" +
                                  "VALUES (@first_name, @last_name, @age, @email, @user_name, @password)";

                try
                {
                    cmd.Connection = db.GetConnection();

                    cmd.Parameters.AddWithValue("@first_name", u.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", u.LastName);
                    cmd.Parameters.AddWithValue("@age", u.Age);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@user_name", u.Username);
                    cmd.Parameters.AddWithValue("@password", u.Password);


                    db.Connect();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect();
                }
            }
        }




        public void DeleteById(int id)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "DELETE FROM Users WHERE id = @id";

                try
                {
                    cmd.Connection = db.GetConnection();
                    cmd.Parameters.AddWithValue("@id", id);

                    db.Connect();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {

                }
                finally
                {
                    db.Disconnect();
                }
            }
        }

        public void Update(User u)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText =
                "UPDATE Users " +
                "SET first_name = @first_name, last_name = @last_name, age = @age, email = @email, user_name = @user_name, password = @password " +
                "WHERE id = @id";

                try
                {
                    cmd.Connection = db.GetConnection();

                    cmd.Parameters.AddWithValue("@id", u.Id);
                    cmd.Parameters.AddWithValue("@first_name", u.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", u.LastName);
                    cmd.Parameters.AddWithValue("@age", u.Age);
                    cmd.Parameters.AddWithValue("@email", u.Email);
                    cmd.Parameters.AddWithValue("@user_name", u.Username);
                    cmd.Parameters.AddWithValue("@password", u.Password);


                    db.Connect();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect();
                }
            }
        }
    }
}
