using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreApp.Model
{
    class Aboniment
    {
        /// <summary>
        /// Имя абонимента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание абонимента
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Количевство дней до окончание абонимента
        /// </summary>
        public int DaysСount { get; set; }
        /// <summary>
        /// Количевство групповых занятий
        /// </summary>
        public int GroupLessonCount { get; set;}
        

    }
}
