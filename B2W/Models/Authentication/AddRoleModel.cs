using System.ComponentModel.DataAnnotations;

namespace B2W.Models.Authentication
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string role { get; set; }
    }
}
