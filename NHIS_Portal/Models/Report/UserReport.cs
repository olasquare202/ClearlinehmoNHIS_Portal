namespace NHIS_Portal.Models.Report
{
    public class UserReport
    {
        public int Id { get; set; }
        public string? AuthorizationCode { get; set; }
        public string? EnroleeName { get; set; }
        public Guid EnroleeNumber { get; set; }
        public string? ListOfHospital { get; set; }
        public string? Diagnosis { get; set; }
        public DateTime CreatedDate { get; set; }
        //Download these list of data to excel sheet

    }
}
