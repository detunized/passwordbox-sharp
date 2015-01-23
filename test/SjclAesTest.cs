// Copyright (C) 2015 Dmitry Yakimenko (detunized@gmail.com).
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;
using NUnit.Framework;

namespace PasswordBox.Test
{
    [TestFixture]
    class SjclAesTest
    {
        [Test]
        public void ComputeDoubleTable_returns_correct_result()
        {
            var table = SjclAes.ComputeDoubleTable();

            // Test data is generated with SJCL sources
            Assert.AreEqual(256, table.Length);

            Assert.AreEqual(  0, table[  0]);
            Assert.AreEqual(  2, table[  1]);
            Assert.AreEqual(  4, table[  2]);
            Assert.AreEqual(254, table[127]);
            Assert.AreEqual( 27, table[128]);
            Assert.AreEqual(231, table[254]);
            Assert.AreEqual(229, table[255]);
        }

        [Test]
        public void ComputeTrippleTable_returns_correct_result()
        {
            var table = SjclAes.ComputeTrippleTable(SjclAes.ComputeDoubleTable());

            // Test data is generated with SJCL sources
            Assert.AreEqual(256, table.Length);

            Assert.AreEqual(  0, table[  0]);
            Assert.AreEqual(246, table[  1]);
            Assert.AreEqual(247, table[  2]);
            Assert.AreEqual(220, table[127]);
            Assert.AreEqual(137, table[128]);
            Assert.AreEqual(163, table[254]);
            Assert.AreEqual( 85, table[255]);
        }
    }
}
