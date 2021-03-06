﻿Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace DragAndDropRows
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.UserSkins.BonusSkins.Register()
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")

            Application.Run(New Form1())
        End Sub
    End Class
End Namespace