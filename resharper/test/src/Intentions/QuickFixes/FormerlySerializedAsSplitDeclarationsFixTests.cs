﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using JetBrains.ReSharper.Plugins.Unity.Feature.Services.QuickFixes;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Intentions.QuickFixes
{
    [TestUnity]
    public class FormerlySerializedAsSplitDeclarationsFixAvailabilityTests : QuickFixAvailabilityTestBase
    {
        protected override string RelativeTestDataPath=> @"Intentions\QuickFixes\FormerlySerializedAsSplitDeclarations\Availability";

        [Test] public void Test01() { DoNamedTest(); }
    }

    [TestUnity]
    public class FormerlySerializedAsSplitDeclarationsFixRemoveTests : CSharpQuickFixTestBase<FormerlySerializedAsSplitDeclarationsFix>
    {
        protected override string RelativeTestDataPath=> @"Intentions\QuickFixes\FormerlySerializedAsSplitDeclarations";

        [Test] public void Test01() { DoNamedTest(); }
    }
}