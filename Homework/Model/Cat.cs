using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat 
    {
        private string _name = "Empty";
        private string _age;
        private int _helth = 5;
        public Cat(string age, CatColor color)
        {
            Color = color;
            _age = age;
        }


        public string Name
        {
            get { return _name; }

            set
            {
                if (_name == "Empty")
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Имя уже было задано");
                }
            }
        }
        public string Age
        {
            get { return _age; }
        }

        public string CurrentColor
        {
            
            get
            {
                if (_helth >= 5)
                    return Color.HealthyColor;
                else
                {
                    return Color.SickColor;
                }
            }
        }

        public CatColor Color { get; set; }

        public void Punish()
        {
            _helth--;
        }

        public void Feed()
        {
            _helth++;
        }



        

        
        

    }
}
