namespace Netmon.Classes
{
    public static class NetmonCollection
    {
        public static Netmon[] Netmons { get; private set; } = new Netmon[5];

        public static void AddNetmon(Netmon netmon)
        {
            for (int i = 0; i < Netmons.Length; i++)
            {
                if (Netmons[i] == null)
                {
                    Netmons[i] = netmon;
                    return;
                }
            }

            Console.WriteLine("Netmon Collection full");
        }

        public static void RemoveNetmon(Netmon netmon)
        {
            bool removed = false;

            for (int i = 0; i < Netmons.Length;i++)
            {
                if (Netmons[i] == netmon)
                {
                    removed = true;
                    Netmons[i] = null!;
                    break;
                }
            }

            if (!removed) Console.WriteLine("Attempted to remove Netmon that wasn't in collection");
        }

        public static bool CollectionFull()
        {
            bool full = true;

            for (int i = 0; i < Netmons.Length; i++)
            {
                if (Netmons[i] == null)
                {
                    full = false;
                    break;
                }
            }

            return full;
        }
    }
}
