namespace Zoo
{
    public interface IAnimal
    {
        string Name { get; }
        void MakeSound();
    }

    public interface ITrainable : IAnimal
    {
        string Train();
    }
}
