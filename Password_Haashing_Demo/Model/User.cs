﻿namespace Password_Haashing_Demo.Model
{
    public class User
    {
        public Guid Id { get; set; } 
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
    }
}