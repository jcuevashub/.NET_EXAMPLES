// 1. Singleton
// El patrón Singleton asegura que una clase tenga una única instancia y proporciona un punto de acceso global a esa instancia. Es útil cuando solo se necesita una instancia de una clase, como en el caso de servicios de logging.

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() {}

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"Log: {memessage}");
    }
}