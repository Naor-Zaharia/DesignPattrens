using System;
using System.Reflection;

namespace WindowsFacebookLogic
{
    public static class Singleton<T>
       where T : class
    {
        private static volatile T s_Instance;
        private static object s_LockObject = new object();

        public static T Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            ConstructorInfo constructor = null;

                            try
                            {
                                constructor = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
                            }
                            catch (Exception exception)
                            {
                                throw new Exception(null, exception);
                            }

                            if (constructor == null || constructor.IsAssembly)
                            {
                                throw new Exception(string.Format("{0} '{1}'.", LogicMessages.k_SingletonNonConstMsg, typeof(T).Name));
                            }

                            s_Instance = constructor.Invoke(null) as T;
                        }
                    }
                }

                return s_Instance;
            }
        }
    }
}
