/********************************************
Name: EventDispatcher.cs
Purpose: Event system
Notes: 
********************************************/

using System.Reflection;

namespace BudgetPlanner
{
    public class WeakHandler
    {
        private readonly WeakReference m_TargetReference;
        private readonly MethodInfo m_Method;

        public WeakHandler(Delegate handler)
        {
            m_TargetReference = new WeakReference(handler.Target);
            m_Method = handler.Method;
        }

        public bool Invoke(object InEvent)
        {
            var target = m_TargetReference.Target;

            if (target == null)
                return false; 

            m_Method.Invoke(target, new object[] { InEvent });
            return true;
        }

        public bool IsAlive => m_TargetReference.IsAlive;
    }


    public class EventDispatcher
    {
        private readonly Dictionary<Type, List<WeakHandler>> m_Handlers = new();

        public void Subscribe<TEvent>(Action<TEvent> InHandler)
        {
            var type = typeof(TEvent);
            if (!m_Handlers.ContainsKey(type))
            {
                m_Handlers[type] = new List<WeakHandler>();
            }

            m_Handlers[type].Add(new WeakHandler(InHandler));
        }

        public void Publish<TEvent>(TEvent InEvent)
        {
            if (!m_Handlers.TryGetValue(typeof(TEvent), out var list))
                return;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsAlive)
                {
                    list[i].Invoke(InEvent);
                }
                else
                {
                    list.RemoveAt(i);
                }
            }
        }
    }

}
