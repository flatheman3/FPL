using Nancy;

namespace Testing
{
    public class Module1 : NancyModule
    {
        
        public Module1()
        {
            Get["/Players"] = _ => "Hello";
            Get["/Players/{id}"] = parameters => "Hello" + parameters.id;

        }
    }
}