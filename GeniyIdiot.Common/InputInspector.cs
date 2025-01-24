namespace GeniyIdiot.Common
{
    public class InputInspector
    {

        public static bool TryGetNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                errorMessage = "Введите цело число";
                number = 0;
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Введите целое число не более 3 знаков";
                number = 0;
                return false;
            }
        }

        public static bool TryGetPassword(string input)
        {
            var result = AdminStorage.GetPassword();
            //var setPassword = GetNewPasswors();
            var userAdmin = Convert.ToString(input);

            if (result.AdminPassword == input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
