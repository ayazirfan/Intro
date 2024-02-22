
using Intro.Business;
using Intro.Entities;



//Course[] courses = {course1, course2, course3};


CourseManager courseManager = new CourseManager();
Course [] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdnetity = "412343453";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdnetity = "412343455663";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "1234334";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "23411";
customer3.TaxNumber = "264354456";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abfjsh";
customer4.CustomerNumber = "93657";
customer4.TaxNumber = "9939204982";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}





