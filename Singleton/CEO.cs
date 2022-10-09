namespace Singleton
{
    public class CEO
    {
        private static CEO _INSTANCE;
        private CEO(){}

        public static CEO GetInstance()
        {
            if (_INSTANCE == null)
            {
                _INSTANCE = new CEO();
            }

            return _INSTANCE;
        }
    }
}