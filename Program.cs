/* IAccount (interface):
- PasswordChecker() - parametr olaraq string password qəbul edir.
- ShowInfo()


User class (IAccount-u implement edir)
- Id
- Fullname
- Email
- Password
- PasswordChecker() - PasswordChecker methodu - gələn string password dəyərinin şərtləri ödəyib ödəmədiyini yoxlayıb true/false dəyər qaytarir.                        Şərtlər:
                        - şifrədə minimum 8 character olmalıdır
                        - şifrədə ən az 1 böyük hərf olmalıdır
                        - şifrədə ən az 1 kiçik hərf olmalıdır
                        - şifrədə ən az 1 rəqəm olmalıdır
- ShowInfo() - bu method console-a user-in Id, Fullname və email dəyərlərini yazdırır


ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. User yarandığı zaman email və password təyin edilməsi məcburidir.User-ə şifrə təyin edilərkən şifrənin PasswordChecker methodunun şərtlərini ödəməsi lazımdır.



Student class
- Id
- Fullname
- Point
- StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır


ps: Id dəyəri hər dəfə bir student obyekti yaranan zaman avtomatik artmalıdır və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar. Fullname və point olmadan student obyekti yaratmaq olmaz.


Group class
- GroupNo
- StudentLimit - qrupda ola biləcək tələbə sayını göstərir minumum 5 maximum 18 ola bilər.
- Students - Student tipindən bir array-dir özündə student obyektləri saxlayacaq və private olacaq.
- CheckGroupNo() - parametr olaraq string bir groupNo dəyəri alır və qrupun nömrəsini yoxlayır geriyə true/false dəyərləri qaytarır.
                                  Şərtlər: 2 böyük hərf əvvəldə və 3 rəqəmdən ibarət olmalıdır
- AddStudent() - parametr olaraq Student obyekti qəbul edir və gələn student obyektini Group class-ında olan Students arrayinə əlavə edir əgər arrayin uzuluğu StudentLimit-i keçirsə əlavə etməməlidi.
- GetStudent() - parametr olaraq nullable int tipindən bir id dəyəri alacaq və həmin id-li Student obyektini tapıb geriyə qaytaracaq.
- GetAllStudents() - geriyə Student arrayi qaytaracaq.


ps: GroupNo və StudentLimit dəyərləri olmadan Group Obyekti yaratmaq olmaz.
Program.cs'de işlədirsiniz.       */


using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
       
        User user = new User("Matheo", "matheo13@gmail.com", "Password123");
        user.ShowInfo();

        
        Student student1 = new Student("Matheo", 95.5);
        student1.StudentInfo();

        
        Group group = new Group("BP213", 10);
        if (group.CheckGroupNo("BP213"))
        {
            group.AddStudent(student1);
            Student[] allStudents = group.GetAllStudents();

            foreach (var student in allStudents)
            {
                student.StudentInfo();
            }
        }
    }
}
