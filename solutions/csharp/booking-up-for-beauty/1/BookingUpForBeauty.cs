static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (appointmentDateDescription.Contains(','))
        {
            DateTime parsedAppointment = DateTime.Parse(appointmentDateDescription);
            return new DateTime(parsedAppointment.Year,parsedAppointment.Month, parsedAppointment.Day, parsedAppointment.Hour, parsedAppointment.Minute, parsedAppointment.Nanosecond);
        }
        else
        {
            var listDays = new List<int> { };
            var listHours = new List<int> { };
            foreach (string date in appointmentDateDescription.Split(" ")[0].Split("/"))
            {
                listDays.Add(int.Parse(date));
            }
            foreach (string time in appointmentDateDescription.Split(" ")[1].Split(':'))
            {
                listHours.Add(int.Parse(time));
            }
            return new DateTime(listDays[2], listDays[0], listDays[1], listHours[0], listHours[1], listHours[2]);
        }
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9,15);
    }
}
