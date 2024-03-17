using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2.Tests
{
    public class PersonaTest
    {
        [Fact] //Inyectar codigo al momento de ejecutar
        public void Test1()
        {
            var p1 = new Persona();
            p1.Nombre = "Test";
            p1.Apellido = "Demo";

            Assert.Equal("Test", p1.Apellido);
        }
    }
}