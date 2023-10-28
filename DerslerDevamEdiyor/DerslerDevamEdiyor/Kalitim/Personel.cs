using System;
namespace DerslerDevamEdiyor.Kalitim
{
	public class Personel : Calisan
	{
		private int _satisSayisi;
		public int SatisSayisi
		{
			get { return _satisSayisi; }
			set { _satisSayisi = value; }
		}
	}
}

