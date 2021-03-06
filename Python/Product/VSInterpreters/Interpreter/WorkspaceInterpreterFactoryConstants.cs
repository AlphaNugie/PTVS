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

using System;
using System.Text.RegularExpressions;

namespace Microsoft.PythonTools.Interpreter {
    /// <summary>
    /// Provides constants used to identify interpreters that are detected from
    /// the current workspace.
    /// </summary>
    static class WorkspaceInterpreterFactoryConstants {
        public const string ConsoleExecutable = "python.exe";
        public const string WindowsExecutable = "pythonw.exe";
        public const string LibrarySubPath = "lib";
        public const string PathEnvironmentVariableName = "PYTHONPATH";
        internal const string FactoryProviderName = "Workspace";
        internal const string EnvironmentCompanyName = "Workspace";

        private static readonly Regex IdParser = new Regex(
            "^(?<provider>.+?)\\|(?<company>.+?)\\|(?<tag>.+?)$",
            RegexOptions.None,
            TimeSpan.FromSeconds(1)
        );

        public static string GetInterpreterId(string company, string tag) {
            return String.Join(
                "|",
                FactoryProviderName,
                company,
                tag
            );
        }
    }
}
