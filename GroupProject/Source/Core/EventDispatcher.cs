/********************************************
Name: EventDispatcher.cs
Purpose: Event system
Notes: 
********************************************/

using System.Reflection;

namespace BudgetPlanner
{
    //------------------------------------------------------------------------------
    // [1] Holds an event handler and a weak reference to the object it belongs to
    // If the object is deleted, then the dispatcher can check the reference and delete
    // it accordingly
    //------------------------------------------------------------------------------
    public class WeakHandler
    {
        private readonly WeakReference m_TargetReference;
        private readonly MethodInfo m_Method;

        public WeakHandler(Delegate handler)
        {
            m_TargetReference = new WeakReference(handler.Target);
            m_Method = handler.Method;
        }

        // Run the event handlers function
        public bool Invoke(object InEvent)
        {
            var target = m_TargetReference.Target;

            if (target == null)
                return false; 

            m_Method.Invoke(target, new object[] { InEvent } /*parameters*/);
            return true;
        }

        public bool IsAlive() { return m_TargetReference.IsAlive; }
    }

    //---------------------------------------------------------------------------------------------------------------------
    // [2] Holds a list of event subscribers/handlers and interates over each one with respect to the event it suscribed to 
    // and runs its callback method when that event is published using the Publish(0 method
    //---------------------------------------------------------------------------------------------------------------------
    public class EventDispatcher
    {
        // List of subscribers by event type
        private readonly Dictionary<Type, List<WeakHandler>> m_Handlers = new();

        // Add to subscribers
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
            // if no events subscribed to type return
            if (!m_Handlers.TryGetValue(typeof(TEvent), out var list))
                return;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsAlive())
                {
                    list[i].Invoke(InEvent);
                }
                else
                {
                    // Delete handler if its no longer alive
                    list.RemoveAt(i);
                }
            }
        }
    }

}