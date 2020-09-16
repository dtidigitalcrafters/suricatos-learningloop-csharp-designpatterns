using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        public interface IBuilder
        {
            void BuildWalls();

            void BuildDoor();

            void BuildWindows();

            void BuildRoof();

            void BuildGarage();

            void BuildGarden();

            void BuildPool();
        }

        public class ConcreteBuilder : IBuilder
        {
            private House _house = new House();

            public ConcreteBuilder()
            {
                this.Reset();
            }

            public void Reset()
            {
                this._house = new House();
            }

            public void BuildWalls()
            {
                this._house.Add("Walls");
            }

            public void BuildDoor()
            {
                this._house.Add("Door");
            }

            public void BuildWindows()
            {
                this._house.Add("Windows");
            }

            public void BuildRoof()
            {
                this._house.Add("Roof");
            }

            public void BuildGarage()
            {
                this._house.Add("Garage");
            }

            public void BuildGarden()
            {
                this._house.Add("Garden");
            }

            public void BuildPool()
            {
                this._house.Add("Pool");
            }


            public House GetHouse()
            {
                House result = this._house;

                this.Reset();

                return result;
            }

        }

        public class House
        {
            private List<object> _parts = new List<object>();

            public void Add(string part)
            {
                this._parts.Add(part);
            }

            public string ListParts()
            {
                string str = string.Empty;

                for (int i = 0; i < this._parts.Count; i++)
                {
                    str += this._parts[i] + ", ";
                }

                str = str.Remove(str.Length - 2);

                return "House parts: " + str + "\n";
            }
        }

        public class ExecuteBuilding
        {
            private IBuilder _builder;

            public IBuilder Builder
            {
                set { _builder = value; }
            }

            public void buildBasicHouse()
            {
                this._builder.BuildWalls();
                this._builder.BuildDoor();
                this._builder.BuildWindows();
                this._builder.BuildRoof();
            }

            public void buildFullFeaturedHouse()
            {
                this._builder.BuildWalls();
                this._builder.BuildDoor();
                this._builder.BuildWindows();
                this._builder.BuildRoof();
                this._builder.BuildGarage();
                this._builder.BuildGarden();
                this._builder.BuildPool();
            }
        }

        static void Main(string[] args)
        {
            var director = new ExecuteBuilding();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Basic house: ");
            director.buildBasicHouse();
            Console.WriteLine(builder.GetHouse().ListParts());

            Console.WriteLine("\nStandard full featured house: ");
            director.buildFullFeaturedHouse();
            Console.WriteLine(builder.GetHouse().ListParts());

            Console.WriteLine("\nCustom house:");
            director.buildBasicHouse();
            builder.BuildGarden();
            Console.Write(builder.GetHouse().ListParts());
        }


    }
}
