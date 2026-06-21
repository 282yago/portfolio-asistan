namespace KisiselAsistan.ViewModels
{
    public class HakkimdaViewModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public string Universite { get; set; }
        public string Unvan { get; set; }
        public string Ozet { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string GitHub { get; set; }
        public string İnstagram { get; set; }
        public string LinkedIn { get; set; }

        public List<string> Teknolojiler { get; set; }
        public List<ProjeViewModel> Projeler { get; set; } 
    }
}
