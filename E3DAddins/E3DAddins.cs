using Aveva.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E3DAddins
{
    public class E3DAddins : IAddin
    {
        // Реализуем свойство Описание, которое будет возвращать описание этого Дополнения.
        public string Description
        {
            get { return "E3D Addin"; }
        }

        // Реализуем свойство Имя, которое будет возвращать Название этого Дополнения
        public string Name
        {
            get { return "E3D Addin"; }
        }

        // Реализуем метод Старт. Он будет вызван при запуске Дополнения
        public void Start(ServiceManager serviceManager)
        {
            // Название указано явно так как в другой библиотеке есть подобный класс
            System.Windows.Forms.MessageBox.Show("Hello World");
        }

        // Реализуем метод Стоп. Он будет вызван при закрытии Дополнения
        public void Stop()
        {
           
        }
    }
}
