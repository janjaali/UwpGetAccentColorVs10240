# UWP Application for build v10240 vs UISettings::GetColorValue

Simple UWP Application using the UISettings.GetColorValue(UIColorType.Accent) and causing an InvalidCastException:

    Unable to cast object of type 'Windows.UI.ViewManagement.UISettings' to type 'Windows.UI.ViewManagement.IUISettings3'.

This application should serve as showcase for the not-catched-exception and is not runnable for builds with v10240.  