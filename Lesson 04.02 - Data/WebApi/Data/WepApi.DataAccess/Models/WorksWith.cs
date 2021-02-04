namespace WepApi.DataAccess.Models
{
    public class WorksWith
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int Sales { get; set; }

        //
        // EmployeeId, ClientId, Sales
    }
}