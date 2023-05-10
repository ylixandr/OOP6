using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SausageSimple
{   // Класс "Колбаса"

    class Sausage
    {
        string name;    // наменование колбасы
        double mass;    // масса (вес, кг)
        double price;   // цена за 1 кг  

        // Конструктор. Задает наименование колбасы и начальный вес
        // Здесь мы уже более профессионально оформляем конструктор:
        // в списке параметров используем те же имена, что и имена атрибутов.
        // А чтобы компилятор мог разобраться, где имя параметра, а где 
        // имя атрибута, имена перед именем атрибута ставится 
        // ключевое слово this - ссылка объекта на самого себя.        
        public Sausage(string name, double mass, double price)
        {
            this.name = name;
            this.mass = mass;
            this.price = price;
        }

        // Свойство только для чтения
        public string Name
        {
            get { return name; }
        }

        // Свойство только для чтения
        public double Mass
        {
            get { return mass; }
        }

        // Свойство для чтения и записи
        public double Price
        {
            get { return price; }
            set { price = value; }

            // Если мы хотим блокировать задание отрицательной цены,
            // то для значения value устраиваем проверку - вот
            // другой вариант для set : раскомментируйте и проверьте
            //set
            //{
            //    if (value <= 0)
            //        Console.WriteLine("\nЦена не может быть отрицательной");
            //    else price = value;
            //}
        }

        // Метод: отрезать порцию колбаски
        // Если запрашиаемая порция больше исходного куска, метод возвращает 0 (ноль)
        public double CutPortion(double portion)
        {
            if (portion < mass)
            {
                mass = mass - portion;
                return portion;
            }
            else return 0;
        }

        // Метод - печать сведений о куске колбасы
        public void Info()
        {
            Console.WriteLine("\nКолбаса.Наименование: {0}, вес: {1} кг, цена за 1 кг: {2} руб",
                name, mass, price);
        }

    } // Конец описания класса  class Sausage

}