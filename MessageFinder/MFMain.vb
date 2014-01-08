Public Class MFMain

    Private winMsgs As Dictionary(Of String, Int32)

    Private Sub appInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        winMsgs = New Dictionary(Of String, Int32)

        For Each item In [Enum].GetNames(GetType(WindowMessages))
            winMsgs.Add(item, [Enum].Parse(GetType(WindowMessages), item))
            lstMessage.Items.Add(item)

        Next

    End Sub
    Private Function getSimilarKeys(ByVal PartialKeyName As String) As String()

        Dim SimilarKeyList As New List(Of String)
        For Each k As String In winMsgs.Keys
            If k.ToLower Like "*" & PartialKeyName.ToLower & "*" Then SimilarKeyList.Add(k)
        Next
        Return SimilarKeyList.ToArray

    End Function
    Private Function getValueKeys(ByVal Value As Int32) As String()

        Dim valueKeyList As New List(Of String)
        For Each k As String In winMsgs.Keys
            If winMsgs(k) = Value Then valueKeyList.Add(k)
        Next
        Return valueKeyList.ToArray

    End Function
    Private Sub watchKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMessage.KeyPress

        Select Case Asc(Char.ToLower(e.KeyChar))
            Case 48 To 57, 8    ' 0 ~ 9, Backspace

            Case 97 To 102      ' A ~ F
                If chkFindValue.Checked AndAlso (Not HexFind.Checked) Then e.Handled = True

            Case Else
                If chkFindValue.Checked Then e.Handled = True

        End Select

    End Sub
    Private Sub updateSimilarKeys(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessage.TextChanged

        lstMessage.Items.Clear()

        If chkFindValue.Checked Then
            If DecFind.Checked Then
                lstMessage.Items.AddRange(getValueKeys(Val(txtMessage.Text)))
            Else
                lstMessage.Items.AddRange(getValueKeys(Val("&H" & txtMessage.Text)))
            End If
        Else
            lstMessage.Items.AddRange(getSimilarKeys(txtMessage.Text))
        End If

    End Sub
    Private Sub updateFindMethod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFindValue.CheckedChanged, DecFind.CheckedChanged, HexFind.CheckedChanged

        txtMessage.Text = vbNullString
        If chkFindValue.Checked Then
            DecFind.Enabled = True
            HexFind.Enabled = True
        Else
            DecFind.Enabled = False
            HexFind.Enabled = False
        End If

    End Sub
    Private Sub updateDefinition(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMessage.SelectedIndexChanged

        txtDefinition.Text = vbNullString
        For Each si As String In lstMessage.SelectedItems

            If Not String.IsNullOrEmpty(si) Then

                If CStyle.Checked Then
                    txtDefinition.Text &= "#define " & si & " 0x" & Hex$(winMsgs(si)) & vbCrLf
                    Continue For
                End If

                If CSharpStyle.Checked Then
                    txtDefinition.Text &= "public const int " & si & " = 0x" & Hex$(winMsgs(si)) & vbCrLf
                    Continue For
                End If

                If VbStyle.Checked Then
                    txtDefinition.Text &= "Public Const " & si & " = &H" & Hex$(winMsgs(si)) & vbCrLf
                    Continue For
                End If

            End If

        Next

        If Not String.IsNullOrEmpty(txtDefinition.Text) Then txtDefinition.Text = txtDefinition.Text.Remove(txtDefinition.Text.Length - 1)

    End Sub
    Private Sub updateDefinitionMethod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CStyle.CheckedChanged, CSharpStyle.CheckedChanged, VbStyle.CheckedChanged

        updateDefinition(Nothing, Nothing)

    End Sub

    ''' DEPRECATED
    'Private Sub appResize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    '    txtMessage.Width = Me.ClientSize.Width - (txtMessage.Left + 9)
    '    panFindMethod.Left = Me.ClientSize.Width - (panFindMethod.Width + 9)

    '    lstMessage.Width = Me.ClientSize.Width - (lstMessage.Left + 9)
    '    lstMessage.Height = Me.ClientSize.Height - 

    '    txtDefinition.Width = Me.ClientSize.Width - (txtDefinition.Left + 9)

    'End Sub

End Class