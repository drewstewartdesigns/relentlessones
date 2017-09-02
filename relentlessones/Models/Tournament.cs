using System;
namespace relentlessones.Models
{
	public class Tournament
	{
		public int TournamentID { get; set; }
		public string OpponentName { get; set; }
		public int PlayerID { get; set; }
		public int PointsFor { get; set; }
		public int PointsAgainst { get; set; }
	}
}
