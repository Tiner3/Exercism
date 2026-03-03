static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return Convert.ToDateTime(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return (DateTime.Now > appointmentDate) ? true : false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) ? true : false;
    }

    public static string Description(DateTime appointmentDate)
    {
        string when = (appointmentDate.Hour <= 12) ? "AM" : "PM";

        return $"You have an appointment on {appointmentDate.ToString("M/d/yyyy h:mm:ss")} {when}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
