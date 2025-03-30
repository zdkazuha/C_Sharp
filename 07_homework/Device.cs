using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_homework
{
    internal abstract class Device
    {
        protected Device()
        {}
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
    }
}
