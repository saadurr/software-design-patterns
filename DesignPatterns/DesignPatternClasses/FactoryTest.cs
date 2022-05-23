using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class FactoryTest
    {
        static public void Test()
        {
            Shape s1 = FactoryPatternShape.GetShape("circle");
            s1.Draw();
            Shape s2 = FactoryPatternShape.GetShape("triangle");
            s2.Draw();
            Shape s3 = FactoryPatternShape.GetShape("oval");
            
        }
    }
}
