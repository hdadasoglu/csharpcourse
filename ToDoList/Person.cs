namespace ToDoList
{
    public class Person
    {
        private string name;
        private int age;
        private int id;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }

        // Constructor
        public Person(string name, int age, int id){
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}