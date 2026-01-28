using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Helpers
{
    public sealed class Navigate
    {
        private static Navigate _instance;
        private static readonly object _lock = new object();

        public static Navigate Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Navigate();
                    }
                }
                return _instance;
            }
        }

        private readonly Stack<UserControl> _stack;
        private readonly Dictionary<Type, UserControl> _cachedControls;

        private Navigate()
        {
            _stack = new Stack<UserControl>();
            _cachedControls = new Dictionary<Type, UserControl>();
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

        /// <summary>
        /// Cache một UserControl để tái sử dụng (dùng cho các màn hình không cần tạo mới mỗi lần)
        /// </summary>
        public void CacheControl(UserControl control)
        {
            if (control != null)
            {
                var type = control.GetType();
                if (!_cachedControls.ContainsKey(type))
                {
                    _cachedControls[type] = control;
                }
            }
        }

        /// <summary>
        /// Lấy UserControl từ cache hoặc tạo mới nếu chưa có
        /// </summary>
        public T GetOrCreateCached<T>() where T : UserControl, new()
        {
            var type = typeof(T);
            if (!_cachedControls.ContainsKey(type))
            {
                _cachedControls[type] = new T();
            }
            return (T)_cachedControls[type];
        }

        /// <summary>
        /// Kiểm tra xem có UserControl nào đang được cache không
        /// </summary>
        public bool HasCached<T>() where T : UserControl
        {
            return _cachedControls.ContainsKey(typeof(T));
        }

        /// <summary>
        /// Xóa cache của một loại UserControl cụ thể
        /// </summary>
        public void ClearCache<T>() where T : UserControl
        {
            var type = typeof(T);
            if (_cachedControls.ContainsKey(type))
            {
                var control = _cachedControls[type];
                control?.Dispose();
                _cachedControls.Remove(type);
            }
        }

        /// <summary>
        /// Xóa toàn bộ cache
        /// </summary>
        public void ClearAllCache()
        {
            foreach (var control in _cachedControls.Values)
            {
                control?.Dispose();
            }
            _cachedControls.Clear();
        }
    }
}