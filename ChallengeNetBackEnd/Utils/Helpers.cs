namespace ChallengeNetBackEnd.Utils
{
    public class Helpers
    {
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
