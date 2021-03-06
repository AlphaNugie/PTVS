// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRunnerInterop;

namespace PythonToolsUITestsRunner {
    [TestClass]
    public class EnvironmentUITests {
        #region UI test boilerplate
        public VsTestInvoker _vs => new VsTestInvoker(
            VsTestContext.Instance,
            // Remote container (DLL) name
            "Microsoft.PythonTools.Tests.PythonToolsUITests",
            // Remote class name
            $"PythonToolsUITests.{GetType().Name}"
        );

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize() => VsTestContext.Instance.TestInitialize(TestContext.DeploymentDirectory);
        [TestCleanup]
        public void TestCleanup() => VsTestContext.Instance.TestCleanup();
        [ClassCleanup]
        public static void ClassCleanup() => VsTestContext.Instance.Dispose();
        #endregion


        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void InstallUninstallPackage() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.InstallUninstallPackage));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void CreateInstallRequirementsTxt() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.CreateInstallRequirementsTxt));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void InstallGenerateRequirementsTxt() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.InstallGenerateRequirementsTxt));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void LoadVEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.LoadVEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void ActivateVEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.ActivateVEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void RemoveVEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.RemoveVEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void DeleteVEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.DeleteVEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void DefaultBaseInterpreterSelection() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.DefaultBaseInterpreterSelection));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void CreateVEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.CreateVEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void CreateCondaEnvFromPackages() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.CreateCondaEnvFromPackages));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void CreateCondaEnvFromEnvFile() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.CreateCondaEnvFromEnvFile));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void AddExistingVEnvLocal() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.AddExistingVEnvLocal));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void AddCustomEnvLocal() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.AddCustomEnvLocal));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void AddExistingEnv() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.AddExistingEnv));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void LaunchUnknownEnvironment() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.LaunchUnknownEnvironment));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void EnvironmentReplWorkingDirectory() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.EnvironmentReplWorkingDirectory));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void VirtualEnvironmentReplWorkingDirectory() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.VirtualEnvironmentReplWorkingDirectory));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void SwitcherSingleProject() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.SwitcherSingleProject));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void SwitcherWorkspace() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.SwitcherWorkspace));
        }

        [TestMethod, Priority(0)]
        [TestCategory("Installed")]
        public void SwitcherNoProject() {
            _vs.RunTest(nameof(PythonToolsUITests.EnvironmentUITests.SwitcherNoProject));
        }
    }
}
