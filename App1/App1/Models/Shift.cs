using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class Shift // Определение публичного класса Shift
    {
        public int Number { get; set; } // Свойство Number для хранения номера смены
        public string ShiftName { get; set; } // Свойство ShiftName для хранения названия смены
        public string Start { get; set; } // Свойство Start для хранения времени начала смены
        public string End { get; set; } // Свойство End для хранения времени окончания смены
    }
}