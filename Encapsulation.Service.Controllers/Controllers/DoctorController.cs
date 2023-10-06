using System;




public class DoctorController
{
    public void ShowMeSelectedDoctors()
    {
        DateTime startDate = new(1993,05,25);
        DateTime endDate = new(2002, 12, 15);


        DoctorService doctorService = new();
        Doctor[] doctors = doctorService.GetByBirthday(startDate,endDate);

        foreach (var item in doctors)
        {
            var result = $"{item.name} - {item.surname} - {item.address} - {item.birthday.ToString("MM.dd.yyyy")}";

            Console.WriteLine(result);
        }
    }
}


