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
    ///The VerifyNotifications recording.
    /// </summary>
    [TestModule("8cf6f0e5-5ede-4db6-b85e-770375c736ac", ModuleType.Recording, 1)]
    public partial class VerifyNotifications : ITestModule
    {
        /// <summary>
        /// Holds an instance of the iOS_WS_TestRepository repository.
        /// </summary>
        public static iOS_WS_TestRepository repo = iOS_WS_TestRepository.Instance;

        static VerifyNotifications instance = new VerifyNotifications();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyNotifications()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyNotifications Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Notifications_link' at Center", repo.ComPentairPentairhome.Notifications_linkInfo, new RecordItemIndex(1));
            repo.ComPentairPentairhome.Notifications_link.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(2));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'Notifications'. Associated repository item: 'ComPentairPentairhome.Notifications_Header'", repo.ComPentairPentairhome.Notifications_HeaderInfo, new RecordItemIndex(3));
            repo.ComPentairPentairhome.Notifications_HeaderInfo.WaitForAttributeEqual(5000, "Visible", "Notifications");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibilityLabel='All Notifications') on item 'ComPentairPentairhome.AllNotifications'.", repo.ComPentairPentairhome.AllNotificationsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ComPentairPentairhome.AllNotificationsInfo, "AccessibilityLabel", "All Notifications");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'ComPentairPentairhome.Toggle_All'.", repo.ComPentairPentairhome.Toggle_AllInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ComPentairPentairhome.Toggle_AllInfo, "Enabled", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Backarrow_Notifications' at Center", repo.ComPentairPentairhome.Backarrow_NotificationsInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.Backarrow_Notifications.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
