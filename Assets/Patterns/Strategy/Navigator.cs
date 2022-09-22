using System;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Navigator : MonoBehaviour
    {
        private IRouteStrategy _routeStrategy;

        private void SetStrategy(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SetStrategy(new RoadStrategy());
                _routeStrategy.BuildRoute();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                SetStrategy(new WalkingStrategy());
                _routeStrategy.BuildRoute();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                SetStrategy(new PublicTransportStrategy());
                _routeStrategy.BuildRoute();
            }
                
        }
    }
}
