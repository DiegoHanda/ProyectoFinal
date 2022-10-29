//--------------------------------------------------------------------------------
// <copyright file="TestExample.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using ClassLibrary;
using NUnit.Framework;


namespace Tests
{
    /// <summary>
    /// Prueba de la clase <see cref=""/>.
    /// </summary>
    [TestFixture]
    public class TestExample
    {
       
        private Trabajador trabajador;
        private Empleador empleador;
        private Administrador administrador;
        

        /// <summary>
        /// Crea un tren para probar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.train = new Train();
            this.Trabajador = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
            this.Empleador = new Empleador("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
            this.Administrador= new Administrador("1864927-8", "Elje", "MrFe@gmail.com");
            this.CategoriasManager = new CategoriasManager();
            this.OfertasManager = new OfertasManager();
        }

        /// <summary>
        /// Prueba que el tren arranque.
        /// </summary>
        [Test]
        public void StartTrainTest()
        {
            Assert.NotNull(this.train);
            this.train.StartEngines();
            Assert.True(this.train.IsEngineStarted);
        }

        [Test]
        public void AddCategoriaTest()
        {
            Assert.NotNull(this.Administrator);
            Assert.NotNull(CategoriasManager);
            this.AddCategoriasManager.AddCategoria("cat1");
            Assert.True(CategoriasManager.Lista.contains("cat1"));
        }

        /// <summary>
        /// Prueba que el tren se detenga.
        /// </summary>
        [Test]
        public void StopTrainTest()
        {
            Assert.NotNull(this.train);
            this.train.StartEngines();
            this.train.StopEngines();
            Assert.False(this.train.IsEngineStarted);
        }
    }
}