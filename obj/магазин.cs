using obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Магазин : ISearchable
    {
        public List<Товар> Товари { get; set; }
        public List<Користувач> Користувачі { get; set; }
        public List<Замовлення> Замовлення { get; set; }

        public Магазин()
        {
            Товари = new List<Товар>();
            Користувачі = new List<Користувач>();
            Замовлення = new List<Замовлення>();
        }

        public void ДодатиТовар(Товар товар)
        {
            Товари.Add(товар);
        }

        public void ДодатиКористувача(Користувач користувач)
        {
            Користувачі.Add(користувач);
        }

        public void ЗробитиЗамовлення(Користувач користувач, List<Товар> товари, int кількість)
        {
            var замовлення = new Замовлення(товари, кількість);
            користувач.ІсторіяПокупок.Add(замовлення);
            Замовлення.Add(замовлення);
        }

        public List<Товар> Пошук(decimal мінімальнаЦіна, decimal максимальнаЦіна, string категорія)
        {
            return Товари.Where(товар => товар.Ціна >= мінімальнаЦіна && товар.Ціна <= максимальнаЦіна &&
                (string.IsNullOrEmpty(категорія) || товар.Категорія.Equals(категорія, StringComparison.OrdinalIgnoreCase))).ToList();
        }
    }
}