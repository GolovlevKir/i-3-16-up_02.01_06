using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MenuAnimation
{
    class ChangeColor
    {
        
    }

    class LeftSideColor
    {
        public delegate void SelectColor(Color Color); //Делегат, принимающий номер теста
        public static SelectColor SelectedColor; //Событие, обрабатывющее выбор теста
    }

    class TopColor
    {
        public delegate void SelectColor(Color Color); //Делегат, принимающий номер теста
        public static SelectColor SelectedColor; //Событие, обрабатывющее выбор теста
    }

    class CenterColor
    {
        public delegate void SelectColor(Color Color); //Делегат, принимающий номер теста
        public static SelectColor SelectedColor; //Событие, обрабатывющее выбор теста
    }

    class EqpColor
    {
        public delegate void SelectColor(Color Color); //Делегат, принимающий номер теста
        public static SelectColor SelectedColor; //Событие, обрабатывющее выбор теста
    }
}
