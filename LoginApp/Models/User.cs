namespace LoginApp.Models
{
	public class User
	{
        public int UserId { get; set; }
		public int FirstName { get; set; }
		public int LastName { get; set; }
		public int Email { get; set; }
		public int Password { get; set; }
		public int isActive { get; set; } = 1; 
		public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
