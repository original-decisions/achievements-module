using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Achievement
{
    /// <summary>
    /// таблица-связь достижения пользователя
    /// </summary>
    public class AchievementConfirmation
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
        /// идентификатор подтверждения
        /// </summary>
        [Key,Column(Order = 1)]
        public int ConfirmationId { get; set; }
        
        /// <summary>
        /// серверный объект - подтверждение
        /// </summary>
        public Confirmation Confirmation { get; set; }
    }
}
