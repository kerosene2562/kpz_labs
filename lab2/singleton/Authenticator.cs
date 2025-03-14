namespace lab2.singleton
{
    sealed class Authenticator
    {
        private static Authenticator? _instance;
        private static object _refObj = new object();

        private Authenticator()
        {
            Console.WriteLine("authenticator created");
        }

        public static Authenticator GetAuth()
        {
            if(Authenticator._instance == null)
            {
                lock(Authenticator._refObj)
                {
                    if(Authenticator._instance == null)
                    {
                        Authenticator._instance = new Authenticator();
                    }
                }
            }
            return Authenticator._instance;
        }
    }
}