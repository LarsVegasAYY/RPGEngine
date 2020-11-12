using System;
using System.Collections.Generic;
using System.Text;

namespace RPGEngine.Tools
{
    public class Path
    {
        public List<Position> Route { get; set; }
        public Path(List<Position> route)
        {
            Route = route;
        }
        public Position Next()
        {
            Position returnValue = Route[0];
            Route.RemoveAt(0);
            return returnValue;
        }
    }
}
