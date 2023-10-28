using System;
namespace DerslerDevamEdiyor.Kalitim
{
	public class Calisan
	{
		protected int _calisanNo;
		protected string _calisanAd;
		protected double _calisanMaas;

		public int CalisanNo
		{
			get { return _calisanNo; }
			set { _calisanNo = value; }
		}

		public string CalisanAd
		{
			get { return _calisanAd; }
			set { _calisanAd = value; }
		}

		public double CalisanMaas
		{
			get { return _calisanMaas; }
			set { _calisanMaas = value; }
		}
	}
}

