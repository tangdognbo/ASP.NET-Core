namespace core.test.Models
{
    //单线程单例
    public class Singleton
    {
        private Singleton() { }
        private static Singleton Instance = null;
        public static Singleton CreateInstance() {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
        }
    }

    public class Singleton1
    {
        private Singleton1() { }
        private static Singleton1 Instance = null;
        private static readonly object Singleton1_lock = new object();
        public static Singleton1 CreateInstance()
        {
            lock (Singleton1_lock) { // 保证方法快只要一个进程可进入
                if (Instance == null)
                    Instance = new Singleton1();
                
            }

            return Instance;
        }
    }

    //双if加锁
    public class Singleton2
    {
        private Singleton2() { }
        private static Singleton2 Instance = null;
        private static readonly object Singleton1_lock = new object();
        public static Singleton2 CreateInstance()
        {
            if (Instance == null)
            {
                lock (Singleton1_lock)
                { // 保证方法快只要一个进程可进入
                    if (Instance == null)
                        Instance = new Singleton2();

                }
            }

            return Instance;
        }
    }

    //构造函数实现
    public class Singleton3
    {
        //只调用一次初始化
        static Singleton3() {  
            Instance = new Singleton3();
        }
        private static Singleton3 Instance = null;
        public static Singleton3 CreateInstance()
        {
            return Instance;
        }
    }


    public class Singleton4
    {
        private static Singleton4 Instance = new Singleton4();
        public static Singleton4 CreateInstance()
        {
            return Instance;
        }
    }

}
