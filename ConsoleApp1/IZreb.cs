﻿using System;
namespace LoterijaNP
{
	public interface IZreb
	{
		void vplaciloKombinacije(List<Kombinacija> listKombinacija,Kombinacija kombinacija);
		void nakljucnaVplacila(Zreb zreb);
		void priprava();
		void izvedba(Zreb zreb);

	}
}

