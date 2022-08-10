namespace INECAUDIT
{
    internal class InecDataBase
    {
        static void Main(string[] args)
        {
            //LIST OF VOTERS IN ARRAY
            string[] RegVoters = { "Success", "Great", "Peter", "Favour", "Mike", "Success", "Loveth", "Joseph", "Peter", "Victor", "Godwin", "Jeff", "Success", "Olatunde", "Bolaji", "Peter", "Great" };
            Dictionary<string, int> Database = new Dictionary<string, int>();
            foreach (var item in RegVoters)
            {
                if (Database.ContainsKey(item)) 
                { 
                    Database[item] = Database[item] + 1;
                }
                else
                {
                    Database[item] = 1;
                }
            }
            //LIST OF DUPLICATES
            Console.WriteLine("Names and number of times registered");
            foreach (var item in Database)
            {
                if(item.Value > 1)
                {
                    Console.WriteLine(item.Key + ":" + item.Value);
                }
            }

            // INEC SHOULD USE THE HASHSET CONCEPT TO ENSURE DUPLICATES ARE REMOVED AND ENSURE DISTINCTIVENESS.
            //DISTINCT LIST
            Console.WriteLine("\n\nThe Distinctive List");
            HashSet<string> Distinctive = RegVoters.ToHashSet();
            foreach(var item in Distinctive)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}