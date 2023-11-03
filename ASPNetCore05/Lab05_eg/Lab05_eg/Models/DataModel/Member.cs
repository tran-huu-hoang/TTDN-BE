namespace Lab05_eg.Models.DataModel
{
    public class Member
    {
        public int MemberId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
