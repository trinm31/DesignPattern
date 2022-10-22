using System;
using System.Threading;

namespace TrafficLight_MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var lightMediator = new LightMediator();

            Light[] lights =
            {
                new Light("Red", lightMediator),
                new Light("Green", lightMediator),
                new Light("Yellow", lightMediator)
            };

            int currentLightIndex = 0;
            Light light;
            while (true)
            {
                if (currentLightIndex >= lights.Length)
                {
                    currentLightIndex = 0;
                }

                light = lights[currentLightIndex];
                light.TurnOn();
                
                Thread.Sleep(3000);
                
                currentLightIndex++;
            }
        }
    }
}