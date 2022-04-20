using System;

namespace ToDoList
{
    class Program
    {
        public static void Main(string[] args){
            // Personellerimizi ekledik
            PersonList.personList.Add(new Person("Ahmet",20,001));
            PersonList.personList.Add(new Person("Ayşe" ,32,002));
            PersonList.personList.Add(new Person("Deniz",13,003));
            PersonList.personList.Add(new Person("Murat",27,004));
            PersonList.personList.Add(new Person("Pınar",18,005));

            // Kartlarımızı ekliyoruz
            CardsList.cardList.Add(new Cards("Reklam çalışması","Şirketimiz Hakkında Reklam Çalışması Yürütülecek",PersonList.personList[0],Sizes.XSMALL,Status.TODO));
            CardsList.cardList.Add(new Cards("Eleman alımı","Backend Departmanımıza yeni bir personel alınacak",PersonList.personList[1],Sizes.MEDIUM,Status.TODO));
            CardsList.cardList.Add(new Cards("Reklam çalışması","Şirketimiz Hakkında Reklam Çalışması Yürütülecek",PersonList.personList[2],Sizes.LARGE,Status.INPROGRESS));
            CardsList.cardList.Add(new Cards("Eleman alımı","Backend Departmanımıza yeni bir personel alınacak",PersonList.personList[3],Sizes.LARGE,Status.INPROGRESS));
            
            // Menümüzü yazdırıyoruz
            ConsoleController.MenuYazdir();
        }
    }
}