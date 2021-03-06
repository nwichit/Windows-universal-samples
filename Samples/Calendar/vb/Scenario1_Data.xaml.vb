'*********************************************************
'
' Copyright (c) Microsoft. All rights reserved.
' This code is licensed under the MIT License (MIT).
' THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
' ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
' IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
' PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Imports Windows.Foundation
Imports Windows.Globalization
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls

Namespace Global.SDKTemplate

    Public NotInheritable Partial Class Scenario1_Data
        Inherits Page

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Function ReportCalendarData(calendar As Calendar, calendarLabel As String) As String
            Dim results As String = calendarLabel & ": " & calendar.GetCalendarSystem() & vbLf
            results &= "Name of Month: " & calendar.MonthAsSoloString() & vbLf
            results &= "Day of Month: " & calendar.DayAsPaddedString(2) & vbLf
            results &= "Day of Week: " & calendar.DayOfWeekAsSoloString() & vbLf
            results &= "Year: " & calendar.YearAsString() & vbLf
            results &= vbLf
            Return results
        End Function

        Private Sub ShowResults_Click(sender As Object, e As RoutedEventArgs)
            ' This scenario uses the Windows.Globalization.Calendar class to display the parts of a date.
            ' Create Calendar objects using different constructors.
            Dim calendar As Calendar = New Calendar()
            Dim japaneseCalendar As Calendar = New Calendar({"ja-JP"}, CalendarIdentifiers.Japanese, ClockIdentifiers.TwelveHour)
            Dim hebrewCalendar As Calendar = New Calendar({"he-IL"}, CalendarIdentifiers.Hebrew, ClockIdentifiers.TwentyFourHour)
            OutputTextBlock.Text = ReportCalendarData(calendar, "User's default calendar system") & ReportCalendarData(japaneseCalendar, "Calendar system") & ReportCalendarData(hebrewCalendar, "Calendar system")
        End Sub
    End Class
End Namespace
