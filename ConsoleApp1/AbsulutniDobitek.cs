using System;
namespace LoterijaNP
{
	public class AbsulutniDobitek : Dobitek
	{

		private int vrednostDobitka;

		public int VrednostDobitka { get { return vrednostDobitka; } set { vrednostDobitka = value; } }

        public AbsulutniDobitek(int steviloIzzrebanih, int vrednostDobitka) : base(steviloIzzrebanih)
		{
            VrednostDobitka = vrednostDobitka;
        }

        public AbsulutniDobitek()
		{
		}
	}
}

