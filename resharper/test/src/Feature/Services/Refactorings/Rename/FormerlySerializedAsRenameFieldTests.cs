﻿using JetBrains.ReSharper.Plugins.Unity.Tests.Framework;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Feature.Services.Refactorings.Rename
{
    [TestUnity]
    public class FormerlySerializedAsRenameFieldTests : RenameTestBase
    {
        protected override string RelativeTestDataPath => @"Refactorings\Rename";

        [Test] public void Test01() { DoNamedTest(); }
        [Test] public void Test02() { DoNamedTest(); }
        [Test] public void Test03() { DoNamedTest(); }
        [Test] public void Test04() { DoNamedTest(); }
        [Test] public void Test05() { DoNamedTest(); }
        [Test] public void Test06() { DoNamedTest(); }
    }
}