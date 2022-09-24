using ChallengeNetBackEnd.Models.DTOs;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IUserQueries
    {
        /// <summary>
        /// Obtiene la información del usuario por id
        /// </summary>
        /// <param name="id">Identificador de usuario</param>
        /// <returns></returns>
        UserDTO? GetUserById(int id);

        /// <summary>
        /// Obtiene el resumen del usuario a la fecha actual.
        /// Nota: La fecha actual se utiliza para obtener la tasa de cambio
        /// por lo que es probable que el resultado se 0 en el resumen
        /// si no existe tasa de cambio para fecha actual
        /// </summary>
        /// <param name="userId">Identificador del usuario</param>
        /// <returns>
        /// Balance y aportes
        /// </returns>
        SummaryDTO? GetSummary(int userId);

        /// <summary>
        /// Obtiene el resumen del usuario a la fecha dada
        /// </summary>
        /// <param name="userId">Identificador del usuario</param>
        /// <param name="date">Fecha hasta la cual se desea el resumen</param>
        /// <returns>
        /// Balance y aportes
        /// </returns>
        SummaryDTO? GetSummary(int userId, DateTime date);

        /// <summary>
        /// Obtiene los objetivos del usuario
        /// </summary>
        /// <param name="userId">Identificador del usuario</param>
        /// <returns>
        /// Información del objetivo con su portafolio
        /// </returns>
        IEnumerable<GoalDTO> GetGoals(int userId);

        /// <summary>
        /// Obtiene el detalle de un objetivo en especifico
        /// </summary>
        /// <param name="userId">Identificador del usuario</param>
        /// <param name="goalId">Identificador del objetivo</param>
        /// <returns>
        /// Información del objetivo con su portafolio
        /// </returns>
        GoalDetailDTO? GetGoalDetail(int userId, int goalId);
    }
}