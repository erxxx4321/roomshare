using System.ComponentModel.DataAnnotations;

namespace roomshare.Models
{
	public class Reserve
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Tel { get; set; }
		public string Email { get; set; }
		public DateTime Time { get; set; }
		public int HouseId { get; set; }
	}
}