﻿using JetBrains.ReSharper.Plugins.Unity.Daemon.Stages.Highlightings;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Daemon.Stages.Analysis
{
    [TestUnity]
    public class RedundantAttributeOnTargetAnalyzerTests : CSharpHighlightingTestBase<IUnityHighlighting>
    {
        protected override string RelativeTestDataPath => @"daemon\Stages\Analysis\RedundantAttributeOnTarget";

        [Test] public void TestAddComponentMenu() { DoNamedTest2(); }
        [Test] public void TestExecuteInEditMode() { DoNamedTest2(); }
        [Test] public void TestHideInInspector() { DoNamedTest2(); }
        [Test] public void TestImageEffectAllowedInSceneView() { DoNamedTest2(); }
        [Test] public void TestImageEffectOpaque() { DoNamedTest2(); }
        [Test] public void TestImageEffectTransformsToLDR() { DoNamedTest2(); }
        [Test] public void TestSerializeField() { DoNamedTest2(); }
        [Test] public void TestCanEditMultipleObjects() { DoNamedTest2(); }
        [Test] public void TestCustomEditor() { DoNamedTest2(); }
        [Test] public void TestDrawGizmo() { DoNamedTest2(); }
        [Test] public void TestDidReloadScripts() { DoNamedTest2(); }
        [Test] public void TestOnOpenAssetAttribute() { DoNamedTest2(); }
        [Test] public void TestPostProcessBuildAttribute() { DoNamedTest2(); }
        [Test] public void TestPostProcessSceneAttribute() { DoNamedTest2(); }
    }
}