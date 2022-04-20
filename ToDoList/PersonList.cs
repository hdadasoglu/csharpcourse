namespace ToDoList
{
    public static class PersonList
    {
        public static List<Person> personList = new List<Person>();

        public static Person IsValid(int id){
            foreach (var item in PersonList.personList)
            {
                if (item.Id == id){
                    return item;
                }
            }
            return null;
        }
    }
}