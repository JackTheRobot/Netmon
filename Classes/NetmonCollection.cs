namespace Netmon.Classes
{
    public class NetmonCollection
    {
        public Netmon[] Netmons { get; private set; } = new Netmon[5];

        public void AddNetmon(Netmon netmon)
        {
            for (int i = 0; i < Netmons.Length; i++)
            {
                if (Netmons[i] == null)
                {
                    Netmons[i] = netmon;
                    break;
                }

                Console.WriteLine("Netmon Collection full");
            }
        }

        public void RemoveNetmon(Netmon netmon)
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

        public bool CollectionFull()
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
