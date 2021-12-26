﻿namespace Adv.Server.Master
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public int Id { get; set; }
        public Team Team { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, string password, int id, Team team, bool isAdmin)
        {
            Username = username;
            Password = password;
            Id = id;
            Team = team;
            IsAdmin = isAdmin;
        }
    }
}
