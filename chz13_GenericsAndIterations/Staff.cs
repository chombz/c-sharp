using System;


namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// class that will be used to create Staff objects.
    /// </summary>
    public class Staff : Person
    {
        //Properties unique to staff class
        public string StaffID { get; set; }
        public DateTime EmploymentDate{ get; set; }
        public string Designation { get; set; }
        public string Email { get; set;}
        public string PhoneNo { get; set; }


        public Staff(string names, DateTime dob, char gender, string nationality,
                     string staffId, DateTime employDate, string designation, string email, string phoneNo)
                    : base(names, dob, gender, nationality)
        {
            this.StaffID = staffId;
            this.EmploymentDate = employDate;
            this.Designation = designation;
            this.Email = email;
            this.PhoneNo = phoneNo;
        }


        //override the ToString method for same output as above
        public override string ToString()
        {
            return $"Person\'s Details" +
                    $"\n---------------------------------------" +
                    $"\nName: {this.Names}" +
                    $"\nStaff ID: {this.StaffID}" +
                    $"\nDate of birth:{this.BirthDate: d}" +
                    $"\nGender : {((this.Gender == 'M' || this.Gender == 'm') ? "Male" : "Female")}" +
                    $"\nEmployee Date: {this.EmploymentDate}" +
                    $"\nDesignation: {this.Designation}" +
                    $"\nYears Served: {(DateTime.Now.Year) - (this.EmploymentDate.Year)} years" +
                    $"\nPhone Number: {this.PhoneNo}" +
                    $"\nNationality: {this.Nationality}" +
                    $"\n---------------------------------------\n";
        }
    }
}
