namespace MUTALE_VE.Models
{
    public class ReachOuts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Phone { get; set; }

    }
}
