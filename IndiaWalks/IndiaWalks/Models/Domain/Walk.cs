using IndiaWalks.Models.Domain;

namespace IndiaWalks.Models
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string  Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        public Region Regions { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
