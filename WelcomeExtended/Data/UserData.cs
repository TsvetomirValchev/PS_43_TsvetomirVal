﻿using Welcome.Model;

namespace WelcomeExtended.Data
{
    internal class UserData
    {
        private List<User> _users;
        private int _nextId;

        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user) 
        { 
            user.ID = _nextId++;
            _users.Add(user);
        }

        public void DeleteUser(User user) 
        { 
            _users.Remove(user);
        }

        public bool ValidateUser(string name, string password) 
        { 
            foreach (var user in _users) 
            { 
                if(user.Name == name && user.Password == password) 
                    return true;
            }
            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(u => u.Name == name && u.Password == password)
                         .FirstOrDefault() != null ? true : false;
        }

        public bool validateUserLinq(string name, string password)
        {
            var res = from user in _users
                      where user.Name == name && user.Password == password
                      select user.ID;
            return res != null ? true: false;
        }
    }
}
