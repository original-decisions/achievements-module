using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Usr =odec.Server.Model.User.User;
namespace odec.Server.Model.Achievement
{
    /// <summary>
    /// Серверный объект - связь пользователя и достижения
    /// </summary>
    public class UserAchievement
    {
        /// <summary>
        /// идентификатор достижения
        /// </summary>
        [Key, Column(Order = 0)]
        public int AchievementId { get; set; }
        
        /// <summary>
        /// Серверный объект - достижение
        /// </summary>
        public Achievement Achievement { get; set; }
        
        /// <summary>
        /// идентификатор пользователя
        /// </summary>
        [Key, Column(Order = 1)]
        public int UserId { get; set; }

        /// <summary>
        /// Серверный объект - пользователь
        /// </summary>
        public Usr User { get; set; }
    }
}
