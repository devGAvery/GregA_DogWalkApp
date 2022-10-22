using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkApp
{
    class Account
    {
        public int ID;
        public int totalSecondsWalked;
        public int totalMinutesWalked;
        public int totalHoursWalked;
        public int totalDaysWalked;
        public List<string> walkTimes = new List<string>();
        public List<DateTime> walkDates = new List<DateTime>();
        public bool activeClient;
        public double acctBalance;
        public string dogName;
        public string breed;
        public string color;
        public string toys;
        public string treats;
        public double hourlyRate;
        public List<string> notes = new List<string>();
        public string vetOffice;
        public string vetPhone;
        public string ownerName;
        public string ownerPhone;
        public string street;
        public string apt;
        public string city;
        public string state;
        public string zip;
        public string imageName;
        public string reportLine;

        public int getID() { return ID; }
        public void setID(int newID) { ID = newID; }

        public int getTotalSecondsWalked() { return totalSecondsWalked; }
        public void setTotalSecondsWalked(int newTotalSecondsWalked) { totalSecondsWalked = newTotalSecondsWalked; }
        public void addTotalSecondsWalked(int addSeconds) 
        {
            Console.WriteLine($"Account.addTotalSecondsWalked({addSeconds})");
            Console.WriteLine($"Account.totalSecondsWalked: {totalSecondsWalked} += {addSeconds}");
            totalSecondsWalked += addSeconds;
            Console.WriteLine($"Account.totalSecondsWalked: {totalSecondsWalked}");
            if (totalSecondsWalked > 59)
            {
                addTotalMinutesWalked(1);
                Console.WriteLine($"Account.totalSecondsWalked: {totalSecondsWalked} -= 60");
                totalSecondsWalked -= 60;
                Console.WriteLine($"Account.totalSecondsWalked: {totalSecondsWalked}");
            }
        }

        public int getTotalMinutesWalked() { return totalMinutesWalked; }
        public void setTotalMinutesWalked(int newTotalMinutesWalked) { totalMinutesWalked = newTotalMinutesWalked; }
        public void addTotalMinutesWalked(int addMinutes)
        {
            Console.WriteLine($"Account.addTotalMinutesWalked({addMinutes})");
            Console.WriteLine($"Account.totalMinutesWalked: {totalMinutesWalked} += {addMinutes}");
            totalMinutesWalked += addMinutes;
            Console.WriteLine($"Account.totalMinutesWalked: {totalMinutesWalked}");
            if (totalMinutesWalked > 59)
            {
                addTotalHoursWalked(1);
                Console.WriteLine($"Account.totalMinutesWalked: {totalMinutesWalked} -= 60");
                totalMinutesWalked -= 60;
                Console.WriteLine($"Account.totalMinutesWalked: {totalMinutesWalked}");
            }
        }

        public int getTotalHoursWalked() { return totalHoursWalked; }
        public void setTotalHoursWalked(int newTotalHoursWalked) { totalHoursWalked = newTotalHoursWalked; }
        public void addTotalHoursWalked(int addHours)
        {
            Console.WriteLine($"Account.addTotalHoursWalked({addHours})");
            Console.WriteLine($"Account.totalHoursWalked: {totalHoursWalked} += {addHours}");
            totalHoursWalked += addHours;
            Console.WriteLine($"Account.totalHoursWalked: {totalHoursWalked}");
            if (totalHoursWalked > 23)
            {
                Console.WriteLine($"Account.totalHoursWalked: {totalHoursWalked} -= 24");
                totalHoursWalked -= 24;
                Console.WriteLine($"Account.totalHoursWalked: {totalHoursWalked}");

                Console.WriteLine($"Account.addTotalDaysWalked: {totalDaysWalked} + 1");
                addTotalDaysWalked(1);
                Console.WriteLine($"Account.totalDaysWalked: {totalDaysWalked}");
            }
        }

        public int getTotalDaysWalked() { return totalDaysWalked; }
        public void setTotalDaysWalked(int newTotalDaysWalked) { totalDaysWalked = newTotalDaysWalked; }
        public void addTotalDaysWalked(int addDays) { totalDaysWalked += addDays; }

        public List<string> getWalkTimes() { return walkTimes; }
        public void setWalkTimes(List<string> newWalkTimes) { walkTimes = newWalkTimes; }

        public List<DateTime> getWalkDates() { return walkDates; }
        public void setWalkDates(List<DateTime> newWalkDates) { walkDates = newWalkDates; }

        public bool getActiveClientStatus() { return activeClient; }
        public void setActiveClientStatus(bool newStatus) { activeClient = newStatus; }

        public double getAccountBalance() { return acctBalance; }
        public void setAccountBalance(double newAcctBalance) { acctBalance = newAcctBalance; }

        public string getDogName() { return dogName; }
        public void setDogName(string newDogName) { dogName = newDogName; }

        public string getBreed() { return breed; }
        public void setBreed(string newBreed) { breed = newBreed; }

        public string getToys() { return toys; }
        public void setToys(string newToys) { toys = newToys; }

        public string getTreats() { return treats; }
        public void setTreats(string newTreats) { treats = newTreats; }

        public double getHourlyRate() { return hourlyRate; }
        public void setHourlyRate(double newRate) { hourlyRate = newRate; }

        public string getColor() { return color; }
        public void setColor(string newColor) { color = newColor;  }

        public List<string> getNotes() { return notes; }
        public void setNotes(List<string> newNotes) { notes = newNotes; }

        public string getVetPhone() { return vetPhone; }
        public void setVetPhone(string newVetPhone) { vetPhone = newVetPhone; }

        public string getVetOffice() { return vetOffice; }
        public void setVetOffice(string newVetOffice) { vetOffice = newVetOffice; }

        public string getOwnerName() { return ownerName; }
        public void setOwnerName(string newOwnerName) { ownerName = newOwnerName; }

        public string getOwnerPhone() { return ownerPhone; }
        public void setOwnerPhone(string newOwnerPhone) { ownerPhone = newOwnerPhone; }

        public string getStreet() { return street; }
        public void setStreet(string newStreet) { street = newStreet; }

        public string getApt() { return apt; }
        public void setApt(string newApt) { apt = newApt; }

        public string getCity() { return city; }
        public void setCity(string newCity) { city = newCity; }

        public string getState() { return state; }
        public void setState(string newState) { state = newState; }

        public string getZip() { return zip; }
        public void setZip(string newZip) { zip = newZip; }

        public string getImageName() { return imageName; }
        public void setImageName(string newImgNm) { imageName = newImgNm; }

        public string getReportLine() { return reportLine; }
        public void setReportLine(string newLine) { reportLine = newLine; }
    }
}
