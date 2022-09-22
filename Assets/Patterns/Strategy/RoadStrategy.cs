using UnityEngine;

namespace Patterns.Strategy
{
    public class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Debug.Log("Road Route Created");
        }
    }
}
