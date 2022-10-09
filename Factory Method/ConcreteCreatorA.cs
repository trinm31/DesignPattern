namespace Factory_Method
{
    public class ConcreteCreatorA: Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}