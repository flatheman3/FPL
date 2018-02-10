using Nancy;

namespace TestNancy
{
    public class Module1 : NancyModule
    {
        public Module1()
        {
            Get["/"] = parameter => "Hello!";
        }
    }
}