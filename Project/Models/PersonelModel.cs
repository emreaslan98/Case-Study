using Project.Entity;
using ProjectUI.Models;

namespace Project.UI.Models
{
    public class PersonelModel
    {
        
        public Personel Personel { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
        public List<UniversityModel> Universities { get; set; }
    }
}
