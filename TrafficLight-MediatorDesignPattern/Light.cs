using System;
using System.Collections.Generic;

namespace TrafficLight_MediatorDesignPattern
{
    public class Light
    {
        public string Color { get; set; }
        private State _state;
        private readonly LightMediator _mediator;

        public Light(string color, LightMediator mediator)
        {
            Color = color;
            _state = State.OFF;
            _mediator = mediator;
            _mediator.AddLight(this);
        }

        public State GetCurrentState()
        {
            return _state;
        }

        public void TurnOn()
        {
            _state = State.ON;
            _mediator.NotifyMediator(this);
        }
        
        public void TurnOFF()
        {
            _state = State.OFF;
            _mediator.NotifyMediator(this);
        }
        
        public bool Equal(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Light light = (Light)obj;
            return Color.Equals(light.Color);
        }

        public void TurnOff()
        {
            Console.WriteLine(Color + " is Off");
        }
    }
}