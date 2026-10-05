using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWork01.Models
{
    //Student Table
    [Table("Students" , Schema = "edu")]
    internal class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StdId { get; set; }

        [MaxLength(100 , ErrorMessage = "First Name Can Not Be More Than 100 Char")] //nvarchar(100)
        [Column("StdFirstName")]
        [Required(ErrorMessage ="First Name is Required")]
        public string  FirstName { get; set; } //MSpping in DB to StdFirstName
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(200)]
        [EmailAddress]
        public string Email { get; set; }
        [Range(16 , 25)] //Validation hint 
        public int Age { get; set; }

        //Derived Attribuite
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public Address ShipmentAddress { get; set; }
    }
}
