using System;
using System.Xml.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            Console.Write("Введите ФИО: ");
            string fio = Console.ReadLine();
            Console.Write("Введите улицу: ");
            string street = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            string houseNum = Console.ReadLine();
            Console.Write("Введите номер квартиры: ");
            string flatNum = Console.ReadLine();
            Console.Write("Введите мобильный телефон: ");
            string mobile = Console.ReadLine();
            Console.Write("Введите домашний телефон: ");
            string flatPhone = Console.ReadLine();

            XElement person = new XElement("Person");
            XAttribute name = new XAttribute("name", fio);
            person.Add(name);
            XElement adress = new XElement("Adress");
            XElement street_xml = new XElement("Street", street);
            XElement houseNum_xml = new XElement("HouseNumber", houseNum);
            XElement flatNum_xml = new XElement("FlatNumber", flatNum);
            adress.Add(street_xml);
            adress.Add(houseNum_xml);
            adress.Add(flatNum_xml);
            
            XElement phones = new XElement("Phones");
            XElement mobile_xml = new XElement("MobilePhone", mobile);
            XElement flatPhone_xml = new XElement("FlatPhone", flatPhone);
            phones.Add(mobile_xml);
            phones.Add(flatPhone_xml);

            person.Add(adress);
            person.Add(phones);

            xdoc.Add(person);
            xdoc.Save(@"D:\Study\Skillbox_C\Урок 8 Коллекции\Homework_8\Task_4\Person.xml");

        }
    }
}
