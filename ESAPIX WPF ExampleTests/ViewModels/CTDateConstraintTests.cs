using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void CTDateFailsIfOlderThan60Days()
        {
            //Arrange
            var ctDateConstraint = new CTDateConstraint();
            var creationDate = DateTime.Now.AddDays(-61);

            //Act
            var result = ctDateConstraint.ConstraintCTDate(creationDate);

            //Assert
            Assert.AreEqual(ResultType.ACTION_LEVEL_3, result.ResultType);

        }

        [TestMethod()]
        public void CTDatePassesIfNewerThan60Days()
        {
            //Arrange
            var ctDateConstraint = new CTDateConstraint();
            var creationDate = DateTime.Now.AddDays(-59);

            //Act
            var result = ctDateConstraint.ConstraintCTDate(creationDate);

            //Assert
            Assert.AreEqual(ResultType.PASSED, result.ResultType);

        }

        [TestMethod()]
        public void CTDatePassesIfExactly60Days()
        {
            //Arrange
            var ctDateConstraint = new CTDateConstraint();
            var creationDate = DateTime.Now.AddDays(-60);

            //Act
            var result = ctDateConstraint.ConstraintCTDate(creationDate);

            //Assert
            Assert.AreEqual(ResultType.PASSED, result.ResultType);

        }
    }
}