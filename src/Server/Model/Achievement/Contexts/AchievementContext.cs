using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using odec.Server.Model.Achievement.Abst.Interfaces;
using System.Linq;
using Usr = odec.Server.Model.User.User;
namespace odec.Server.Model.Achievement.Contexts
{
    /// <summary>
    /// Db Context to get achievements and rewards for them
    /// </summary>
    public class AchievementContext : DbContext,
        IAchievementContext<Achievement, UserAchievement, Reward, RewardType, AchievementReward, AchievementConfirmation, Confirmation>
    {
        public AchievementContext(DbContextOptions<AchievementContext> options) : base(options) { }
        private string AchievementScheme = "achieve";
        private string MembershipScheme = "AspNet";
        /// <inheritdoc />
        public DbSet<Achievement> Achievement { get; set; }

        /// <inheritdoc />
        public DbSet<AchievementConfirmation> AchievementConfirmations { get; set; }

        /// <inheritdoc />
        public DbSet<Confirmation> Confirmation { get; set; }

        /// <inheritdoc />
        public DbSet<UserAchievement> UserAchievement { get; set; }

        /// <inheritdoc />
        public DbSet<Reward> Rewards { get; set; }

        /// <inheritdoc />
        public DbSet<RewardType> RewardTypes { get; set; }

        /// <inheritdoc />
        public DbSet<AchievementReward> AchievementRewards { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usr>().ToTable("Users", MembershipScheme);

            modelBuilder.Entity<Achievement>()
                .ToTable("Achievements", AchievementScheme);
            modelBuilder.Entity<Confirmation>()
                .ToTable("Confirmations", AchievementScheme);
            modelBuilder.Entity<AchievementConfirmation>()
                .ToTable("AchievementConfirmations", AchievementScheme)
                .HasKey(it => new { it.AchievementId, it.ConfirmationId });
            modelBuilder.Entity<UserAchievement>()
                .ToTable("UserAchievements", MembershipScheme)
                .HasKey(it => new { it.UserId, it.AchievementId }); ;
            modelBuilder.Entity<Reward>()
                .ToTable("Rewards", AchievementScheme);
            modelBuilder.Entity<RewardType>()
                .ToTable("RewardTypes", AchievementScheme);
            modelBuilder.Entity<AchievementReward>()
                .ToTable("AchievementRewards", AchievementScheme);
           
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
