using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Товар
    {
        public string Назва { get; set; }
        public decimal Ціна { get; set; }
        public string Опис { get; set; }
        public string Категорія { get; set; }

        public Товар(string назва, decimal ціна, string опис, string категорія)
        {
            Назва = назва;
            Ціна = ціна;
            Опис = опис;
            Категорія = категорія;
        }
    }
    public interface ISearchable
    {
        List<Товар> Пошук(decimal мінімальнаЦіна, decimal максимальнаЦіна, string категорія);
    }
}