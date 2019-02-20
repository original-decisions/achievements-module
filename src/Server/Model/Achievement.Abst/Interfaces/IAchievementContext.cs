

using Microsoft.EntityFrameworkCore;

namespace odec.Server.Model.Achievement.Abst.Interfaces
{
    /// <summary>
    /// Proxy for context
    /// </summary>
    /// <typeparam name="TAchievement">Achievement Type</typeparam>
    /// <typeparam name="TUserAchievement">Link between users and achievements type</typeparam>
    /// <typeparam name="TReward">Reward type </typeparam>
    /// <typeparam name="TRewardType">Reward category type</typeparam>
    /// <typeparam name="TAchievementReward">Link between achievements and rewards</typeparam>
    /// <typeparam name="TAchievementConfirmation">lLink between achievements and confirmations</typeparam>
    /// <typeparam name="TConfirmation">Confirmation Type</typeparam>
    public interface IAchievementContext<TAchievement, TUserAchievement, TReward, TRewardType, TAchievementReward, TAchievementConfirmation, TConfirmation>
        where TAchievement : class
        where TUserAchievement : class
        where TReward : class
        where TRewardType : class
        where TAchievementReward : class 
        where TAchievementConfirmation : class
        where TConfirmation : class
    {
        /// <summary>
        /// Achievements table
        /// </summary>
        DbSet<TAchievement> Achievement { get; set; }
        /// <summary>
        /// Link table between Achievements and Confirmation
        /// </summary>
        DbSet<TAchievementConfirmation> AchievementConfirmations { get; set; }
        /// <summary>
        /// Confirmations table
        /// </summary>
        DbSet<TConfirmation> Confirmation { get; set; }

        /// <summary>
        /// Link table between users and Achievements
        /// </summary>
        DbSet<TUserAchievement> UserAchievement { get; set; }
        /// <summary>
        /// Rewards table
        /// </summary>
        DbSet<TReward> Rewards { get; set; }
        /// <summary>
        /// Reward type(Category) table
        /// </summary>
        DbSet<TRewardType> RewardTypes { get; set; }
        /// <summary>
        /// Link table between Achievements and rewards
        /// </summary>
        DbSet<TAchievementReward> AchievementRewards { get; set; }

    }
}
