namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new List<Course>();

        static Repository()
        {
            _courses = new List<Course>
            {
                    new Course() { id = 1, Title = "C++", description = "C++ is a programming language", Image="1.jpeg" },
                    new Course() { id = 2, Title = "Java", description = "Java is a programming language", Image="2.jpg" },
                    new Course() { id = 3, Title = "Python", description = "Python is a programming language", Image="3.jpg" },
                    new Course() { id = 4, Title = "Matlab", description = "Matlab is a programming language", Image="2.jpg" }
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? getById(int? Id)
        {
            return _courses.FirstOrDefault(x => x.id == Id);
        }
    }
}
