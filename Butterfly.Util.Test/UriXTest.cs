/* Any copyright is dedicated to the Public Domain.
 * http://creativecommons.org/publicdomain/zero/1.0/ */

using System;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Butterfly.Util;

namespace Butterfly.Util.Test {
    [TestClass]
    public class UriXTest {
        [TestMethod]
        public void ParseQuery() {
            var uri = new Uri("http://butterflyserver.io/hello/world?x=15");
            var query = uri.ParseQuery();
            Assert.AreEqual("15", query["x"]);
        }

    }
}
