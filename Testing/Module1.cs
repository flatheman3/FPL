using Nancy;

namespace Testing
{
    public class Module1 : NancyModule
    {
        public Module1()
        {
            Get["/"] = _ => "Hello!";
        }
    }
}