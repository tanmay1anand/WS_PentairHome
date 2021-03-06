﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace iOS_WS_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Launch recording.
    /// </summary>
    [TestModule("0bf07ea7-6cfc-4033-8a1c-635779ce6785", ModuleType.Recording, 1)]
    public partial class Launch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the iOS_WS_TestRepository repository.
        /// </summary>
        public static iOS_WS_TestRepository repo = iOS_WS_TestRepository.Instance;

        static Launch instance = new Launch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Launch()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Launch Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.pentair.pentairhome' on device 'Tanmay's iPhone'.", new RecordItemIndex(1));
            Host.Local.RunMobileApp("Tanmay's iPhone", "com.pentair.pentairhome", false);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
