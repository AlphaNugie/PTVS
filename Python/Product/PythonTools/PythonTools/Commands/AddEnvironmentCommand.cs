﻿// Python Tools for Visual Studio
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
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.PythonTools.Infrastructure.Commands;
using Microsoft.PythonTools.Environments;

namespace Microsoft.PythonTools.Commands {
    class AddEnvironmentCommand : IAsyncCommand {
        private readonly IServiceProvider _serviceProvider;
        private readonly EnvironmentSwitcherManager _envSwitchMgr;

        public AddEnvironmentCommand(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _envSwitchMgr = serviceProvider.GetPythonToolsService().EnvironmentSwitcherManager;
        }

        public CommandStatus Status => CommandStatus.SupportedAndEnabled;

        public Task InvokeAsync() {
            // We'll add support for open folder later
            // https://github.com/Microsoft/PTVS/issues/4852
            var project = (_envSwitchMgr.Context as EnvironmentSwitcherProjectContext)?.Project;
            if (project == null) {
                var sln = (IVsSolution)_serviceProvider.GetService(typeof(SVsSolution));
                project = sln?.EnumerateLoadedPythonProjects().FirstOrDefault();
            }

            string ymlPath = project?.GetEnvironmentYmlPath();
            string txtPath = project?.GetRequirementsTxtPath();

            return AddEnvironmentDialog.ShowAddEnvironmentDialogAsync(_serviceProvider, project, null, ymlPath, txtPath);
        }
    }
}
