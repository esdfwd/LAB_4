using obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Замовлення
    {
        public List<Товар> Товари { get; set; }
        public int Кількість { get; set; }
        public decimal ЗагальнаВартість { get; set; }
        public string Статус { get; set; }

        public Замовлення(List<Товар> товари, int кількість)
        {
            Товари = товари;
            Кількість = кількість;
            ЗагальнаВартість = товари.Sum(товар => товар.Ціна) * кількість;
            Статус = "Очікує на відправку";
        }
    }
}