using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Domain.Models.Identity
{
    public class ApplicationUser :IdentityUser
    {
        [Column(TypeName = "nvarchar(25)")]
        public string ReferenceCode { get; set; }

        public Guid? ProfileImageId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Language { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Status { get; set; }

        public DateTime? LastLoginOn { get; set; }

        public DateTime? LockedOn { get; set; }

        public bool IsResetPassword { get; set; }

        public DateTime? PasswordChangedOn { get; set; }

        public DateTime? PasswordExpiredOn { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string AuthenticationType { get; set; }

        public Guid? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
