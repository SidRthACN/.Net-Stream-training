namespace Library_Management_System
{ 
	public class Book
	{
			public int BookId { get; set; } 
			public string Title { get; set; }
			public string Author { get; set; }
			public int Available { get; set; } = 0;
			public List<Student> IssuedTo { get; set; } = new();

	}
}