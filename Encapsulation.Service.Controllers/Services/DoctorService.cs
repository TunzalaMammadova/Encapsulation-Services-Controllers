using System;



public class DoctorService
{
    private Doctor[] GetAllDoctors()
    {
        Doctor doctor1 = new()
        {
            name = "Tunzale",
            surname = "Memmedova",
            address = "Azadliq",
            birthday = new(1999, 08, 08)

        };

        Doctor doctor2 = new()
        {
            name = "Semed",
            surname = "Huseynov",
            address = "Xezer",
            birthday = new(1997, 04, 20)

        };


        Doctor doctor3 = new()
        {
            name = "Elnur",
            surname = "Memmedov",
            address = "Nesimi",
            birthday = new(2003, 04, 24)

        };


        Doctor doctor4 = new()
        {
            name = "Nergiz",
            surname = "Memmedova",
            address = "Azadliq",
            birthday = new(1998, 05, 13)
        };

        return new Doctor[] { doctor1, doctor2, doctor3, doctor4 };

    }

    public Doctor[] GetByBirthday(DateTime startDate, DateTime endDate)
    {
        Doctor[] doctors = GetAllDoctors();

        var result = doctors.Where(m => m.birthday > startDate && m.birthday < endDate).ToArray();

        return result;
    }

} 