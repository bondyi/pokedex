namespace Pokedex
{
    internal class PageHandler
    {
        internal int PageLimit { get; }
        internal int Offset { get; private set; }

        internal PageHandler(int pageLimit, int offset)
        {
            PageLimit = pageLimit;
            Offset = offset;
        }

        internal void NextPage() => Offset += PageLimit;

        internal bool PreviousPage()
        {
            Offset -= PageLimit;

            return Offset != 1;
        }
    }
}
