﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpineHelper {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class GlobalStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpineHelper.GlobalStrings", typeof(GlobalStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AMO.
        /// </summary>
        internal static string AMO {
            get {
                return ResourceManager.GetString("AMO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrows.
        /// </summary>
        internal static string Arrows {
            get {
                return ResourceManager.GetString("Arrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASTM.
        /// </summary>
        internal static string ASTM {
            get {
                return ResourceManager.GetString("ASTM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving data to the device.
        /// </summary>
        internal static string CalibrationApplyHeader {
            get {
                return ResourceManager.GetString("CalibrationApplyHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are trying to set new sensors&apos; amplifier update frequency for the device.
        ///
        ///Previous value: {0}
        ///New value: {1}
        ///
        ///Do you wish to continue?.
        /// </summary>
        internal static string CalibrationApplyHX711 {
            get {
                return ResourceManager.GetString("CalibrationApplyHX711", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are trying to set new device scale factor for {0} weighting sensor.
        ///
        ///New value: {1}
        ///
        ///Do you wish to continue?.
        /// </summary>
        internal static string CalibrationApplySensor {
            get {
                return ResourceManager.GetString("CalibrationApplySensor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are trying to set new spine fixed deflection (spine calculation factor) for the device.
        ///
        ///Previous value: {0}
        ///New value: {1}
        ///
        ///Do you wish to continue?.
        /// </summary>
        internal static string CalibrationApplySpine {
            get {
                return ResourceManager.GetString("CalibrationApplySpine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are trying to set new spine difference threshold (spine calculation factor) for the device.
        ///
        ///Previous value: {0}
        ///New value: {1}
        ///
        ///Do you wish to continue?.
        /// </summary>
        internal static string CalibrationApplySpineDiff {
            get {
                return ResourceManager.GetString("CalibrationApplySpineDiff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin Calibration.
        /// </summary>
        internal static string CalibrationBegin {
            get {
                return ResourceManager.GetString("CalibrationBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instructions:
        ///
        ///1. Select a high quality carbon shaft with known exact spine - this shaft will be used as a reference. The better and straighter the shaft will be, the more precise value you&apos;ll get.
        ///
        ///2. Enter the shaft&apos;s known spine in ASTM (preferred) or AMO standard ic correct box.
        ///
        ///3. Switch to the main application window without closing this one and do a full test (2 spine tests) of the selected shaft.
        ///
        ///4. After the test switch back to this window without taking the shaft off the device.
        ///
        ///5. Cl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CalibrationInstructionsSpine {
            get {
                return ResourceManager.GetString("CalibrationInstructionsSpine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instructions:
        ///
        ///1. Select a weighting item you&apos;re going to use for the calibration. You should know the exact weight of the item. It&apos;s best to use 25-100 gram weights with 0,01g precision.
        ///
        ///2. Enter the weight of the item into the correct box (gram or grain).
        ///
        ///3. Select the sensor you&apos;d like to calibrate - left or right.
        ///
        ///4. Click &quot;Tare&quot; to tare/zero the device.
        ///
        ///5. Place the weight on the selected sensor.
        ///
        ///6. Click &quot;Begin Calibration&quot; and wait around 20-30 seconds.
        ///
        ///7. Click &quot;Stop&quot; to end test [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CalibrationInstructionsWeight {
            get {
                return ResourceManager.GetString("CalibrationInstructionsWeight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LEFT.
        /// </summary>
        internal static string CalibrationLeftUpper {
            get {
                return ResourceManager.GetString("CalibrationLeftUpper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will restore the device to factory settings.
        ///
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string CalibrationResetPopup {
            get {
                return ResourceManager.GetString("CalibrationResetPopup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring Factory Settings.
        /// </summary>
        internal static string CalibrationResetPopupHeader {
            get {
                return ResourceManager.GetString("CalibrationResetPopupHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RIGHT.
        /// </summary>
        internal static string CalibrationRightUpper {
            get {
                return ResourceManager.GetString("CalibrationRightUpper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calibrate Weighting Sensors.
        /// </summary>
        internal static string CalibrationSensors {
            get {
                return ResourceManager.GetString("CalibrationSensors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calibrate Spinetester.
        /// </summary>
        internal static string CalibrationSpine {
            get {
                return ResourceManager.GetString("CalibrationSpine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop.
        /// </summary>
        internal static string CalibrationStop {
            get {
                return ResourceManager.GetString("CalibrationStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found {0}!.
        /// </summary>
        internal static string ConnectFound {
            get {
                return ResourceManager.GetString("ConnectFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New COM port found!.
        /// </summary>
        internal static string ConnectFoundPort {
            get {
                return ResourceManager.GetString("ConnectFoundPort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spinetester USB at .
        /// </summary>
        internal static string ConnectionUSBName {
            get {
                return ResourceManager.GetString("ConnectionUSBName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DEBUG MODE: .
        /// </summary>
        internal static string DebugModeInfo {
            get {
                return ResourceManager.GetString("DebugModeInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the Arrow....
        /// </summary>
        internal static string DeviceCommandAllDone {
            get {
                return ResourceManager.GetString("DeviceCommandAllDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Place the Arrow....
        /// </summary>
        internal static string DeviceCommandReady {
            get {
                return ResourceManager.GetString("DeviceCommandReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bend the Arrow....
        /// </summary>
        internal static string DeviceCommandTestSpine {
            get {
                return ResourceManager.GetString("DeviceCommandTestSpine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rotate Arrow and Bend Again....
        /// </summary>
        internal static string DeviceCommandTestSpine2 {
            get {
                return ResourceManager.GetString("DeviceCommandTestSpine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wait....
        /// </summary>
        internal static string DeviceCommandWait {
            get {
                return ResourceManager.GetString("DeviceCommandWait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected.
        /// </summary>
        internal static string DeviceConnected {
            get {
                return ResourceManager.GetString("DeviceConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting....
        /// </summary>
        internal static string DeviceConnecting {
            get {
                return ResourceManager.GetString("DeviceConnecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect with .
        /// </summary>
        internal static string DeviceConnectWith {
            get {
                return ResourceManager.GetString("DeviceConnectWith", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device Ready.
        /// </summary>
        internal static string DeviceIsReady {
            get {
                return ResourceManager.GetString("DeviceIsReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Connected.
        /// </summary>
        internal static string DeviceNotConnected {
            get {
                return ResourceManager.GetString("DeviceNotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Testing Spine 1....
        /// </summary>
        internal static string DeviceSpine1Test {
            get {
                return ResourceManager.GetString("DeviceSpine1Test", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spine 1 Test Done.
        /// </summary>
        internal static string DeviceSpine1TestDone {
            get {
                return ResourceManager.GetString("DeviceSpine1TestDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Testing Spine 2....
        /// </summary>
        internal static string DeviceSpine2Test {
            get {
                return ResourceManager.GetString("DeviceSpine2Test", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spine 2 Test Done.
        /// </summary>
        internal static string DeviceSpine2TestDone {
            get {
                return ResourceManager.GetString("DeviceSpine2TestDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All Tests Done.
        /// </summary>
        internal static string DeviceStraightness {
            get {
                return ResourceManager.GetString("DeviceStraightness", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calibrating Sensors....
        /// </summary>
        internal static string DeviceWeightCalibration {
            get {
                return ResourceManager.GetString("DeviceWeightCalibration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Testing Weight....
        /// </summary>
        internal static string DeviceWeightTest {
            get {
                return ResourceManager.GetString("DeviceWeightTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weight Test Done.
        /// </summary>
        internal static string DeviceWeightTestDone {
            get {
                return ResourceManager.GetString("DeviceWeightTestDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while opening the web page!
        ///
        ///Error Message: .
        /// </summary>
        internal static string ErrorOpeningWebPage {
            get {
                return ResourceManager.GetString("ErrorOpeningWebPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exporting failed!
        ///Error with selected file type: Unsupported type.
        ///
        ///FileFilterIndex = {0}
        ///
        ///Error: {1}.
        /// </summary>
        internal static string ExportError {
            get {
                return ResourceManager.GetString("ExportError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to grains.
        /// </summary>
        internal static string GrainsLowcase {
            get {
                return ResourceManager.GetString("GrainsLowcase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to grams.
        /// </summary>
        internal static string GramsLowcase {
            get {
                return ResourceManager.GetString("GramsLowcase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to clear all the history?.
        /// </summary>
        internal static string HistoryClear {
            get {
                return ResourceManager.GetString("HistoryClear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear All History.
        /// </summary>
        internal static string HistoryClearHeader {
            get {
                return ResourceManager.GetString("HistoryClearHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to remove the latest history entry?.
        /// </summary>
        internal static string HistoryRemoveEntry {
            get {
                return ResourceManager.GetString("HistoryRemoveEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Entry.
        /// </summary>
        internal static string HistoryRemoveEntryHeader {
            get {
                return ResourceManager.GetString("HistoryRemoveEntryHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1st AMO.
        /// </summary>
        internal static string HistoryViewColumnAMO1 {
            get {
                return ResourceManager.GetString("HistoryViewColumnAMO1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2nd AMO.
        /// </summary>
        internal static string HistoryViewColumnAMO2 {
            get {
                return ResourceManager.GetString("HistoryViewColumnAMO2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1st ASTM.
        /// </summary>
        internal static string HistoryViewColumnASTM1 {
            get {
                return ResourceManager.GetString("HistoryViewColumnASTM1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2nd ASTM.
        /// </summary>
        internal static string HistoryViewColumnASTM2 {
            get {
                return ResourceManager.GetString("HistoryViewColumnASTM2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comment.
        /// </summary>
        internal static string HistoryViewColumnComment {
            get {
                return ResourceManager.GetString("HistoryViewColumnComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GPI.
        /// </summary>
        internal static string HistoryViewColumnGPI {
            get {
                return ResourceManager.GetString("HistoryViewColumnGPI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grains.
        /// </summary>
        internal static string HistoryViewColumnGrains {
            get {
                return ResourceManager.GetString("HistoryViewColumnGrains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grams.
        /// </summary>
        internal static string HistoryViewColumnGrams {
            get {
                return ResourceManager.GetString("HistoryViewColumnGrams", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Straightness.
        /// </summary>
        internal static string HistoryViewColumnStraightness {
            get {
                return ResourceManager.GetString("HistoryViewColumnStraightness", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Selected Arrow.
        /// </summary>
        internal static string HistoryViewRemoveArrow {
            get {
                return ResourceManager.GetString("HistoryViewRemoveArrow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Selected Arrows.
        /// </summary>
        internal static string HistoryViewRemoveArrows {
            get {
                return ResourceManager.GetString("HistoryViewRemoveArrows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you really want to remove selected arrows from your history?.
        /// </summary>
        internal static string HistoryViewRemoveArrowsConfirmation {
            get {
                return ResourceManager.GetString("HistoryViewRemoveArrowsConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Program will install Spinetester USB drivers.
        ///
        ///Do you wish to continue?.
        /// </summary>
        internal static string InstallDriversUSB {
            get {
                return ResourceManager.GetString("InstallDriversUSB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Install Spinetester Drivers.
        /// </summary>
        internal static string InstallDriversUSBHeader {
            get {
                return ResourceManager.GetString("InstallDriversUSBHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        internal static string LanguageUnknown {
            get {
                return ResourceManager.GetString("LanguageUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://daedalus.pl/spinehelper/SpineHelper_Manual_PL.pdf.
        /// </summary>
        internal static string ManualLink {
            get {
                return ResourceManager.GetString("ManualLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No data to export. History is empty..
        /// </summary>
        internal static string NoDataToExport {
            get {
                return ResourceManager.GetString("NoDataToExport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No data to save. History is empty..
        /// </summary>
        internal static string NoDataToSave {
            get {
                return ResourceManager.GetString("NoDataToSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The device is not connected!
        ///
        ///Make sure you selected correct COM port and your USB cable is not damaged.
        ///
        ///If you didn&apos;t install the device USB drivers already, you can do this by using menu Device -&gt; Install USB drivers..
        /// </summary>
        internal static string NotConnectedPopup {
            get {
                return ResourceManager.GetString("NotConnectedPopup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Device Not Connected.
        /// </summary>
        internal static string NotConnectedPopupHeader {
            get {
                return ResourceManager.GetString("NotConnectedPopupHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your history has been successfully exported..
        /// </summary>
        internal static string SerializerExportSuccessful {
            get {
                return ResourceManager.GetString("SerializerExportSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export Successful.
        /// </summary>
        internal static string SerializerExportSuccessfulHeader {
            get {
                return ResourceManager.GetString("SerializerExportSuccessfulHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export to a file.
        /// </summary>
        internal static string SerializerExportToFile {
            get {
                return ResourceManager.GetString("SerializerExportToFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading failed!
        ///
        ///Error message: .
        /// </summary>
        internal static string SerializerLoadError {
            get {
                return ResourceManager.GetString("SerializerLoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your history has been successfully loaded..
        /// </summary>
        internal static string SerializerLoadSuccessful {
            get {
                return ResourceManager.GetString("SerializerLoadSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading Successful.
        /// </summary>
        internal static string SerializerLoadSuccessfulHeader {
            get {
                return ResourceManager.GetString("SerializerLoadSuccessfulHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading saved arrow set will clear current results.
        ///
        ///Do you want to continue?.
        /// </summary>
        internal static string SerializerLoadWarning {
            get {
                return ResourceManager.GetString("SerializerLoadWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load saved arrow data.
        /// </summary>
        internal static string SerializerLoadWarningHeader {
            get {
                return ResourceManager.GetString("SerializerLoadWarningHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open a saved data file.
        /// </summary>
        internal static string SerializerOpenFile {
            get {
                return ResourceManager.GetString("SerializerOpenFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving failed!
        ///
        ///Error message: .
        /// </summary>
        internal static string SerializerSaveError {
            get {
                return ResourceManager.GetString("SerializerSaveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your history has been successfully saved..
        /// </summary>
        internal static string SerializerSaveSuccessful {
            get {
                return ResourceManager.GetString("SerializerSaveSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving Successful.
        /// </summary>
        internal static string SerializerSaveSuccessfulHeader {
            get {
                return ResourceManager.GetString("SerializerSaveSuccessfulHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save data to a file.
        /// </summary>
        internal static string SerializerSaveToFile {
            get {
                return ResourceManager.GetString("SerializerSaveToFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This application cannot be updated. It is likely not a ClickOnce application.
        ///
        ///Error: .
        /// </summary>
        internal static string UpdateApplicationError {
            get {
                return ResourceManager.GetString("UpdateApplicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application Error.
        /// </summary>
        internal static string UpdateApplicationErrorHeader {
            get {
                return ResourceManager.GetString("UpdateApplicationErrorHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An update is available. Would you like to update the application now?.
        /// </summary>
        internal static string UpdateAvailable {
            get {
                return ResourceManager.GetString("UpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Available.
        /// </summary>
        internal static string UpdateAvailableHeader {
            get {
                return ResourceManager.GetString("UpdateAvailableHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new version of the application cannot be downloaded at this time.
        ///Please check your network connection, or try again later.
        ///
        ///Error: .
        /// </summary>
        internal static string UpdateConnectionError {
            get {
                return ResourceManager.GetString("UpdateConnectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Error.
        /// </summary>
        internal static string UpdateConnectionErrorHeader {
            get {
                return ResourceManager.GetString("UpdateConnectionErrorHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot install the latest version of the application. Please check your network connection, or try again later.
        ///
        ///Error:.
        /// </summary>
        internal static string UpdateErrorNet {
            get {
                return ResourceManager.GetString("UpdateErrorNet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went very wrong while checking for updates... You shouldn&apos;t be seeing this..
        /// </summary>
        internal static string UpdateFatalError {
            get {
                return ResourceManager.GetString("UpdateFatalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This application has detected a mandatory update from your current version to version {0}.
        ///The application will now install the update and restart..
        /// </summary>
        internal static string UpdateForced {
            get {
                return ResourceManager.GetString("UpdateForced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot check for a new version of the application. The ClickOnce deployment is corrupt.
        ///Please redeploy the application and try again.
        ///
        ///Error: .
        /// </summary>
        internal static string UpdateInstallationError {
            get {
                return ResourceManager.GetString("UpdateInstallationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installation Error.
        /// </summary>
        internal static string UpdateInstallationErrorHeader {
            get {
                return ResourceManager.GetString("UpdateInstallationErrorHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The application has been updated, and will now restart..
        /// </summary>
        internal static string UpdateInstalled {
            get {
                return ResourceManager.GetString("UpdateInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot check for updates..
        /// </summary>
        internal static string UpdateNotDeployed {
            get {
                return ResourceManager.GetString("UpdateNotDeployed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have the latest version of the application..
        /// </summary>
        internal static string UpdateUpToDate {
            get {
                return ResourceManager.GetString("UpdateUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application is up-to-date.
        /// </summary>
        internal static string UpdateUpToDateHeader {
            get {
                return ResourceManager.GetString("UpdateUpToDateHeader", resourceCulture);
            }
        }
    }
}
