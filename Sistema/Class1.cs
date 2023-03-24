namespace Sistema
{
    internal class Class1
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola estudiantes de programación");
        }
    }

    public class Class2
    {
        void Mensaje()
        {
            Class1 c = new Class1();
            c.Mensaje();
        }
    }


}