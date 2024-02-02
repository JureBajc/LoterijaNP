using System;
namespace LoterijaNP
{
	 class LoterijaSlovenije
	{

		private List<Loterija> loterije;

		public List<Loterija> Loterije { get { return loterije; } set { loterije = value; } }

        public LoterijaSlovenije(List<Loterija> loterije)
        {
            Loterije = loterije;
        }

        public LoterijaSlovenije()
		{
		}
	}
}

