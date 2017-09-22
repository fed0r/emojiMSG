Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim outcome As Object
        outcome = Me.TextBox1.Text
        outcome = Strings.Replace(Convert.ToString(outcome), "a", "🇦 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "b", "🇧 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "c", "🇨 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "d", "🇩 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "e", "🇪 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "f", "🇫 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "g", "🇬 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "h", "🇭 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "i", "🇮 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "j", "🇯 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "k", "🇰 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "l", "🇱 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "m", "🇲 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "n", "🇳 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "o", "🇴 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "p", "🇵 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "q", "🇶 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "r", "🇷 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "s", "🇸 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "t", "🇹 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "u", "🇺 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "v", "🇻 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "w", "🇼 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "x", "🇽 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "y", "🇾 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "z", "🇿 ")
        'caps
        outcome = Strings.Replace(Convert.ToString(outcome), "A", "🇦 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "B", "🇧 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "C", "🇨 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "D", "🇩 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "E", "🇪 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "F", "🇫 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "G", "🇬 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "H", "🇭 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "J", "🇮 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "J", "🇯 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "K", "🇰 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "L", "🇱 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "M", "🇲 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "N", "🇳 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "O", "🇴 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "P", "🇵 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "Q", "🇶 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "R", "🇷 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "S", "🇸 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "T", "🇹 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "U", "🇺 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "V", "🇻 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "W", "🇼 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "X", "🇽 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "Y", "🇾 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "Z", "🇿 ")
        outcome = Strings.Replace(Convert.ToString(outcome), "?", "❓ ")
        outcome = Strings.Replace(Convert.ToString(outcome), "!", "❗ ")
        Me.TextBox2.Text = Convert.ToString(outcome)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() 'Generate emojimsg
    End Sub
End Class
