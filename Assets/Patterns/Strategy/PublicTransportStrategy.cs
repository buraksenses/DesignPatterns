using UnityEngine;

namespace Patterns.Strategy
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Debug.Log("Public Transport Route Created");
        }
    }
}
