using System;
using System.ComponentModel.DataAnnotations;

namespace Football.Web.Models
{
    public class PlayerListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
