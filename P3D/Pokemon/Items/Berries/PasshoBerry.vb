Namespace Items.Berries

    <Item(2036, "Passho")>
    Public Class PasshoBerry

        Inherits Berry
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False
        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Sub New()
            MyBase.New(64800, "If held by a Pokémon, this Berry will lessen the damage taken from one supereffective Water-type attack.", "3.3cm", "Soft", 1, 5)

            Me.Spicy = 0
            Me.Dry = 15
            Me.Sweet = 0
            Me.Bitter = 10
            Me.Sour = 0

            Me.Type = Element.Types.Water
            Me.Power = 80
            Me.JuiceColor = "blue"
            Me.JuiceGroup = 2
        End Sub

    End Class

End Namespace
