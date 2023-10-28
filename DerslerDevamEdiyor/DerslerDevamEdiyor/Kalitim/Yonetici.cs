using System;
namespace DerslerDevamEdiyor.Kalitim
{
	public class Yonetici : Calisan
	{
		private double _departamanKar;

		public double DepertmanKar
		{
			get { return _departamanKar; }
			set { _departamanKar = value; }
		}
	}
}

