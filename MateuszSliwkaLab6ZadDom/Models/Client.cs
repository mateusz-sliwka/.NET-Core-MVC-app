using System;
using System.ComponentModel.DataAnnotations;

namespace MateuszSliwkaLab6.Models
{
    public class Client
    {
        [Required]
        public string Firstname{ get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public Client()
        {
        }
    }
}
