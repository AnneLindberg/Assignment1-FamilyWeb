﻿using System.ComponentModel.DataAnnotations;

 namespace Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Role { get; set; }   
        public int SecurityLevel { get; set; }
        [Required]
        public string Password { get; set; }
    }
}