
using Intro.Business;
using Intro.Entities;



//Course[] courses = {course1, course2, course3};


CourseManager courseManager = new CourseManager();
Course [] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}








