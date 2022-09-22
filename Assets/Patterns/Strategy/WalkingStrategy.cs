using UnityEngine;

namespace Patterns.Strategy
{
    public class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Debug.Log("Walking Route Created");
        }
    }
}
