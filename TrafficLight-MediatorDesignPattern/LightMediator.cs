using System;
using System.Collections.Generic;

namespace TrafficLight_MediatorDesignPattern
{
    public class LightMediator
    {
        private List<Light> _trafficLights = new List<Light>();

        public void AddLight(Light light)
        {
            _trafficLights.Add(light);
        }
        
        public void RemoveLight(Light light)
        {
            _trafficLights.Remove(light);
        }

        public void NotifyMediator(Light light)
        {
            Console.WriteLine($"{light.Color} is turn {light.GetCurrentState()}");
            if (light.GetCurrentState() == State.ON)
            {
                TurnOffAllOtherLight(light);
            }
        }

        private void TurnOffAllOtherLight(Light light)
        {
            foreach (var lightInGroup in _trafficLights)
            {
                if (!light.Equal(lightInGroup))
                {
                    lightInGroup.TurnOff();
                }
            }
        }
    }
}