//

static void Main(string[] args)
{
    Container.Nested nested = new Container.Nested();

    Container1 container1 = new Container1();

}

public class Container
{
    public class Nested
    {
        private Container? parent;
        public Nested()
        {

        }

        public Nested(Container container)
        {
            this.parent = container;
        }
    }
}

public class Container1
{
    class Nested1
    {
        Nested1() { }
    }
}