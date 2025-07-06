using System.ComponentModel.DataAnnotations.Schema;
using B2W.Models.Authentication;
using Microsoft.Build.Framework;

namespace B2W.Models.User
{
    public class Skills
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("UserProfileId")]
        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }




    }
}
