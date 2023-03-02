namespace MVCProjectApp.Models.Domain
{

    /*
     * This is the model for our employee object that's going to be 
     * in the database
     * 
     * Entity framework automatically sets anything named ID as the PK, 
     * unless otherwise stated with an annotation
     */

    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public String Department { get; set;}
        public DateTime DateOfBirth { get; set; }
    }
}
