public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {

        bool isNewYork = phoneNumber.Split('-')[0] == "212";
        bool isFake = phoneNumber.Split('-')[1] == "555";
        string lastDigits = phoneNumber.Split('-')[2];
        
        return (isNewYork, isFake, lastDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
