using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Work4
{
    internal class Work4
    {

        static void Main(string[] args)
        {
            Person person = AddPerson();
            AddPersonToFile(person);
            Console.WriteLine("Программа добавила личность в файл");
            Console.ReadKey();

        }

        static void AddPersonToFile(Person person)
        {
            //< Person name =”ФИО человека” >
            //    < Address >
            //        < Street > Название улицы </ Street >
            //        < HouseNumber > Номер дома </ HouseNumber >
            //        < FlatNumber > Номер квартиры </ FlatNumber >
            //    </ Address >
            //    < Phones >
            //        < MobilePhone > 89999999999999 </ MobilePhone >
            //        < FlatPhone > 123 - 45 - 67 < FlatPhone >
            //    </ Phones >
            //</ Person >

            XElement _Person = new XElement("person");
            XElement _Address = new XElement("Address");
            XElement _Street = new XElement("Street");
            XElement _HouseNumber = new XElement("HouseNumber");
            XElement _FlatNumber = new XElement("FlatNumber");
            XElement _Phones = new XElement("Phones");
            XElement _MobilePhone = new XElement("MobilePhone");
            XElement _FlatPhone = new XElement("FlatPhone");

            XAttribute _StreetName = new XAttribute("Street",person.Street);
            XAttribute _HouseNumberName = new XAttribute("Street", person.HouseNumber);
            XAttribute _FlatNumberName = new XAttribute("Street", person.FlatNumber);
            XAttribute _MobilePhoneName = new XAttribute("Street", person.MobilePhone);
            XAttribute _FlatPhoneName = new XAttribute("Street", person.FlatPhone);
            XAttribute _PersonName = new XAttribute("Street", person.Name);

            _Person.Add(_Address, _Phones);

            _Address.Add(_Street, _HouseNumber, _FlatNumber);
            _Street.Add(_StreetName);
            _HouseNumber.Add(_HouseNumberName);
            _FlatNumber.Add(_FlatNumberName);
            
            _Phones.Add(_MobilePhone, _FlatPhone);
            _MobilePhone.Add(_MobilePhoneName);
            _FlatPhone.Add(_FlatNumberName);

            _Person.Save("Persons.xml");
            
        }
        static Person AddPerson()
        {

            Console.WriteLine("Добавление личности");
            Console.WriteLine("Введите ФИО:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите улицу");
            string street = Console.ReadLine();

            Console.WriteLine("Введите номер дома");
            int houseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер квартиры");
            int flatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите мобильный номер телефона");
            string mobilePhone = Console.ReadLine();

            Console.WriteLine("Введите домашный номер телефона");
            string flatPhone = Console.ReadLine();

            Console.WriteLine("\n Личность добавлена!");
            Person person = new Person(name, mobilePhone, flatPhone, street, houseNumber, flatNumber);
            Console.ReadKey();
            return person;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public string MobilePhone { get; set; }
        public string FlatPhone { get; set; }

        public Person(string name, string mobilePhone, string flatPhone, string street, int houseNumber, int flatNumber)
        {
            Name = name;
            MobilePhone = mobilePhone;
            FlatPhone = flatPhone;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }
    }
}
