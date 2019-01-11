using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;


namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer's Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

       // [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        //   public MembershipType MembershipType { get; set; }//Navigation Property

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}