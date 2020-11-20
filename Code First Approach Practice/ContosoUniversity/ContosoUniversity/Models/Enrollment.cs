namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }//primary key
        public int CourseID { get; set; } //The CourseID property is a foreign key
        public int StudentID { get; set; }//foreign key
        public Grade? Grade { get; set; }
        //The question mark after the Grade type declaration indicates that the Grade property is nullable.
        //A grade that's null is different from a zero grade — null means a grade isn't known or hasn't been assigned yet.

        public virtual Course Course { get; set; }
        //the corresponding navigation property is Course.
        //An Enrollment entity is associated with one Course entity.
        public virtual Student Student { get; set; } //navigation property
         //An Enrollment entity is associated with one Student entity, 
        //so the Enrollment property can only hold a single Student entity
    }
}
//Entity Framework interprets a property as a foreign key property 
//if it's named <navigation property name><primary key property name> 
//(for example, StudentID for the Student navigation property since the Student entity's primary key is ID). 
