using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogWalkApp
{
    static class Program
    {
        
        public static List<Account> clients = new List<Account>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainPage mp = new MainPage();

            createAccount1();
            createAccount2();
            createAccount3();
            createAccount4();
            createAccount5();
            createAccount6();

            foreach (Account acct in clients)
            { 
                if(acct.activeClient == true)
                {
                    mp.acctCheckListBox.Items.Add($"{acct.ID}. {acct.dogName} - {acct.ownerName}");
                }
            }

            Application.Run(mp);    //new MainPage()
        }

        public static void createAccount1()
        {
            // dog #1 of 5
            Account newAcct = new Account();
            newAcct.setID(1);
            newAcct.setActiveClientStatus(true);
            newAcct.setDogName("Dougie");
            newAcct.setBreed("Pug");
            newAcct.setColor("Tan and Black");
            newAcct.setToys("rope");
            newAcct.setTreats("milkbone");
            newAcct.setImageName("doug");
            newAcct.setHourlyRate(14.00);
            newAcct.setAccountBalance(29.16);

            //walk #1 of 3
            newAcct.setTotalSecondsWalked(30);
            newAcct.setTotalMinutesWalked(15);
            newAcct.setTotalHoursWalked(1);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("01:15:30");
            var mon1 = new DateTime(2020, 8, 3, 8, 28, 41);
            newAcct.walkDates.Add(mon1);

            //walk #2 of 3
            newAcct.addTotalSecondsWalked(10);
            newAcct.addTotalMinutesWalked(50);
            newAcct.addTotalHoursWalked(0);
            newAcct.walkTimes.Add("00:50:10");
            var tue1 = new DateTime(2020, 8, 4, 8, 32, 3);
            newAcct.walkDates.Add(tue1);

            //walk #3 of 3
            newAcct.addTotalSecondsWalked(19);
            newAcct.addTotalMinutesWalked(56);
            newAcct.addTotalHoursWalked(0);
            newAcct.walkTimes.Add("00:56:19");
            var wed1 = new DateTime(2020, 8, 5, 8, 30, 39);
            newAcct.walkDates.Add(wed1);

            newAcct.notes.Add("likes to have his belly rubbed");
            newAcct.notes.Add("poor distance vision");
            newAcct.notes.Add("extremely gassy after eating");
            newAcct.notes.Add("plays well with other dogs");

            newAcct.setVetOffice("Nall Hills Vet");
            newAcct.setVetPhone("913-341-8836");
            newAcct.setOwnerName("Dino Dann");
            newAcct.setOwnerPhone("913-777-7777");
            newAcct.setStreet("4121 W 97th St");
            newAcct.setCity("Overland Park");
            newAcct.setState("KS");
            newAcct.setZip("66207");

            clients.Add(newAcct);
        }

        public static void createAccount2()
        {
            // dog #2 of 5
            Account newAcct = new Account();
            newAcct.setID(2);
            newAcct.setActiveClientStatus(true);
            newAcct.setDogName("Benji");
            newAcct.setBreed("mutt");
            newAcct.setColor("Brown & tan");
            newAcct.setToys("frisbee");
            newAcct.setTreats("beggin strips");
            newAcct.setImageName("benji");
            newAcct.setHourlyRate(12.00);
            newAcct.setAccountBalance(37.00);

            //walk #1 of 3
            newAcct.setTotalSecondsWalked(24);
            newAcct.setTotalMinutesWalked(46);
            newAcct.setTotalHoursWalked(0);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("00:46:24");
            var mon2 = new DateTime(2020, 8, 3, 6, 0, 16);
            newAcct.walkDates.Add(mon2);

            //walk #2 of 3
            newAcct.addTotalSecondsWalked(44);
            newAcct.addTotalMinutesWalked(14);
            newAcct.addTotalHoursWalked(1);
            newAcct.walkTimes.Add("01:14:44");
            var tue2 = new DateTime(2020, 8, 4, 6, 3, 40);
            newAcct.walkDates.Add(tue2);

            //walk #3 of 3
            newAcct.addTotalSecondsWalked(37);
            newAcct.addTotalMinutesWalked(5);
            newAcct.addTotalHoursWalked(1);
            newAcct.walkTimes.Add("01:05:37");
            var wed2 = new DateTime(2020, 8, 5, 5, 58, 55);
            newAcct.walkDates.Add(wed2);

            newAcct.notes.Add("high energy, very playful");
            newAcct.notes.Add("regular walks required");

            newAcct.setVetOffice("Olathe West Vet");
            newAcct.setVetPhone("816-841-6436");
            newAcct.setOwnerName("Dorothy Gale");
            newAcct.setOwnerPhone("913-555-5555");
            newAcct.setStreet("435 W 67th St");
            newAcct.setCity("Olathe");
            newAcct.setState("KS");
            newAcct.setZip("64130");

            clients.Add(newAcct);
        }


        public static void createAccount3()
        {
            // dog #3 of 5
            Account newAcct = new Account();
            newAcct.setID(3);
            newAcct.setActiveClientStatus(true);
            newAcct.setDogName("Toto");
            newAcct.setBreed("Scot Ter");
            newAcct.setColor("Black/gray");
            newAcct.setToys("stfd giraffe");
            newAcct.setTreats("beggin strips");
            newAcct.setImageName("totto");
            newAcct.setHourlyRate(12.00);
            newAcct.setAccountBalance(37.00);

            //walk #1 of 3
            newAcct.setTotalSecondsWalked(24);
            newAcct.setTotalMinutesWalked(46);
            newAcct.setTotalHoursWalked(0);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("00:46:24");
            var mon3 = new DateTime(2020, 8, 3, 6, 0, 16);
            newAcct.walkDates.Add(mon3);

            //walk #2 of 3
            newAcct.addTotalSecondsWalked(44);
            newAcct.addTotalMinutesWalked(14);
            newAcct.addTotalHoursWalked(1);
            newAcct.walkTimes.Add("01:14:44");
            var tue3 = new DateTime(2020, 8, 4, 6, 3, 40);
            newAcct.walkDates.Add(tue3);

            //walk #3 of 3
            newAcct.addTotalSecondsWalked(37);
            newAcct.addTotalMinutesWalked(5);
            newAcct.addTotalHoursWalked(1);
            newAcct.walkTimes.Add("01:05:37");
            var wed3 = new DateTime(2020, 8, 5, 5, 58, 55);
            newAcct.walkDates.Add(wed3);

            newAcct.notes.Add("may nip when overly excited/anxious");
            newAcct.notes.Add("enjoys long walks");
            newAcct.notes.Add("enjoys being held");

            newAcct.setVetOffice("Olathe West Vet");
            newAcct.setVetPhone("816-841-6436");
            newAcct.setOwnerName("Dorothy Gale");
            newAcct.setOwnerPhone("913-555-5555");
            newAcct.setStreet("435 W 67th St");
            newAcct.setCity("Olathe");
            newAcct.setState("KS");
            newAcct.setZip("64130");

            clients.Add(newAcct);
        }


        public static void createAccount4()
        {
            // dog #4 of 5
            Account newAcct = new Account();
            newAcct.setID(4);
            newAcct.setActiveClientStatus(true);
            newAcct.setDogName("Lasie");
            newAcct.setBreed("Collie");
            newAcct.setColor("Tan & white");
            newAcct.setToys("red kong");
            newAcct.setTreats("raw hide");
            newAcct.setImageName("lassie");
            newAcct.setHourlyRate(15.00);
            newAcct.setAccountBalance(0.00);

            //walk #1 of 3
            newAcct.setTotalSecondsWalked(8);
            newAcct.setTotalMinutesWalked(28);
            newAcct.setTotalHoursWalked(1);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("01:28:08");
            var mon4 = new DateTime(2020, 8, 3, 9, 46, 20);
            newAcct.walkDates.Add(mon4);

            //walk #2 of 3
            newAcct.addTotalSecondsWalked(24);
            newAcct.addTotalMinutesWalked(20);
            newAcct.addTotalHoursWalked(1);
            newAcct.walkTimes.Add("01:20:24");
            var tue4 = new DateTime(2020, 8, 4, 10, 5, 6);
            newAcct.walkDates.Add(tue4);

            //walk #3 of 3
            newAcct.addTotalSecondsWalked(45);
            newAcct.addTotalMinutesWalked(55);
            newAcct.addTotalHoursWalked(0);
            newAcct.walkTimes.Add("00:55:45");
            var wed4 = new DateTime(2020, 8, 5, 9, 55, 23);
            newAcct.walkDates.Add(wed4);

            newAcct.notes.Add("must be brushed after walks");
            newAcct.notes.Add("protective of Timmy");
            newAcct.notes.Add("good on walks");
            newAcct.notes.Add("plays well with other dogs");

            newAcct.setVetOffice("Nall Hills Vet");
            newAcct.setVetPhone("913-341-8836");
            newAcct.setOwnerName("Timmy Martin");
            newAcct.setOwnerPhone("913-888-8888");
            newAcct.setStreet("3822 W 83th St");
            newAcct.setCity("Mission Hills");
            newAcct.setState("KS");
            newAcct.setZip("66410");

            clients.Add(newAcct);
        }


        public static void createAccount5()
        {
            // dog #5 of 5
            Account newAcct = new Account();
            newAcct.setID(5);
            newAcct.setActiveClientStatus(false);
            newAcct.setDogName("Old Yeller");
            newAcct.setBreed("Labradore");
            newAcct.setColor("Golden");
            newAcct.setToys("pull rope");
            newAcct.setTreats("ham bone");
            newAcct.setImageName("old_yeller");
            newAcct.setHourlyRate(17.00);
            newAcct.setAccountBalance(0.00);

            //walk #1 of 1
            newAcct.setTotalSecondsWalked(29);
            newAcct.setTotalMinutesWalked(10);
            newAcct.setTotalHoursWalked(1);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("01:10:29");
            var sun5 = new DateTime(2020, 8, 2, 9, 15, 36);
            newAcct.walkDates.Add(sun5);

            newAcct.notes.Add("protective of Travis");
            newAcct.notes.Add("very smart");
            newAcct.notes.Add("barks at trouble");

            newAcct.setVetOffice("State Line Vet");
            newAcct.setVetPhone("816-841-6436");
            newAcct.setOwnerName("Arliss Coates");
            newAcct.setOwnerPhone("816-444-4444");
            newAcct.setStreet("6432 W 103rd St");
            newAcct.setCity("Kansas City");
            newAcct.setState("MO");
            newAcct.setZip("64131");

            clients.Add(newAcct);
        }

        public static void createAccount6()
        {
            // dog #6 of 6
            Account newAcct = new Account();
            newAcct.setID(6);
            newAcct.setActiveClientStatus(false);
            newAcct.setDogName("cujo");
            newAcct.setBreed("St Bernard");
            newAcct.setColor("Brown");
            newAcct.setToys("cars");
            newAcct.setTreats("people");
            newAcct.setImageName("cujo");
            newAcct.setHourlyRate(19.00);
            newAcct.setAccountBalance(25.00);

            //walk #1 of 1
            newAcct.setTotalSecondsWalked(00);
            newAcct.setTotalMinutesWalked(10);
            newAcct.setTotalHoursWalked(0);
            newAcct.setTotalDaysWalked(0);
            newAcct.walkTimes.Add("00:10:00");
            var sat6 = new DateTime(2020, 8, 1, 8, 33, 46);
            newAcct.walkDates.Add(sat6);

            newAcct.notes.Add("may threaten strangers");
            newAcct.notes.Add("scary and unfriendly");
            newAcct.notes.Add("due for rabies shot");

            newAcct.setVetOffice("KCK Vet");
            newAcct.setVetPhone("913-564-1377");
            newAcct.setOwnerName("Joe Camber");
            newAcct.setOwnerPhone("913-666-1234");
            newAcct.setStreet("10332 N Oak Blvd");
            newAcct.setCity("Kansas City");
            newAcct.setState("KS");
            newAcct.setZip("66611");

            clients.Add(newAcct);
        }
    }
}
