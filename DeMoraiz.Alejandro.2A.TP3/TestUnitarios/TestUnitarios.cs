using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
using Excepciones;

namespace TestUnitarios
{


    /// <summary>
    /// Clase con test Unitarios
    /// </summary>
    [TestClass]
    public class TestUnitarios
    {

        /// <summary>
        /// Test que verifica que una jornada sea diferente de Null
        /// </summary>

        [TestMethod]
        public void ValidarJornadaDiferenteDeNull()
        {
            Profesor profesorSPD = new Profesor(957, "Octavius", "Villegus", "39068081", Persona.ENacionalidad.Argentino);
            Jornada jornada = new Jornada(Universidad.EClases.SPD, profesorSPD);

            Assert.IsNotNull(jornada.Alumnos);

        }


        /// <summary>
        /// Test que verifica que se lanze la excepcion  DniInvalidoException
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniNoValido()
        {

            Profesor profesorSPD = new Profesor(957, "Octavius", "Villegus", "$$·8fg298", Persona.ENacionalidad.Argentino);

        }


        /// <summary>
        /// Test que verifica que se lanze la excepcion  NacionalidadInvalidaException
        /// </summary>

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadNoValida()
        {

            Alumno alumno = new Alumno(7, "Alejandro", "De Moraiz", "9999999999", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

        }






    }
}
