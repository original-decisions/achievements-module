using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Achievement
{
   /// <summary>
   /// таблица-связь награда за достижения
   /// </summary>
    public class AchievementReward
    {
        /// <summary>
        /// идентификатор достижения
        /// </summary>
        [Key,Column(Order = 0)]
        public int AchievementId { get; set; }
        /// <summary>
        /// серверный объект - достижение
        /// </summary>
        public Achievement Achievement { get; set; }
        /// <summary>
        /// идентификатор награды
        /// </summary>
        [Key,Column(Order = 1)]
        public int RewardId { get; set; }
        /// <summary>
        /// серверный объект - награда
        /// </summary>
        public Reward Reward { get; set; }
    }
}
