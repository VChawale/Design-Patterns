 using System;
using System.Collections.Generic;

namespace Design_Patterns.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> componentList = new List<IComponent>();
        public void RenderComponent()
        {
            Console.WriteLine("Rendering Components from Group");
            foreach (var component in componentList)
            {
                component.RenderComponent();
            }
        }

        public void AddComponent(IComponent component)
        {
            componentList.Add(component);
        }
    }
}