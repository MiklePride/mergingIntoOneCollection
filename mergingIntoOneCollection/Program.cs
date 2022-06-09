class program
{
    static void Main(string[] args)
    {
        string[] array1 = { "1", "2", "1" };
        string[] array2 = { "3", "2" };
        List<string> merginglist = new List<string>();
        merginglist.AddRange(array1);
        merginglist.AddRange(array2);

        CheckForRepetitions(merginglist);

        for (int i = 0; i < merginglist.Count; i++)
        {
            Console.WriteLine(merginglist[i]);
        }
    }

    static void CheckForRepetitions(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 1; j < list.Count; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else if (list[i] == list[j])
                {
                    list.RemoveAt(j);
                }
            }
        }
    }
}