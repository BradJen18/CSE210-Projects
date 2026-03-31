using System;

class Program
{
    static void Main(string[] args) // format the way it all prints
    {
        Lecture lecture = new Lecture("Lecture","Cookies and milk","how drinking milk with your cookies sets you ahead of the rest","4/13/2026","2:00 pm","Michael Jackson","20,000");
        lecture.SetAddress("1496 W Maple","Tempe","AZ","USA");
        lecture.Full();
        lecture.Standard();
        lecture.Short();

        Reception reception = new Reception("Reception","Wedding","The happy union of John and Jane","6/20/2026","6:00 pm","JohnDoe@gmail.com");
        reception.SetAddress("1497 S Fox","Manti","UT","USA");
        reception.Full();
        reception.Standard();
        reception.Short();

        Outdoor outdoor = new Outdoor("Outdoor","Team Bonding","Group activities to boost moral and develop trust between coworkers","4/42026","12:00 pm", "Sunny");
        outdoor.SetAddress("4976 E Leaf","San Diego","CA","USA");
        outdoor.Full();
        outdoor.Standard();
        outdoor.Short();
    }
}