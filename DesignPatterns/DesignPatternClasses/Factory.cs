using System;
using System.Collections.Generic;
using System.Text;

/* Factory Pattern is a Creational Pattern.
 * 
 * The factory pattern is used in situations where you have to create more than one
 * identical object. This hides the instantiation logic from the client. 
 * 
 * In Factory pattern, we create object without exposing the creation logic to client and the client use the same common interface to create new type of object.
 * The idea is to use a static member-function (static factory method) which creates & returns instances, 
 * hiding the details of class modules from user.
 * 
 * 
 * The example demonstrates a simple factory class.
 * instead of having to make a change at every instance, we can
 * have a factory where we can make a single change if we want to change.
*/

namespace DesignPatterns
{
    public class FactoryPatternShape
    {
        public static Shape GetShape(string shape)
        {
            if (shape == "circle")
                return new Circle();
            else if (shape == "square")
                return new Square();
            else if (shape == "triangle")
                return new Triangle();
            else
                throw new Exception("Error! Unknown shape.");            
        }
    }

    public interface Shape
    {
        void Draw();
    }

    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }

    class Triangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }


}
