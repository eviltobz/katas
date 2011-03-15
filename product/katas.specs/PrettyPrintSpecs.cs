using developwithpassion.specifications.rhino;
using Machine.Specifications;

namespace katas.specs
{
    public class PrettyPrintSpecs
    {
        public abstract class concern : Observes<PrettyPrint>
        {

        }

        [Subject(typeof(PrettyPrint))]
        public class when_displaying_an_empty_path //: concern
        {
            //Because b = () =>
            //    result = sut.PrintPath();

            //It should_say_hello = () =>
            //    result.ShouldEqual("Hello World");


            //static string result;

        }
    }

    public class PrettyPrint
    {
    }
}
