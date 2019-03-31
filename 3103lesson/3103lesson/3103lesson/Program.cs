using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3103lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SQLiteConnection con = new SQLiteConnection($@"Data Source = C:\Users\HackerU\Desktop\3103lesson\rel.db; Version = 3"))
                con.Open();
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from lecturer JOIN cars on lecturer.car_id = CARS.id"))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read() == true)
                        {
                            Lecturer l = new Lecturer
                            {
                                ID=(int)reader["LECTURER_ID"],
                                Car_ID = (int)reader["CAR_ID"],
                                Name = (string)reader["NAME"],
                                Title = (string)reader["TITLE"]
                            };

                            Car c = new Car
                            {
                                ID =(int)reader["CAR_ID"],
                                Lecturer_ID = (int)reader["LECTURER_ID"],
                                Model = (string)reader["MODEL"],
                                Brand = (string)reader["BRAND"],
                                Color = (string)reader["COLOR"],
                                Year = (int)reader["YEAR"]
                            };

                            var result = new { l, c };
                        }
                    }
                }
            }
        }
    }
}
