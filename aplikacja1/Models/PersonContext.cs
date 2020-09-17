using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace aplikacja1.Models
{
    public class PersonContext
    {
        public string ConnectionString { get; set; }
        public PersonContext()
        {
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=127.0.0.1;uid=root;pwd=haslo123;database=angular");
        }
        public List<Person> GetAllPerson()
        {
            List<Person> list = new List<Person>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM osoby", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Person
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Email = reader["Email"].ToString(),
                            Age = Convert.ToInt32(reader["Age"])
                        });
                    }
                }
            }

            return list;
        }

        public Person GetPerson(int id)
        {
            Person person;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM osoby WHERE id=" + id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    person = new Person
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Surname = reader["Surname"].ToString(),
                        Email = reader["Email"].ToString(),
                        Age = Convert.ToInt32(reader["Age"])
                    };
                }
            }
            return person;
        }
        public void UpdatePerson(Person person)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE osoby SET name='" + person.Name + "', surname='" + person.Surname + "', email='" + person.Email + "', age=" + person.Age + " WHERE id=" + person.Id,conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddPerson(Person person)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO osoby(name,surname,email,age) VALUES('" + person.Name + "','" + person.Surname + "','" + person.Email + "',"+person.Age+")",conn);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePerson(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM osoby WHERE id="+id,conn);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
