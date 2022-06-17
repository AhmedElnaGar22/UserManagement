using System.ComponentModel.DataAnnotations.Schema;

namespace UserSignUp.Models
{
    public class PermissonRole
    {
        public int Id { get; set; }

        [ForeignKey("Permissons")]
        public int Permisson_Id { get; set; }

        [ForeignKey("Roles")]
        public int Role_Id { get; set; }
    }
}
