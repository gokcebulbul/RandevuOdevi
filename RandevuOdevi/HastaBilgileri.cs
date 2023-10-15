using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandevuOdevi
{
   public class HastaBilgileri
    {
		private string _hastaTC;

		public string HastaTC
		{
			get { return _hastaTC; }

			set 
			{
				if (value.Length > 11)
				{
					MessageBox.Show("Tc kimlik numarası 11 haneden büyük olamaz");
				}
				_hastaTC = value; 
			}
		}
        public string AdSoyad { get; set; }

        public string Telefon { get; set; }

        public string Cinsiyet { get; set; }

        public string Poliklinik { get; set; }

        public DateTime Tarih { get; set; }

		public string RandevuSaat { get; set; }




    }
}
