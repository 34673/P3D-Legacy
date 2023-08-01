Namespace Items.Mail

    <Item(306, "Mech Mail")>
    Public Class MechMail

        Inherits MailItem

        Public Overrides ReadOnly Property Description As String = "A Magnemite-print Mail to be held by a Pokémon."

        Public Sub New()
            _textureRectangle = New Rectangle(120, 456, 24, 24)
        End Sub

        Public Overrides Sub Use()
            Dim MailID As String
            If Me.IsGameModeItem = True Then
                MailID = Me.gmID
            Else
                MailID = Me.ID.ToString
            End If
            Core.SetScreen(New TransitionScreen(Core.CurrentScreen, New MailSystemScreen(Core.CurrentScreen, MailID), Color.Black, False))
        End Sub

    End Class

End Namespace
