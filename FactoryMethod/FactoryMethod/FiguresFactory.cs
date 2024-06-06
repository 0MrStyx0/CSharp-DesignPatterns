using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IFactory
    {
        public Figures Create();
    }

    public class Figure1Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure1();
        }
    }

    public class Figure2Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure2();
        }
    }

    public class Figure3Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure3();
        }
    }

    public class Figure4Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure4();
        }
    }

    public class Figure5Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure5();
        }
    }

    public class Figure6Factory : IFactory
    {
        public Figures Create()
        {
            return new Figure6();
        }
    }
}
