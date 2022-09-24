namespace ChallengeNetBackEnd.Utils
{
    public class Helpers
    {
        /// <summary>
        /// Método para convertir cadena de caracteres a fecha. 
        /// Si no cumple con le formato retorna un mensaje o si los valodes de días y meses
        /// estan fuera del rango
        /// </summary>
        /// <param name="date">String con el formato {dd-mm-yyyy}</param>
        /// <param name="output">Parámetro de salida con la fecha</param>
        /// <returns>
        /// Cadena vacía en caso que la conversión sea exitosa, en caso contrario mensaje con el error
        /// </returns>
        public static string ParsingStringToDate(string date, out DateTime output)
        {
            string msg = string.Empty;
            output = DateTime.Now;
            try
            {
                string[] arrDate = date.Split('-');
                if (arrDate.Length > 1)
                    output = new DateTime(int.Parse(arrDate[2]), int.Parse(arrDate[1]), int.Parse(arrDate[0])); 
                else
                    msg = "Date must have the following format {dd-mm-yyyy}";
            }
            catch (Exception)
            {
                msg = "Date must have valid values";
            }
            return msg;
        }
    }
}
