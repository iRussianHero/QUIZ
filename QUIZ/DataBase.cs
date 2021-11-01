﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    class DataBase
    {
        private const string CONN_STR = "Server=mysql60.hostland.ru;Database=host1323541_sbd17;Uid=host1323541_itstep;Pwd=269f43dc;";
        private MySqlConnection db;
        private MySqlCommand command;

        public DataBase()
        {
            db = new MySqlConnection(CONN_STR);
            command = new MySqlCommand { Connection = db };
        }
        public void Open() => db.Open();

        public void Close() => db.Close();

        public List<Users> UsersData()
        {
            Open();
            var temp = new List<Users>();
            var sql = "SELECT * FROM users;";
            command.CommandText = sql;
            var res = command.ExecuteReader();

            if (!res.HasRows) return null;

            while (res.Read())
            {
                var userId = res.GetInt32("user_id");
                var userName = res.GetString("user_name");
                var userPassword = res.GetString("user_password");
                var email = res.GetString("user_email");
                var dateOfBirth = res.GetDateTime("user_date_of_birthday");
                temp.Add(new Users { UserId = userId, UserName = userName, UserPassword = userPassword, Email = email, DateOfBirthday = dateOfBirth });
            }

            return temp;
        }
    }
}