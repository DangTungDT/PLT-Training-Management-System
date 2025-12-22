using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.Helpers
{
    public sealed class Navigate
    {
        private static Navigate _instance;

        public static Navigate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Navigate();
                return _instance;
            }
        }

        private readonly Stack<UserControl> _stack;

        private Navigate()
        {
            _stack = new Stack<UserControl>();
        }

        public void Push(UserControl control)
        {
            if (control != null)
                _stack.Push(control);
        }

        public UserControl Pop()
        {
            return _stack.Count > 0 ? _stack.Pop() : null;
        }

        public UserControl Peek()
        {
            return _stack.Count > 0 ? _stack.Peek() : null;
        }
        public void PushIfNotSame(UserControl control)
        {
            if (_stack.Count == 0 || _stack.Peek() != control)
                _stack.Push(control);
        }
        public int Count => _stack.Count;

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
